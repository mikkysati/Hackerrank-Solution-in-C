#include <stdio.h>
#include <string.h>
#include <math.h>
#include <stdlib.h>

void quicksort(int * A, int p, int r){
    if(p<r){
        int q = partition(A,p,r);
        quicksort(A,p,q-1);
        quicksort(A,q+1,r);
    }
}

int partition(int *A, int p, int r){
    int x,i,j,temp;
    x = A[r];
    i = p-1;
    for(j=p;j<r;j++){
        if(A[j]<=x){
            i++;
            temp = A[i];
            A[i] = A[j];
            A[j] = temp;
        }
    }
    temp = A[i+1];
    A[i+1] = A[r];
    A[r] = temp;
    return i+1;
}

int main() {

    int n,i,g, l=1,sum = 0;
    scanf("%d",&n);
    
    int a[n];
    
    for(i=0;i<n;i++){
        scanf("%d",&a[i]);
        sum+= a[i];
        if(g>a[i] || i==0)
            g = a[i];
    }
    
    int k=0,m,d[n];
    
    m = sqrt(sum);
    
    while(l<= m){
        if(sum % l == 0){
            if(l>=g){
            d[k] = l;
                k++;
            }
            
            if(l != sum/l && (sum/l)>=g){
                d[k] = sum/l;
                k++;
            }
        }
        l++;
    }
    
    int e[k];
   
    l = 0;
    int t = 0;
    while(l<k){
        m = d[l];
        i = 0;
        while(m>0){
            m-= a[i];
            i++;
            if(m==0 && i<n)
                m = d[l];
        }
        if(m==0 && i==n){ 
            e[t] = d[l];
            t++;
        }
        l++; 
        
    } 
    quicksort(e,0,t-1);
    for(i=0;i<t;i++)
        printf("%d ",e[i]);
    return 0;
}
