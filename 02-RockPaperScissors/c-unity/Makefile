CC=gcc.exe

.PHONY: test unity clean

rockpaperscissors: main.o rockpaperscissors.o test
	$(CC) main.o rockpaperscissors.o -o $@

test: unity
	$(MAKE) CC=$(CC) -C test

unity:
	$(MAKE) CC=$(CC) -C unity

clean:
	$(MAKE) CC=$(CC) -C unity clean
	$(MAKE) CC=$(CC) -C test clean
	rm -f *.o
	rm -f *.a
	rm -f *.exe
