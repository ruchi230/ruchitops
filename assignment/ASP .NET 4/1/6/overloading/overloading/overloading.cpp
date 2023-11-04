// overloading.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;

class demo
{
public:

	void a1(int a, int b)
	{
		cout << "addition of a and b : " << a + b << endl;
	}
	void a1(double a, double b)
	{
		cout << "subtraction of a and b : " << a - b << endl;
	}
	void a1(int a, double b)
	{
		cout << "multiplication of a and b : " << a * b << endl;
	}
	void a1(double b, int a)
	{
		cout << "division of a and b : " << b / a << endl;
	}
};

int main()
{
	demo obj;
	obj.a1(100, 20);
	obj.a1(200.5, 10.5);
	obj.a1(10,10.5);
	obj.a1(200.0,5);
	return 0;
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
