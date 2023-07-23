//Looping programs:
//Sum of odd numbers 
#include<stdio.h>

int main()
{
	int i,num,sum=0;
	printf("enter 10 integer :  "); 
	
	for(i=1;i<=10;i++)
	{
		scanf("%d",&num);
		if(num%2!=0)
		{
			sum=sum+num;
		}
	}
	printf("Sum of odd numbers = %d",sum);
	return 0;
}

