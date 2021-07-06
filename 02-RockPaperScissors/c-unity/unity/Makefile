LIBNAME=unity

SRC=$(wildcard *.c)
BASES=$(basename $(SRC))
OBJS=$(addsuffix .o, $(BASES))

.PHONY: clean purify

lib$(LIBNAME).a: $(OBJS) unity.h
	ar -rs $@ $^

clean:
	rm -f *.o
	rm -f *.a

purify: clean
	rm *.h
	rm *.c

unity.h: source-library.sh
	./source-library.sh
