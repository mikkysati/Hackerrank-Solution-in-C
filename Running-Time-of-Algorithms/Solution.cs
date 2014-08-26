#include <stdio.h>
#include <string.h>
#include <math.h>
#include <stdlib.h>
#include <assert.h>
void insertionSort(int size, int *  ar) {
    int i,j,t,count=0;
    for(i=1;i<size;i++){
        j=i;
        while(ar[j]<ar[j-1]&&j>0){
            t=ar[j];
            ar[j]=ar[j-1];
            ar[j-1]=t;
            j--;
            count++;
        }
    }
    printf("%d",count);

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
