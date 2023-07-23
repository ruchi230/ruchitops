//WAP to check if the given year is a leap year or not.
#include<stdio.h>
int main()
{
	int year;
	l:
		{
			printf("given year is a leap year\n");
		}
	n:
		{
			printf("given year is not a leap year\n");
		}
	printf("enter the year :  ");
	scanf("%d",&year);	
	
	if(year%4==0)
	{
		goto l;
	}
	else
	{
		goto n;
	}
	
	return 0;
}
