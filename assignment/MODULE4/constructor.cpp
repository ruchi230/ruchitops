//Write a program of Addition, Subtraction, Division, Multiplication using constructor.
#include<iostream>
using namespace std;

class calculator
{
	private:
	int a,b;
	public:
	calculator(int x,int y)
	{
		a=x;
		b=y;
	}
	
	void getdata()
	{
		cout<<"\naddition       : "<<a+b<<endl;
		cout<<"subtraction    : "<<a-b<<endl;
		cout<<"multiplication : "<<a*b<<endl;
		cout<<"division       : "<<a/b<<endl;
	}	
};
int main()
{
	calculator c1(50,10);
	c1.getdata();
	return 0;
}

