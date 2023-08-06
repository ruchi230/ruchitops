/*Write a program to calculate the area of circle, rectangle and triangle
usingFunction Overloading
 Rectangle: Area * breadth
 Triangle: ½ *Area* breadth
 Circle: Pi * Area *Area*/
#include<iostream>
using namespace std;
 
class area
{
	public:
		
	void a(int a, int b)
	{
		cout<<"area of rectangle : "<<a*b<<endl;
	}
		
	void a(int a,double b)
	{
		cout<<"area of triangle  : "<<(a*b)/2<<endl;
	}
		
	void a(double pi,int a)
	{
		cout<<"area of circle    : "<<pi*a*a<<endl;
	}	
}; 
 
int main()
{
	area a1;
	a1.a(10,20);
	a1.a(10,20.5);
	a1.a(3.14,10);
	return 0;
}
