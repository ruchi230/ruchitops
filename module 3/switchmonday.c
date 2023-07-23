//WAP to show  Monday to Sunday using switch case
#include<stdio.h>

int main()
{
	int i;
	printf("enter the value of i : ");
	scanf("%d",&i);
	
	switch(i)
	{
		case 1:
			printf("monday");
			break;
		case 2:
			printf("tuesday");
			break;
		case 3:
			printf("wednesday");
			break;
		case 4:
			printf("thursday");
			break;
		case 5:
			printf("friday");
			break;
		case 6:
			printf("saturday");
			break;
		case 7:
			printf("sunday");
			break;
		default:
			printf("please enter the number between 1 to 7");
	}
	return 0;
	
}

