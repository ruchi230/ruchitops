//Looping programs:
//2. WAP to take 10 no. Input from user and find out …How many Even numbers are there
#include<stdio.h>

int main()
{
	int i,num,sum=0; 
	printf("enter 10 integer : ");
	for(i=1;i<=10;i++)
	{
		scanf("%d",&num);
		if(num%2==0)
		{
			sum++;
		}
	}
	printf("even numbers are = %d",sum);
	return 0;
}
