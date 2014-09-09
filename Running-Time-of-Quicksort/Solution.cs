#include <stdio.h>
#include <string.h>
#include <math.h>
#include <stdlib.h>

int count1 =0,count2=0;

void insertionSort(int size, int *  ar) {
    int i,j,t;
    for(i=1;i<size;i++){
        j=i;
        while(ar[j]<ar[j-1]&&j>0){
            t=ar[j];
            ar[j]=ar[j-1];
            ar[j-1]=t;
            j--;
            count1++;
        }
    }
    
}

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
            count2++;
        }
    }
    temp = A[i+1];
    A[i+1] = A[r];
    A[r] = temp;
    count2++;
    return i+1;
}

int main() {

    int n,i;
    scanf("%d",&n);
    int a[n],b[n];
    for(i=0;i<n;i++){
        scanf("%d",&a[i]);
        b[i]=a[i];
    }
    insertionSort(n,a);
    quicksort(b,0,n-1);
    printf("%d",count1-count2);
    return 0;
}
