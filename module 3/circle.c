//Write a program to find area of circle.

#include<stdio.h>

int main()
{
	float r;   //r=radius of circle
	float pi=3.14;
	float area;
	printf("enter the value of r :  ");
	scanf("%f",&r);
	
	area=pi*r*r;
	printf("area of circle = %f",area);
	return 0;
}
