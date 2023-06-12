"""Message Broker"""
import enum
from typing import Dict, List, Any, Tuple

import socket
import selectors
import sys
import json
import pickle
import xml.etree.ElementTree as ET

class Serializer(enum.Enum):
    """Possible message serializers."""

    JSON = 0
    XML = 1
    PICKLE = 2


class Broker:
    """Implementation of a PubSub Message Broker."""

    def __init__(self):
        """Initialize broker."""
        self.canceled = False
        self._host = "localhost"
        self._port = 5000
        self.users = {}                 #{(connection, serialization): [topic]}
        self.topics = {}                #{topic: [message, message, message, ...]
        self.sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        self.sock.bind((self._host, self._port))
        self.sock.listen(100)
        self.selector = selectors.DefaultSelector()
        self.selector.register(self.sock, selectors.EVENT_READ, self.accept)
        self.selector = selectors.DefaultSelector()

    def list_topics(self) -> List[str]:
        """Returns a list of strings containing all topics containing values."""
        return self.topics.keys()

    def get_topic(self, topic):
        """Returns the currently stored value in topic."""
        for top in self.topics.keys():
            if topic.startswith(top):
                val = self.topics[top]
                return val[0] if len(val) == 1 else val

    def put_topic(self, topic, value):
        """Store in topic the value."""
        if topic not in self.topics:
            self.topics[topic] = [value]
        else:
            self.topics[topic].append(value)
        
    def list_subscriptions(self, topic: str) -> List[Tuple[socket.socket, Serializer]]:
        """Provide list of subscribers to a given topic."""
        ret = []
        for user, topics in self.users.items():
            if topic in topics:
                ret.append(user)
        return ret

    def subscribe(self, topic: str, address: socket.socket, _format: Serializer = None):
        """Subscribe to topic by client in address."""
        for user in self.users:
            if address == user[0]:
                self.users[user].append(topic)
                return
        self.users[(address, _format)] = [topic]
        
    def unsubscribe(self, topic, address):
        """Unsubscribe to topic by client in address."""
        for user in self.users:
            if user[0] == address:
                self.users[user].remove(topic)

    def deparse(self, value, serialization):
        if serialization == "json":
            return (json.dumps(data)).encode("utf-8")
        elif serialization == "xml":
            return data.encode("utf-8")
        elif serialization == "pickle":
            return pickle.dumps(data)

    def parse(self, value, serialization):
        if serialization == "json":
            return json.loads(data.decode("utf-8"))
        elif serialization == "xml":
            tree = ET.ElementTree(ET.fromstring(data.decode("utf-8")))
            res = {}
            for elem in tree.iter():
                res[elem.tag] = el.text
            return res
        elif serialization == "pickle":
            return pickle.loads(data)

    def construct(self, method, topic, value, serialization):
        if serialization == "xml":
            ret = f"<method>{str(method)}</method><message>{str(value)}</message>"
            if topic:
                ret=f"{ret}<topic>{str(topic)}</topic>"
            return f"<data>{ret}</data>"
        else:
            ret = {"method": method, "value": value}
            if topic:
                ret["topic"] = topic
            return ret

    def accept(self, connection):
        connection, address= sock.accept()
        self.selector.register(connection, selectors.EVENT_READ, self.read)

    def read(self, connection):
        size = int.from_bytes(connection.recv(2), "big")
        body = connection.recv(size)
        
        if body:
            serialization = None
            for user in self.users:
                if user[0] == connection:
                    serialization = user[1]
            if not serialization:
                serialization = "json"
            data = self.parse(body, serialization)
            print(data)
            if data:
                if all(map(lambda x: x[0] != connection, self.users)):
                    self.users[(connection, serialization)] = []
                if data["method"] == "PUB":
                    self.put_topic(data["topic"], data["message"])
                    for key, values in self.users.items():
                        for topic in values:
                            if data["topic"].startswith(topic):
                                rep = self.deparse(self.construct("REP", data["topic"], data["message"], key[1]), key[1])
                                key[0].send(len(rep).to_bytes(2, "big")+rep)
                elif data["method"] == "TOPS":
                    rep = self.deparse(self.construct("REP", None, str(self.list_topics()), serialization), serialization)
                    connection.send(len(rep).to_bytes(2, "big")+rep)
                elif data["method"] == "SUB":
                    self.subscribe(data["topic"],connection,serialization)
                    current_message = self.get_topic(data["topic"])
                    if current_message:
                        rep = self.deparse(self.construct("REP", data["topic"], current_message, serialization), serialization)
                        connection.send(len(rep).to_bytes(2, "big")+rep)    
                elif data["method"] == "CANC":
                    self.unsubscribe(data["topic"], connection)
            else:
                self.selector.unregister(connection)
                connection.close()
                    
    def run(self):
        """Run until canceled."""
        while not self.canceled:
            try:
                for key, _ in self.selector.select():
                    callback = key.data
                    callback(key.fileobj)
            except Exception as e:
                print(e)
                sys.exit(0)
