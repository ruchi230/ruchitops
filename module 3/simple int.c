//Write a program to find simple interest.

#include<stdio.h>

int main()
{
	float p;
	float r;
	float n;
	float i;
	printf("enter the value of p , r and n :   ");
	scanf("%f %f %f",&p,&r,&n);
	
	i=(p*r*n)/100;
	printf("simple intrest i= %f",i);
	return 0;
}
