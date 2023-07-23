//WAP to make simple calculator (operation include Addition, Subtraction,Multiplication, Division, modulo)
#include<stdio.h>
void add();
void sub();
void mul();
void div();
void mod();

int main()
{
	add();
	sub();
	mul();
	div();
	mod();
	return 0;
}
void add()
{
	int a,b,c;
	printf("enter the value of a and b :  ");
	scanf("%d %d",&a,&b);
	c=a+b;
	printf("addition = %d\n",c);
}
void sub()
{
	int a,b,c;
	printf("enter the value of a and b :  ");
	scanf("%d %d",&a,&b);
	c=a-b;
	printf("subtraction = %d\n",c);
}
void mul()
{
	int a,b,c;
	printf("enter the value of a and b :  ");
	scanf("%d %d",&a,&b);
	c=a*b;
	printf("multiplication = %d\n",c);
}
void div()
{
	float a,b,c;
	printf("enter the value of a and b :  ");
	scanf("%f %f",&a,&b);
	c=a/b;
	printf("division = %f\n",c);
}
void mod()
{
	int a,b,c;
	printf("enter the value of a and b :  ");
	scanf("%d %d",&a,&b);
	c=a%b;
	printf("modulo = %d",c);
}

