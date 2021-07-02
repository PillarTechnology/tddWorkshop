#include "fizzbuzz.h"
#include <cstdlib>
#include <iostream>

using namespace std;

int main(int argc, char** argv) {

	for(int i=1; i < argc; ++i) {
		auto num = strtol(argv[i], nullptr, 10);
		cout << fizzbuzz(num) << endl;
	}

	return 0;
}
