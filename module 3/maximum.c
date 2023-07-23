//Write a program to find out the max number from given array using function
#include<stdio.h>
int max(int size);

int main()
{
	int size;
	max(size);
	return 0;
}

int max(int size)
{
	int a[20],maximum,i;
	printf("enter the size of array :  ");
	scanf("%d",&size);
	
	printf("\nenter the element of array :  ");
	for(i=0;i<size;i++)
	{
		scanf("%d",&a[i]);
	}
	printf("\narray :  ");
	for(i=0;i<size;i++)
	{
		printf("%d  ",a[i]);
	}
	maximum=a[0];
	for(i=1;i<=size;i++)
	{
		if(maximum<a[i])
		{
		maximum=a[i];
		}
	}
	printf("\n\nmaximum number from given array = %d",maximum);
}
