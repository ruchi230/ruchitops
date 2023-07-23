//pattern 5
#include<stdio.h>

int main()
{
	int i,j,k,n,m;
	
	printf("enter the number :  ");
	scanf("%d",&n);
	
	for(i=1;i<=n;i++)
	{
		for(k=i;k<=n-1;k++)
		{
			printf(" ");	
		}
		for(j=1;j>=1-i+1;j--)
		{
		      printf("*");	
		}
		for(j=1;j>=1-i+2;j--)
		{
		      printf("*");	
		}
		for(k=5;k>=i+3;k--)
		{
			printf(" ");	
		}
		printf("\n");
	}
	return 0;
}
