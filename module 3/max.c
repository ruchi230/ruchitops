//Write a program to find out the max from given number
#include<stdio.h>

int main()
{
	int a,b,c,d;
	printf("enter the value of a,b,c and d :  ");
	scanf("%d %d %d %d",&a,&b,&c,&d);
	
	if (a>b)
	{
		if(a>c)
		{
			if(a>d)
			{
				printf("a is maximum");
			}
			else
			{
				printf("d is maximum");
			}
		}
		else if(c>d)
    	{
	    	printf("c is maximum");
	    }
	    else
	    {
		    printf("d is maximum");
	    }
			
	}
	
    else if(b>c)
	{
		if(b>d)
		{
			printf("b is maximum");
		}
		else
		{
			printf("d is maximum");
		}
	}
	else if(c>d)
    	{
	    	printf("c is maximum");
	    }
	    else
	    {
		    printf("d is maximum");
	    }
	
	
	return 0;
}
