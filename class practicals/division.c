//variable type
//Write a C program to calculate the integral quotient and remainder of a division.
//Input numerator : 2500                                                 
//Input denominator : 235 

#include<stdio.h>

int main()
{
	int a=2500;   //numerator
	int b=235;    //denominator
	int c;
	
	c=a/b;
	printf("quotient=%d\n",c);
	
	c=a%b;
	printf("remainder= %d",c);
	
	return 0;
}  

