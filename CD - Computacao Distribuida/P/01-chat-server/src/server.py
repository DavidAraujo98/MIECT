"""CD Chat server program."""
import logging
import socket
import selectors

from src.protocol import (
    CDProto,
    TextMessage,
    JoinMessage,
    RegisterMessage
)

logging.basicConfig(filename="server.log", level=logging.DEBUG)

class Server:
    """Chat Server process."""

    def __init__(self):
        self.HOST = 'localhost'
        self.PORT = 5080
        self.clients = []
        
        self.sel = selectors.DefaultSelector()
        sock = socket.socket()
        sock.bind((self.HOST, self.PORT))
        sock.listen(100)
        self.sel.register(sock, selectors.EVENT_READ, self.accept)

    def accept(self, sock):
        conn, addr = sock.accept()
        conn.setblocking(False)
        self.sel.register(conn, selectors.EVENT_READ, self.read)
        
    def read(self, conn):
        msg = CDProto.recv_msg(conn)
        print("Receiver: ", repr(msg))
        if msg:
            if isinstance(msg, RegisterMessage):
                self.clients.append((conn, msg.user, ['@']))
                CDProto.send_msg(conn, CDProto.message(message=f"Welcome {msg.user} !"))
            elif isinstance(msg, JoinMessage):
                for client in self.clients:
                    if client[0] == conn:
                        client[2].append(msg.channel)
                CDProto.send_msg(conn, CDProto.message(message=f"Now in {msg.channel}"))
            elif isinstance(msg, TextMessage):
                channel = ''
                for client in self.clients:
                    if client[0] == conn:
                        channel = client[2][-1]
                        break
                for client in self.clients:
                    if channel in client[2] and client[0] != conn:
                        CDProto.send_msg(client[0], msg)
        else:
            print('closing', conn)
            self.sel.unregister(conn)
            for c in self.clients:
                if c[0] == conn:
                    self.clients.remove(c)
            conn.close()

    def loop(self):
        """Loop indefinitely."""
        while True:
            events = self.sel.select()
            for key, _ in events:
                callback = key.data
                callback(key.fileobj)

    


    
