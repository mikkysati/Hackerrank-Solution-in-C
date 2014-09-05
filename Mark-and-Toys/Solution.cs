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
    int n, k, i, count,d,t;
    scanf("%d %d", &n, &k);
    int prices[n];
    for(i=0; i<n; i++) {
        scanf("%d", &prices[i]);
    }
    
    quicksort(prices,0,n-1);
     
    int answer = 0;
    // Compute the answer
    for(i=0;i<n;i++){
        answer+=prices[i];
        if(answer>k){
            break;
        }
    }
    printf("%d\n", i);
      
    return 0;
}
