//Write a program to find area of triangle.

#include<stdio.h>

int main()
{
	float b;  //base of triangle
	float h;  //height of triangle
	float area;
	printf("enter the value of b and h :  ");
	scanf("%f %f",&b,&h);
	
	area=(b*h)/2;
	printf("area of triangle =%f",area);
	return 0;
}
