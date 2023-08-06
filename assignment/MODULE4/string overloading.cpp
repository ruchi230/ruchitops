//Write a program to concatenate the two strings using Operator Overloading
#include<iostream>
using namespace std;

class add
{
	string x,y;
	public:
	void setdata(string a,string b)
	{
		x=a;
		y=b;
	}
	void getdata();	
	void operator +();
	void getdata1();
};
void add :: getdata()
{
	cout<<" "<<x<<" "<<y<<endl;
}
void add :: operator +()
{
	x+y;
}
void add :: getdata1()
{
	cout<<" "<<x+y<<endl;
}

int main()
{
	add a1;
	a1.setdata("ruchi","patel");
	a1.getdata();
	+a1;
	a1.getdata1();
	return 0;
}
