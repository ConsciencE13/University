#include "Auxil.h"
#include <ctime>
namespace auxil
{
	// ����� ������������
	void start()
	{
		srand((unsigned)time(NULL));
	};

	// ������� ���������� ��������������(double) ��������������� ����� � ��������� �n rmin �� rmax
	double doubleget(double rmin, double rmax) 
	{
		return ((double)rand() / (double)RAND_MAX) * (rmax - rmin) + rmin;
	};

	// ������� ���������� �����(integer) ��������������� ����� � ��������� �n randmin �� randmax
	int intget(int randmin, int randmax)
	{
		return (int)doubleget((double)randmin, (double)randmax);
	};
}