/*Write a program to Mathematic operation like Addition, Subtraction,
Multiplication, Division Of two number using different parameters and
Function Overloading*/
#include<iostream>
using namespace std;

class math
{
	public:
	
	void m(int a,int b)
	{
		cout<<"addition       : "<<a+b<<endl;	
	}	
	
	void m(double a,double b)
	{
		cout<<"subtraction    : "<<a-b<<endl;	
	}
			
	void m(int a,double b)
	{
		cout<<"multiplication : "<<a*b<<endl;
	}	
	
	void m(double b,int a)
	{
		cout<<"division       : "<<b/a<<endl;
	}		
};

int main()
{
	math m1;
	m1.m(20,30);
	m1.m(50.5,20.5);
	m1.m(20,3.5);
	m1.m(100.5,20);
	return 0;
}
