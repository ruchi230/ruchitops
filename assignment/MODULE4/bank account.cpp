//Define a class to represent a bank account
#include<iostream>
using namespace std;

class bank_account
{
	public:
	int number,balance,d_amount,w_amount;
	string name,type;
	
	void setdata()
	{
		cout<<"--------enter details--------"<<endl;
		cout<<endl<<"enter the name of depositer : ";
		cin>>name;
		cout<<"enter the account number : ";
		cin>>number;
		cout<<"enter the type of account : ";
		cin>>type;
		cout<<"enter balance amount in account : ";
		cin>>balance;
		cout<<"enter deposit amount : ";
		cin>>d_amount;
		cout<<"enter withdraw : ";
		cin>>w_amount;	
	}	
	void getdata()
	{
		cout<<endl<<"----------------"<<endl;
		cout<<"Name of depositer         : "<<name<<endl;
		cout<<"Account number            : "<<number<<endl;
		cout<<"Type of account           : "<<type<<endl;
		cout<<"Balance amount in account : "<<balance+d_amount-w_amount<<endl;
	}
};

int main()
{
	bank_account b1;
	b1.setdata();
	b1.getdata();
	return 0;
}
