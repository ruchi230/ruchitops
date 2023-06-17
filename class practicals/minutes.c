//Write a C program that takes hours and minutes as input, and calculates the total number of minutes.
//Input hours: 5
//Input minutes: 37

#include<stdio.h>

int main()
{
	int a=5;  //hours
	int b=37;  //minutes
	int c;    //total number of minutes
	
	c=(a*60)+b;
	printf("the total number of minutes=%d",c);
	return 0;
}
