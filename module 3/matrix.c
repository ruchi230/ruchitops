//WAP to make addition, Subtraction and multiplication of two matrix using 2-D Array
#include<stdio.h>

int main()
{
	int a[2][2],b[2][2],c[2][2],i,j,k;
	
	for(i=0;i<2;i++)
	{
		for(j=0;j<2;j++)
		{
			printf("enter the elements of A :  ");
			scanf("%d",&a[i][j]);
		}
	}
	for(i=0;i<2;i++)
	{
		for(j=0;j<2;j++)
		{
			printf("  %d  ",a[i][j]);
		}
		printf("\n");
	}
	
	for(i=0;i<2;i++)
	{
		for(j=0;j<2;j++)
		{
			printf("enter the elements of B :  ");
			scanf("%d",&b[i][j]);
		}
	}
	for(i=0;i<2;i++)
	{
		for(j=0;j<2;j++)
		{
			printf("  %d  ",b[i][j]);
		}
		printf("\n");
	}
	
	for(i=0;i<2;i++)
	{
		for(j=0;j<2;j++)
		{
			c[i][j]=a[i][j]+b[i][j];
		}
	}
	printf("\naddition  of two matrix : \n");
	for(i=0;i<2;i++)
	{
		for(j=0;j<2;j++)
		{
			printf("  %d  ",c[i][j]);
		}
		printf("\n");
	}
	
	for(i=0;i<2;i++)
	{
		for(j=0;j<2;j++)
		{
				c[i][j]=a[i][j]-b[i][j];
		}
	}
	printf("\nSubtraction  of two matrix : \n");
	for(i=0;i<2;i++)
	{
		for(j=0;j<2;j++)
		{
			printf("  %d  ",c[i][j]);
		}
		printf("\n");
	}
	
	for (i=0;i<2;i++) 
	{
        for (j=0;j<2;j++) 
		{
            c[i][j]=0;
            for (k=0;k<2;k++)
			{
                c[i][j] +=a[i][k]*b[k][j];
            }
        }
    }

    printf("\nmultiplication  of two matrix : \n");
    for (i=0;i<2;i++)
	 {
        for (j=0;j<2;j++)
		 {
            printf("   %d  ",c[i][j]);
        }
        printf("\n");
    }
	return 0;
}

