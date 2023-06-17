//Write a program that converts Centigrade to Fahrenheit.
//Input a temperature (in Centigrade): 45

#include<stdio.h>

int main()
{
	int a=45;  //temperature in Centigrade
	float c;   //temperature in Fahrenheit
	
	c=(a * 9/5) + 32;
	printf("temperature in Fahrenheit = %f",c) ;
	return 0;
}
