//WAP to print number in reverse order e.g.: number = 64728 ---> reverse =82746
#include<stdio.h>

int main()
{
	int revnum=0,reminder,num;
	
	printf("enter the number :  ");
	scanf("%d",&num);
	
	while(num!=0)
	{
		reminder=num%10;
		revnum=revnum*10+reminder;
		num=num/10;
	}
	printf("reverse number   :  %d",revnum);
	return 0;	
}
