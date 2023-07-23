//Write a program to find area of rectangle.

#include<stdio.h>

int main()
{
	float l;  //lenght
	float w;  //width
	float area;
	printf("enter the value of l and w:  ");
	scanf("%f %f",&l,&w);
	
	area= l*w; 
	printf("area of rectangle =%f",area);
	return 0;
}
