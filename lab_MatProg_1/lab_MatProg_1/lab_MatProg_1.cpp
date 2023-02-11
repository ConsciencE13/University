#include <iostream>

using namespace std;

int Fib(int i)

{

	int value = 0;

	if (i < 1) return 0;

	if (i == 1) return 1;

	return Fib(i - 1) + Fib(i - 2);

}

int main()

{
	clock_t t1 = 0, t2 = 0;
	int i = 0;
	t1 = clock(); // фиксация времени
	while (i < 37)

	{

		cout << Fib(i) << endl;

		i++;

	}

	t2 = clock(); // фиксация времени
	std::cout << std::endl << "продолжительность (у.е): " << (t2 - t1);
	std::cout << std::endl << " (сек): " << ((double)(t2 - t1)) / ((double)CLOCKS_PER_SEC);

	return 0;

}
