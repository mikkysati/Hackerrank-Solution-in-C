#include <stdio.h>
#include <string.h>
#include <math.h>
#include <stdlib.h>
#include <assert.h>
void insertionSort(int size, int *  ar) {
    int i,t,v;
    i = size-2;
    v = ar[size-1];
    while(i>=0){
        if (v<ar[i]) {
            ar[i+1]=ar[i]; 
        }
        else {
            ar[i+1]=v;
            break;
        }
        i--;
        for(t=0;t<=size-1;t++)
            printf("%d ",ar[t]);
        printf("\n");
    }
    if(i==-1){
        ar[i+1]=v;
    }
    for(t=0;t<=size-1;t++)
            printf("%d ",ar[t]);
}


int main(void) {
   
int size;
scanf("%d", &size);
int ar[size], i;
for(i = 0; i < size; i++) { 
   scanf("%d", &ar[i]); 
}

insertionSort(size, ar);
   
   return 0;
}
