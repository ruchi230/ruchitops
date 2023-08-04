/*Create a Project to demonstrate an Event Organiser Project which will help to manage
the Events.*/
#include<iostream>
using namespace std;

void event()
{
	int num,n,num3,NumberOfServers;
	string event_name,first_name,last_name;
	
	cout<<"**********Event Management System**********"<<endl;
	cout<<endl<<"Enter the name of event : ";
	cin>>event_name;
	cout<<"Enter the customer's first and last name : ";
	cin>>first_name>>last_name;
	cout<<"Enter the number of guests : ";
	cin>>num;
	cout<<"Enter the number of minutes in the event : ";
	cin>>n;
	
	cout<<endl<<endl<<endl<<"===============Event estimate for :  "<<first_name;
	cout<<" "<<last_name;
	cout<<"==============="<<endl;
	
	NumberOfServers=num/20;
	cout<<"Number of server :  "<<NumberOfServers<<endl;
	
	
	const double costperhour=18.50;
	const double costperminute=0.40;
	const double costofdinner=20.70;
	int cost1,cost2,CostForOneServer,TotalFoodCost,TotalCost;
	
	cost1=(n/60)*costperhour;
	cost2=(n%60)*costperminute;
	CostForOneServer=cost1+cost2;
	cout<<"The cost for servers : "<<CostForOneServer<<endl;
	
	TotalFoodCost=num*costofdinner;
	cout<<"The cost for Food is : "<<TotalFoodCost<<endl;
	
	cout<<"Average cost per person : "<<TotalFoodCost/num<<endl;
	
	TotalCost=TotalFoodCost+(CostForOneServer*NumberOfServers);
	cout<<endl<<"Total Cost is : "<<TotalCost;
	
	cout<<endl<<"Please deposite a 25% deposit to reserve the event"<<endl;
	cout<<"The deposite needed is : "<<TotalCost*0.25;
}


int main()
{
	event();
	return 0;
}
