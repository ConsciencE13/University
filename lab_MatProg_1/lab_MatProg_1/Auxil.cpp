#include "Auxil.h"
#include <ctime>
namespace auxil
{
	// старт рандомайзера
	void start()
	{
		srand((unsigned)time(NULL));
	};

	// функция возвращает действительное(double) псевдослучайное число в диапазоне оn rmin до rmax
	double doubleget(double rmin, double rmax) 
	{
		return ((double)rand() / (double)RAND_MAX) * (rmax - rmin) + rmin;
	};

	// функция возвращает целое(integer) псевдослучайное число в диапазоне оn randmin до randmax
	int intget(int randmin, int randmax)
	{
		return (int)doubleget((double)randmin, (double)randmax);
	};
}