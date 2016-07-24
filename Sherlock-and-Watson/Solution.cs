#include<stdio.h>

int main(){
    int n,k,q,temp,x,i;
    scanf("%d %d %d",&n,&k,&q);
    int a[n],b[n];
    for(i=0;i<n;i++){
        scanf("%d",&a[i]);
        b[i]=a[i];
    }
    k = k % n;
    
    for(i=0;i<n;i++){
        a[(i+k)%n]=b[i];
    }
    for(i=0;i<q;i++){
        scanf("%d",&x);
        printf("%d\n",a[x]);
    }
    return 0;
}
