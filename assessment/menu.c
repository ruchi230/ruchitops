#include<stdio.h>
int main()
{
	int i,amount,rate,q,ch;
	
	s:
	printf("\n------manu------\n");
	printf("1. Pizza       price  = 180rs/pcs\n");
	printf("2. Burger      price  = 100rs/pcs\n");
	printf("3. Dosa        price  = 120rs/pcs\n");
	printf("4. Idli        price  = 50rs/pcs\n");
	
	printf("please enter your choose...:  ");
	scanf("%d",&i);
	
	switch(i)
	{
		case 1:
			printf("\nYou have selected Pizza.");
			printf("\nenter the quantity :  ");
	 		scanf("%d",&q);
	 		rate=180;
	 		amount=q*rate;
	 		printf("amount : %d",amount);
	 		printf("\nTotal amount is :  %d",amount);
			break;
		case 2:
			printf("\nYou have selected Burger.");
			printf("\nenter the quantity :  ");
	 		scanf("%d",&q);
	 		rate=100;
	 		amount=q*rate;
	 		printf("amount : %d",amount);
	 		printf("\nTotal amount is :  %d",amount);
			break;
		case 3:
			printf("\nYou have selected Dosa.");
			printf("\nenter the quantity :  ");
	 		scanf("%d",&q);
	 		rate=120;
	 		amount=q*rate;
	 		printf("amount : %d",amount);
	 		printf("\nTotal amount is :  %d",amount);
			break;
		case 4:
			printf("\nYou have selected Idli.");
			printf("\nenter the quantity :  ");
	 		scanf("%d",&q);
	 		rate=50;
	 		amount=q*rate;
	 		printf("amount : %d",amount);
	 		printf("\nTotal amount is :  %d",amount);
			break;
		default:
			printf("please enter the number between 1 to 4");
	}
	
	
	printf("\nDo you want place more orders? 1=yes or 2=no :  ");
	scanf("%d",&ch);
	
	if(ch==1)
	{
		goto s;
	}
	else
	{
		printf("thank you"); 
	}
	return 0;
}
