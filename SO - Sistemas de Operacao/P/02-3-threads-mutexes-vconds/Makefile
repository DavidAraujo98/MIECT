CXXFLAGS = -Wall -ggdb -pthread

LDFLAGS = -pthread -lm

TARGETS = bounded_buffer_unsafe bounded_buffer_safe client-server

all:	$(TARGETS)

client-server:	fifo_safe.o client-server.o delays.o thread.o utils.o
		g++ -o $@ $^ $(LDFLAGS)
		rm -f *.o *~

bounded_buffer_unsafe:	fifo_unsafe.o bounded_buffer.o delays.o thread.o utils.o
		g++ -o $@ $^ $(LDFLAGS)
		rm -f *.o *~

bounded_buffer_safe:	fifo_safe.o bounded_buffer.o delays.o thread.o utils.o
		g++ -o $@ $^ $(LDFLAGS)
		rm -f *.o *~

fifo_unsafe.o fifo_safe.o:	%.o:	%.cpp fifo.h delays.h

delays.o:	%.o:	%.h

thread.o utils.o:	%.o:	%.h dbc.h

clean:
		rm -f *.o *~

cleanall:	clean
		rm -f $(TARGETS)
