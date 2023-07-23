//Write a program to convert years into days and days into years.
#include<stdio.h>
void year();
void day();

int main()
{
	year();
	day();
	return 0;
}
void year()
{
	int year,day;
	printf("enter the value of days :  ");
	scanf("%d",&day);
	year=day/365;
	printf(" year = %d\n",year);
}
void day()
{
	int year,day;
	printf("enter the value of year :  ");
	scanf("%d",&year);
	day=year*365;
	printf(" days = %d",day);
}
