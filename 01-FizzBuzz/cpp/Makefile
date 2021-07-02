APPLICATION=fizzbuzz
TESTAPP=$(APPLICATION)-test

.PHONY: clean test

$(APPLICATION): fizzbuzz.o main.o test
	$(CXX) $^ -o $@

$(TESTAPP): test-fizzbuzz.o fizzbuzz.o
	$(CXX) $^ -o $@

test: $(TESTAPP)
	$(TESTAPP)

clean:
	rm -f *.o *~ *.exe $(APPLICATION) $(TESTAPP)
