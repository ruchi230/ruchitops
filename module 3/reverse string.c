//WAP to find reverse of string using recursion
#include<stdio.h>
#include<string.h>
void reverse();

int main()
{		
	reverse();
	return 0;
}

void reverse()
{
	char str[20];
	int i,l;
	
	printf("enter the string :  ");
	scanf("%s",&str);
	
	l=strlen(str);
	printf("reverse string   :  ");
	for(i=l-1;i>=0;i--)
	{
		printf("%c",str[i]);
	}
}
