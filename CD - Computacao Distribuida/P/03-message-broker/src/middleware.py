"""Middleware to communicate with PubSub Message Broker."""
import json
import socket
from collections.abc import Callable
from enum import Enum
from queue import LifoQueue, Empty
from typing import Any
import pickle
import xml.etree.ElementTree as ET


class MiddlewareType(Enum):
    """Middleware Type."""

    CONSUMER = 1
    PRODUCER = 2


class Queue:
    """Representation of Queue interface for both Consumers and Producers."""

    def __init__(self, topic, _type=MiddlewareType.CONSUMER):
        """Create Queue."""
        self.socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        self.socket.connect(('127.0.0.1', 5000))
        self.topic = topic
        self.type = _type

    def deparse(self, data):
        pass

    def parse(self, data):
        pass

    def construct(self, method, topic=None, message=None):
        pass

    def push(self, value):
        """Sends data to broker."""
        message = self.deparse(self.construct("PUB", self.topic, value))
        self.socket.send(len(message).to_bytes(2, 'big') + message)

    def pull(self) -> (str, Any):
        """Receives (topic, data) from broker.

        Should BLOCK the consumer!"""
        size = int.from_bytes(self.socket.recv(2), "big")
        data = self.socket.recv(size)
        if data:
            data = self.parse(data)
            return data["topic"], data["message"]

    def list_topics(self, callback: Callable):
        message = self.deparse(self.construct("TOPS"))
        self.socket.send(len(message).to_bytes(2, "big") + message)

    def cancel(self):
        """Cancel subscription."""
        message = self.deparse(self.construct("CANC", str(self.topic)))
        self.socket.send(len(message).to_bytes(2, "big") + message)


class JSONQueue(Queue):
    """Queue implementation with JSON based serialization."""

    def __init__(self, topic, _type=MiddlewareType.CONSUMER):
        super().__init__(topic, _type)
        message = '{"method": "PRES", "serialization": "json"}'
        self.socket.send(len(message).to_bytes(
            2, "big") + bytes(message, "utf-8"))
        if self.type == MiddlewareType.CONSUMER:
            message = self.deparse(self.construct("SUB", str(self.topic)))
            self.socket.send(len(message).to_bytes(2, 'big') + message)

    def deparse(self, data):
        return (json.dumps(data)).encode("utf-8")

    def parse(self, data):
        return json.loads(data.decode("utf-8"))

    def construct(self, method, topic=None, message=None):
        # Enough for Topic listing
        rep = {"method": method}
        if method != "TOPS":                                            # Enough for Cancellation
            rep["topic"] = topic
            if method != "SUB":                                         # Enough for Publish and Reply
                rep["message"] = message
        return rep


class XMLQueue(Queue):
    """Queue implementation with XML based serialization."""

    def __init__(self, topic, _type=MiddlewareType.CONSUMER):
        super().__init__(topic, _type)
        message = '{"method": "PRES", "serialization": "xml"}'
        self.socket.send(len(message).to_bytes(
            2, "big") + bytes(message, "utf-8"))
        if self.type == MiddlewareType.CONSUMER:
            message = self.deparse(self.construct("SUB", str(self.topic)))
            self.socket.send(len(message).to_bytes(2, 'big') + message)

    def deparse(self, data):
        return data.encode("utf-8")

    def parse(self, data):
        tree = ET.ElementTree(ET.fromstring(data.decode("utf-8")))
        res = {}
        for elem in tree.iter():
            res[elem.tag] = el.text
        return res

    def construct(self, method, topic=None, message=None):
        # Enough for Topic listing
        rep = f"<method>{str(method)}</method>"
        if method != "TOPS":                                            # Enough for Cancellation
            rep = f"{rep}<topic>{str(topic)}</topic>"
            if method != "SUB":                                         # Enough for Publish and Reply
                rep = f"{rep}<message>{str(message)}</message>"
        return f"<data>{rep}</data>"


class PickleQueue(Queue):
    """Queue implementation with Pickle based serialization."""

    def __init__(self, topic, _type=MiddlewareType.CONSUMER):
        super().__init__(topic, _type)
        message = '{"method": "PRES", "serialization": "pickle"}'
        self.socket.send(len(message).to_bytes(
            2, "big") + bytes(message, "utf-8"))
        if self.type == MiddlewareType.CONSUMER:
            message = self.deparse(self.construct("SUB", str(self.topic)))
            self.socket.send(len(message).to_bytes(2, 'big') + message)

    def deparse(self, data):
        return pickle.dumps(data)

    def parse(self, data):
        return pickle.loads(data)

    def construct(self, method, topic=None, message=None):
        # Enough for Topic listing
        rep = {"method": method}
        if method != "TOPS":                                            # Enough for Cancellation
            rep["topic"] = topic
            if method != "SUB":                                         # Enough for Publish and Reply
                rep["message"] = message
        return rep
