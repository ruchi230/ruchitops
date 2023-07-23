//How many odd numbers are there
#include<stdio.h>

int main()
{
	int i,num,sum=0; 
	printf("enter 10 integer : ");
	for(i=1;i<=10;i++)
	{
		scanf("%d",&num);
		if(num%2!=0)
		{
			sum++;
		}
	}
	printf("odd numbers are = %d",sum);
	return 0;
}
