"""CD Chat client program"""
import logging
import sys
import os
import socket
import selectors
import fcntl
from time import sleep

from .protocol import CDProto

logging.basicConfig(filename=f"{sys.argv[0]}.log", level=logging.DEBUG)


class Client:
    """Chat Client process."""

    def __init__(self, name: str = "Foo"):
        """Initializes chat client."""
        self.sel = selectors.DefaultSelector()
        self.name = name
        self.sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        
        orig_fl = fcntl.fcntl(sys.stdin, fcntl.F_GETFL)
        fcntl.fcntl(sys.stdin, fcntl.F_SETFL, orig_fl | os.O_NONBLOCK)
        self.sel.register(sys.stdin, selectors.EVENT_READ, self.keyboardRead)
        
    def connect(self):
        """Connect to chat server and setup stdin flags."""
        while True:
            try:
                self.sock.connect(("localhost", 5080))
                CDProto.send_msg(self.sock, CDProto.register(self.name))
                break
            except:
                print("Waiting for server")
                sleep(1)
                
        self.sel.register(self.sock, selectors.EVENT_READ, self.messageDisplay)

    def keyboardRead(self, stdin):
        msg = stdin.read()[:-1]
        if '/join' in msg:
            channel = msg[msg.rfind('#'):]
            CDProto.send_msg(self.sock, CDProto.join(channel=channel))
        elif 'exit' == msg:
            self.sel.unregister(self.sock)
            self.sock.close()
            exit(0)
        else:
            CDProto.send_msg(self.sock, CDProto.message(message=msg))

    def messageDisplay(self, conn):
        print(CDProto.recv_msg(conn).message)

    def loop(self):
        """Loop indefinetely."""
        while True:
            events = self.sel.select()
            for key, mask in events:
                callback = key.data
                callback(key.fileobj)
