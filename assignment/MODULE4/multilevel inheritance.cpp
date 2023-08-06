/*Assume that the test results of a batch of students are stored in three different classes. 
Class Students are storing the roll number. Class Test stores the marks obtained in two subjects and class 
result contains the total marks obtained in the test. The class result can inherit the details of the marks
obtained in the test and roll number of students. (Multilevel Inheritance)*/
#include<iostream>
using namespace std;

class student
{
	public:
	int roll_num;
	void setdata()
	{
		cout<<"enter the roll number of student : ";
		cin>>roll_num;
	}
};
class test : public student
{
	public:
	int marks1,marks2;
	void setdata1()
	{
		cout<<"enter the marks in first subject : ";
		cin>>marks1;
		cout<<"enter the marks in second subject : ";
		cin>>marks2;
	}	
};
class result : public test
{
	public:
	int total_marks;
	void getdata()
	{
		cout<<"\nroll number of student  : "<<roll_num<<endl;
		cout<<"marks in first subject  : "<<marks1<<endl;
		cout<<"marks in second subject : "<<marks2<<endl;
		cout<<"total marks             : "<<marks1+marks2<<endl;
	}	
};

int main()
{
	result r1;
	r1.setdata();
	r1.setdata1();
	r1.getdata();
	return 0;
}
