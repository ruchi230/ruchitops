//Write a program in C that takes minutes as input, and display the total number of hours and minutes.
//Input minutes: 546

#include<stdio.h>

int main()
{
	int a=546;  //minutes
	int b;     //hours
	int c;    //minutes
	
	b=a/60;   //for hours
	c=a%60;    //for minutes
	printf("the total number of hours and minutes= %d hours %d minutes",b,c);
	return 0;
}
