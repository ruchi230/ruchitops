/*Assume a class cricketer is declared. Declare a derived class batsman from cricketer.
Data member of batsman. Total runs, Average runs and best performance.
Member functions input data, calculate average runs, Display data. (Single Inheritance)*/
#include<iostream>
using namespace std;

class cricketer
{
	public:	
};
class batsman: public cricketer
{
	public :
	int total_run,innings,not_out;
	string best_performance;
	
	void setdata()
	{
		cout<<"enter the total runs : ";
		cin>>total_run;
		cout<<"enter the number of innings : ";
		cin>>innings;
		cout<<"enter the number of times the player remained not out : ";
		cin>>not_out;
		cout<<"enter the best performance : ";
		cin>>best_performance;		
	}	
	void getdata()
	{
		cout<<"\ntotal runs       : "<<total_run<<endl;
		cout<<"average runs     : "<<total_run/(innings-not_out)<<endl;
		cout<<"best performance : "<<best_performance<<endl;		
	}	
};
int main()
{
	batsman b1;
	b1.setdata();
	b1.getdata();
	return 0;
}

