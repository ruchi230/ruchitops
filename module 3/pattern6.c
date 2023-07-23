//pattern 6
#include<stdio.h>

int main()
{
	int i,n,k;
	
	printf("enter the number :  ");
	scanf("%d",&n);
	
	for(i=1;i<=n;i++)
	{
		for(k=1;k<=i;k++)
		{
			printf("*");
		}
			printf("\n");
	}
	for(i=n+1;i>=1;i--)
	{
		for(k=1;k<=i;k++)
		{
			printf("*");
		}
		printf("\n");
	}
	return 0;
}
