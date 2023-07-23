//pattern4

#include<stdio.h>

int main()
{
	char i,j,a;
	
	a='A';
	for(i='A';i<='E';i++)
	{
		for(j='A';j<=i;j++)
		{
			printf("%c",a);
			a=a+1;
		}
		printf("\n");
	}
	return 0;
}
