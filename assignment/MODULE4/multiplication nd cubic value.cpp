//Write a program to find the multiplication values and the cubic values using inline function
#include<iostream>
using namespace std;

inline void mul()
{
	int a,b;
	cout<<"enter the value of A : ";
	cin>>a;
	cout<<"enter the value of B : ";
	cin>>b;
	cout<<"multiplication value : "<<a*b<<endl;
}
inline void cube()
{
	int a,b;
	cout<<endl<<"enter the value of A : ";
	cin>>a;
	cout<<"cubic value : "<<a*a*a<<endl;
}
int main()
{
	mul();
	cube();
	return 0;
}

