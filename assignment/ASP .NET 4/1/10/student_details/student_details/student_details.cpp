// student_details.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;

struct  student
{
    string fname,lname;
    int roll;
    float marks;
} s[10];

int main()
{
    
    cout << "--Enter information of 10 students--" << endl;
    for (int i = 0;i < 10;i++)
    {
        cout << "Enter roll number : ";
        cin >> s[i].roll;
        cout << "Enter first name : ";
        cin >> s[i].fname;
        cout << "Enter last name : ";
        cin >> s[i].lname;
        cout << "Enter marks : ";
        cin >> s[i].marks;
    }
    

    cout << "\n---Display information---" << endl;
    for (int i = 0;i < 10;i++)
    {
        cout << "\nroll number : " << s[i].roll << endl;
        cout << "first name : " << s[i].fname << endl;
        cout << "last name : " << s[i].lname << endl;
        cout << "marks : " << s[i].marks << endl;
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
