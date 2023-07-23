//WAP Find out length of string without using inbuilt function
#include<stdio.h>

int main()
{
	char a[50];
	int i,length=0;
	
	printf("enter the string :  ");
	scanf("%s",a);
	
	for(i=0;a[i]!=0;i++)
	{
		length++;
	}
	printf("length of string = %d",length);
	return 0;
}
