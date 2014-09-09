#include <stdio.h>
#include <string.h>
#include <math.h>
#include <stdlib.h>

int main() {

    int t,T,n,i,j,temp;
    long long int count,k;
    scanf("%d",&T);
    int c[1000000] = {0};
    for(t=0;t<T;t++){
        scanf("%d",&n);
        int a[n];
        count =0;
        for(i=0;i<n;i++){
            scanf("%d",&temp);
            c[temp-1]++ ;
        }
        for(i=0;i<1000000;i++){
            if(c[i]>1){
                k = c[i];
                count+= k*(k-1);  
            }
            
            c[i] = 0;
        }
        
        printf("%lld\n",count);
    }
    return 0;
}
