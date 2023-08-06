//WAP to create simple calculator using class
#include<iostream>
using namespace std;

class calculator
{
	public:
	int a,b;
	void setdata()
	{
		cout<<"enter the value of a : ";
		cin>>a;
		cout<<"enter the value of b : ";
		cin>>b;
	}
	void getdata()
	{
		cout<<"\naddition       : "<<a+b<<endl;
		cout<<"subtraction    : "<<a-b<<endl;
		cout<<"multiplication : "<<a*b<<endl;
		cout<<"division       : "<<a/b<<endl;
		cout<<"modulo         : "<<a%b<<endl;
		}	
};

int main()
{
	calculator c1;
	c1.setdata();
	c1.getdata();
	return 0;
}
