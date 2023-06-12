from src.client import Client
from time import sleep

if __name__ == "__main__":
    c = Client("Bar")
    c.connect()
    c.loop()