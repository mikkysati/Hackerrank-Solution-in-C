#include<stdio.h>

/*int string_to_int(char str[]){
    int i,num=0;
    for(i=0;str[i]!='\0';i++) {
        if(str[i]>=48 && str[i]<=57) 
           num=num*10+(str[i]-48);
    }
    return num;
}*/

main() 
{
    int n,i,sum=0;
    scanf("%d",&n);
    int ar[n];
    char s[100];
    int count[100] = {0}; 
    for(i=0;i<n;i++)
    {
        //fgets (s, 100, stdin);
        //ar[i]= string_to_int(s);
        scanf("%d %s",&ar[i],s); //can be always done using this as i/p is always in this format
        count[ar[i]]++;
    }
    for(i=0;i<100;i++)
    {
        sum+= count[i];
        printf("%d ",sum);
    }
    
}

