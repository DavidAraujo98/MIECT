#
#   Weather update server
#   Binds PUB socket to tcp://*:5556
#   Publishes random weather updates
#

import zmq
from random import randrange

context = zmq.Context()
socket = context.socket(zmq.PUB)
socket.bind("tcp://*:5556")

i1 = 10
while True:    
    zipglobal = randrange(1, 100000)
    
    print(zipglobal, i1)
    
    socket.send_string(f"{zipglobal} {i1}")
    
    i1 += 1