//Write a program make a summation of given number (E.g., 1523 Ans: 11)

#include<stdio.h>
int main()
{
	int i,num,sum=0; 
	
	printf("enter the 4 number :  ");
	for(i=1;i<=4;i++)
	{
		scanf("%d",&num);
		sum=sum+num;
	}
	printf("sum of given number = %d",sum);	
	return 0;
}

