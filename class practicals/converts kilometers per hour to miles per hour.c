// Write a C program that converts kilometers per hour to miles per hour.
//Input kilometers per hour: 15

#include<stdio.h>

int main()
{
	int a=15;  //kilometers per hour
	float b;   //miles per hour
	
	b=a/1.609344;
	printf("miles per hour= %f",b);
	return 0;
}
