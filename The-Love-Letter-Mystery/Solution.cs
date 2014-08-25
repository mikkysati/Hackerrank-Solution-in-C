#include<stdio.h>
#include<math.h>
#include<string.h>

main() 
{
    int n;
    scanf("%d", &n);
    int i,l,a,j;
    char s[10][10000];
    for(i=0;i<n;i++){
        scanf("%s",s[i]);
        l = strlen(s[i]);
        a=0;
            for(j=0;j<l-j-1;j++){
                if(s[i][j]!=s[i][l-j-1]){
                    a+=abs(s[i][j]-s[i][l-j-1]);
                }
            }
            printf("%d \n",a);
       
    }   
}
