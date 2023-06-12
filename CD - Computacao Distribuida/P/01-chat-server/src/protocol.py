"""Protocol for chat server - Computação Distribuida Assignment 1."""
import json
from socket import socket


class Message:
    """Message Type."""
    def __init__(self, command):
        self.command = command
        
    def __repr__(self):
        return self.__dict__
        
class JoinMessage(Message):
    """Message to join a chat channel."""
    def __init__(self, channel=None):
        super().__init__("join")
        self.channel = channel
    
    def __repr__(self):
        return json.dumps(super().__repr__())

class RegisterMessage(Message):
    """Message to register username in the server."""

    def __init__(self, user=None):
        super().__init__("register")
        self.user = user

    def __repr__(self):
        return json.dumps(super().__repr__())
    
class TextMessage(Message):
    """Message to chat with other clients."""

    def __init__(self, message=None):
        super().__init__("message")
        self.message = message
        self.ts = 1615852800

    def __repr__(self):
        return json.dumps(super().__repr__())

class CDProto:
    """Computação Distribuida Protocol."""

    @classmethod
    def register(cls, username: str) -> RegisterMessage:
        """Creates a RegisterMessage object."""
        return RegisterMessage(user=username)
        
    @classmethod
    def join(cls, channel: str) -> JoinMessage:
        """Creates a JoinMessage object."""
        return JoinMessage(channel=channel)

    @classmethod
    def message(cls, message: str, channel: str = None) -> TextMessage:
        """Creates a TextMessage object."""
        return TextMessage(message=message)

    @classmethod
    def send_msg(cls, connection: socket, msg: Message):
        """Sends through a connection a Message object."""
        print("Sender: ", len(repr(msg)).to_bytes(2, 'big'))
        connection.sendall(len(repr(msg)).to_bytes(2, 'big'))
        connection.sendall(repr(msg).encode("latin-1"))

    @classmethod
    def recv_msg(cls, connection: socket) -> Message:
        """Receives through a connection a Message object."""
        length = 2
        while length != 0:
            try:
                l_msg = connection.recv(2)
                length = int.from_bytes(l_msg, "big")
                
                msg = connection.recv(length)
                if length > len(msg):
                    msg = l_msg + msg
                
                if length != 0:
                    try:
                        msg = json.loads(msg.decode('latin-1'))
                        if msg["command"] == "register":
                            return RegisterMessage(user=msg["user"])
                        elif msg["command"] == "join":
                            return JoinMessage(channel=msg["channel"])
                        elif msg["command"] == "message":
                            return TextMessage(message=msg["message"])
                    except:
                        raise CDProtoBadFormat(msg)
            except BlockingIOError:
                # Retry the receive operation if there is no data available
                continue

class CDProtoBadFormat(Exception):
    """Exception when source message is not CDProto."""

    def __init__(self, original_msg: bytes=None) :
        """Store original message that triggered exception."""
        self._original = original_msg

    @property
    def original_msg(self) -> str:
        """Retrieve original message as a string."""
        return self._original.decode("utf-8")
