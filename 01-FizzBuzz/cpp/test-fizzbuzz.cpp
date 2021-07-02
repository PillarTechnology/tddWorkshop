#include "fizzbuzz.h"
#include "jazzassert.h"

int main(void) {

    describe("FizzBuzz", [] {
        it("should return Fizz for 3", [] {
            expect(fizzbuzz(3)).toBe("Fizz");
        });
    });

    testSummary();

    return failed;
}