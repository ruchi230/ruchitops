//WAP to print Fibonacci series up to given numbers

#include<stdio.h>

int main()
{
	int n1=0,n2=1,n3,num,i;
	printf("enter the number :  ");
	scanf("%d",&num);
	printf("%d\t",n1);
	printf("%d\t",n2);
	for(i=2;i<=num;i++)
	{
		n3=n1+n2;
	    printf("%d\t",n3);
	    n1=n2;
	    n2=n3;
	}
	return 0;
}
