//WAP to find number is even or odd using ternary operator
#include<stdio.h>

int main()
{
	int num;
	
	printf("enter the number :  ");
	scanf("%d",&num);
	
	if(num%2==0)
	{
		printf("%d is even\n",num);
	}
	else
	{
		printf("%d is odd",num);
	}
}
