CFLAGS=-I../unity -I..
LDFLAGS=-L../unity -lunity
VPATH=..

SRCS=$(wildcard *.c)
BASES=$(basename $(SRCS))
OBJS=$(addsuffix .o, $(BASES))

SUT=rockpaperscissors.o

all: test_suite
	./test_suite

test_suite: $(OBJS) $(SUT)
	$(CC) $^ -o $@ $(LDFLAGS)

clean:
	rm -f *.o
	rm -f *.exe
	rm -f test_suite
