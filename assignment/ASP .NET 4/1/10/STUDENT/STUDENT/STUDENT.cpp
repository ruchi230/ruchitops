// STUDENT.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;

class student
{
    public:
        string name;
        int rollno;

        void  getdata();
        void setdata();   
};
void student::getdata()
{
    cout << "Enter roll number : ";
    cin >> rollno;
    cout << "Enter name : ";
    cin >> name;    
}
void student::setdata()
{
    cout << "student details : \n";
    cout << "Roll Number : " << rollno << endl << "Name : " << name << endl;
}

int main()
{
    student s[100];
    int n;

    cout << "Enter total number of students : ";
    cin >> n;

    for (int i = 0;i < n;i++)
    {
        cout << "Enter details of student " << (i + 1) << endl;
        s[i].getdata();
    }
    cout << endl;
    for (int i = 0;i < n;i++)
    {
        cout << "Details of student " << (i + 1) << endl;
        s[i].setdata();
    }
   
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
