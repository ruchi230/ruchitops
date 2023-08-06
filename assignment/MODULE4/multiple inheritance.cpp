/*Create a class person having members name and age. Derive a class student having member percentage. 
Derive another class teacher having member salary. 
Write necessary member function to initialize, read and write data.
 Write also Main function (Multiple Inheritance)*/
#include<iostream>
using namespace std;

class person
{
	public:
	int age;
	string name;
	void setdata()
	{
		cout<<"enter the name : ";
		cin>>name;
		cout<<"enter the age : ";
		cin>>age;
	}	
};
class student
{
	public:
	int percentage;
	void setdata1()
	{
		cout<<"enter the percentage : ";
		cin>>percentage;
	}	
};
class teacher : public person, public student
{
	public:
	int salary;	
	void setdata2()
	{
		cout<<"enter the salary of teacher : ";
		cin>>salary;
	}
	void getdata()
	{
		cout<<"\nname of student       : "<<name<<endl;
		cout<<"age of student        : "<<age<<endl;
		cout<<"percentage of student : "<<percentage<<endl;
		cout<<"salary of teacher     : "<<salary<<endl;
	}
};

int main()
{
	teacher t1;
	t1.setdata();
	t1.setdata1();
	t1.setdata2();
	t1.getdata();
	return 0;
}

