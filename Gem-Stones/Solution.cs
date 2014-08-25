#include<stdio.h>
#include<string.h> 

main(){
    int n,i,j, ans=0;
    int count[26]={0};
    char s[100][100];
    char *p;
    scanf("%d",&n);
    for(i=0;i<n;i++){
        scanf("%s",s[i]);
    }
    j=1;
    int t, index;
    int l = strlen(s[0]);
        for(i=0;i<l;i++){
            t=0;
                for(j=1;j<n;j++){
                    if(strchr(s[j],s[0][i])!='\0'){
                        t++;
                    }
                }
                        if(t==n-1){
                            index= s[0][i] - 'a';
                            count[index]=1;
                            
                        }
                
            }
    for(i=0;i<26;i++){
        if (count[i]==1)
            ans++;
    }
    printf("%d",ans);
}
