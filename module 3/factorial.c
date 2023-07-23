//WAP to print factorial of given number
#include<stdio.h>

int main()
{
	int i,num,factorial;
	printf("enter the number :  ");
	scanf("%d",&num);
	for(i=num;i>=1;i--)
	{
		printf("%d*",i);
		factorial=factorial*i;
	}
	printf("\nfactorial=%d",factorial);
	
	return 0;
}
