//Write a Program of Two 1D Matrix Addition using Operator Overloading
#include<iostream>
using namespace std;

class matrix
{
	int a,b,c;
	public:
	void add(int x,int y,int z)
	{
		a=x;
		b=y;
		c=z;
	}	
	void display();
	int d,e,f;
	public:
	void add1(int p,int q,int r)
	{
		d=p;
		e=q;
		f=r;
	}	
	void display1();
	void operator +();
	void display2();
};
void matrix :: display()
{
	cout<<"1-D matrix :  "<<" "<<a<<" "<<b<<" "<<c<<endl;
}
void matrix :: display1()
{
	cout<<"1-D matrix :  "<<" "<<d<<" "<<e<<" "<<f<<endl;
}
void matrix :: operator +()
{
	a+d;
	b+e;
	c+f;
}
void matrix :: display2()
{
	cout<<"addition of two 1-D matrix : "<<" "<<a+d<<" "<<b+e<<" "<<c+f<<endl;
}

int main()
{
	matrix m1;
	m1.add(2,3,4);
	m1.display();
	m1.add1(5,6,7);
	m1.display1();
	+m1;
	m1.display2();
	return 0;
}
