//WAP to swap two numbers without using third variable
#include<stdio.h>
void num();

int main()
{
	num();
	return 0;
}
void num()
{
	int a,b;
	printf("enter the value of a and b :  ");
	scanf("%d %d",&a,&b);
	printf("before swapping\n");
	printf("the value of a = %d\n",a);
	printf("the value of b = %d\n",b);
	
	a=a+b;
	b=a-b;
	a=a-b;
	printf("after swapping\n");
	printf("the value of a = %d\n",a);
	printf("the value of b = %d",b);
}
