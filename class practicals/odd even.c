//Write a C program to check whether a given number is even or odd.

#include<stdio.h>

int main()
{
	int num;
	printf ("enter the number :  ");
	scanf("%d",&num);
	
	if (num%2==0)
	{
		printf("number is even");
	}
	else
	{
		printf("number is odd");
	}
	return 0;
}
