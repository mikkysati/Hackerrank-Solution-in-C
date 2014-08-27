#include<stdio.h>

main() 
{
    int n,i,j;
    scanf("%d",&n);
    int ar[n];
    int count[100] = {0}; //for 0 to 100
    for(i=0;i<n;i++)
    {
        scanf("%d",&ar[i]);
        count[ar[i]]++;
    }
    for(i=0;i<100;i++)
    {
        if(count[i]>0)
            {
            for(j=0;j<count[i];j++)
            {
            printf("%d ",i);    
            }
        }
    }
    
}
