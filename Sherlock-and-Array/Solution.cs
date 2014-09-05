#include<stdio.h>

int main(){
    int T,t,n,i,j;
    scanf("%d",&T);
    for(t=0;t<T;t++){
        scanf("%d",&n);
        int a[n];
        for(i=0;i<n;i++){
            scanf("%d",&a[i]);
        }
        int first=0,last=0;
        for(i=1;i<n;i++){
            last+=a[i];
        }
        for(i=0;i<n-1;i++){
            if(first==last){
                printf("YES\n");
                break;
            }               
            first+= a[i];
            last-= a[i+1];
        }
        if(i==n-1 && n!=1)
            printf("NO\n");
        if(n==1)
            printf("YES\n");
    }
    return 0;
}
