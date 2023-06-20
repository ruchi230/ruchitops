//Write a C program to check whether a given number is positive or negative.

#include<stdio.h>

int main()
{
	int num;
	printf("enter the number :  ");
	scanf("%d",&num);
	
	if(num>0)
	{
		printf("number is positive");
	}
	else if (num<0)
	{
		printf("number is negative");
	}
	else
	{
		printf("number is zero");
	}
	return 0;
}
