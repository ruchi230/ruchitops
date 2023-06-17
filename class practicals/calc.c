// Write a C program to perform addition, subtraction, multiplication and division of two numbers.
//Input any two numbers separated by comma : 10,5

#include<stdio.h>

int main()
{
	int a=10,b=5;
	int c;
	
	c=a+b;
	printf("The sum of the given numbers = %d\n",c);
	
	c=a-b;
	printf("The difference of the given numbers = %d\n",c);
	
	c=a*b;
	printf("The product of the given numbers = %d\n",c);
	
	c=a/b;
	printf("The division of the given numbers = %d ",c);
	
	return 0;
}
