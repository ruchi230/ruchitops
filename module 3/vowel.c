//WAP to show Vowel or Consonant using switch case
#include<stdio.h>

int main()
{
	char ch;
	printf("enter the character :   ");
	scanf("%c",&ch);
	
	switch(ch)
	{
		case 'a':
			printf("given character is vowel");
			break;
		case 'e':
			printf("given character is vowel");
			break;
		case 'i':
			printf("given character is vowel");
			break;
		case 'o':
			printf("given character is vowel");
			break;
		case 'u':
			printf("given character is vowel");
			break;
		case 'A':
			printf("given character is vowel");
			break;
		case 'E':
			printf("given character is vowel");
			break;
		case 'I':
			printf("given character is vowel");
			break;
		case 'O':
			printf("given character is vowel");
			break;
		case 'U':
			printf("given character is vowel");
			break;	
		default:
			printf("given character is Consonant ");				
	}
	return 0;
}
