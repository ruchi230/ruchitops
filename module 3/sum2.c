//Write a program you have to make a summation of first and last Digit.
#include<stdio.h>

int main()
{
	int first,last,sum,num;
	
	printf("enter the number :  ");
	scanf("%d",&num);
	
	first=num;
	last=num%10;
	
	while(num>=10)
	{
		num=num/10;
	}
	first=num;
	sum=first+last;
	printf("sum of first and last Digit = %d",sum);
	
	return 0;
}
