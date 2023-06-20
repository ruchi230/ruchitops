#include<stdio.h>

int main()
{
	int marks;
	printf("enter the marks :   ");
	scanf("%d",&marks);
	
	if(marks>=70)
	{
		printf("grade = A++");
	}
	else  if (marks>=60)
	{
		printf(" grade = A");
	}
	else if(marks>=35)
	{
		printf("student will be pass");
	}
	else
	{
		printf("student will be fail");
	}
	return 0;
}
