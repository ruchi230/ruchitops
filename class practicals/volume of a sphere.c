// Write a C program that calculates the volume of a sphere.
//Input the radius of the sphere : 2.56

#include<stdio.h>

int main()
{
	float r=2.56;  //radius of the sphere
	float pi=3.14;  
	float v;   //volume of a sphere
	
	v=(4*pi*r*r*r)/3;
	printf("the volume of a sphere= %f",v);
	return 0;
}
