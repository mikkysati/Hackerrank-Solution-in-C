#include <stdio.h>

int main() {

    int n,i,k;
    scanf("%d",&n);
    long long int a[n],sum[n], ans, s=0,temp;
    sum[0] =0;
    for(i=0;i<n;i++){
        scanf("%lld",&a[i]);
        sum[0]+=(i+1)*a[i];
        s+= a[i];
    }
    ans = sum[0];
    for(k=1;k<n;k++){
        temp = n*a[k-1];
        sum[k]= sum[k-1] - s + temp;
        if(ans<sum[k])
            ans = sum[k];
    }
        
    
    printf("%lld",ans);
    return 0;
}
