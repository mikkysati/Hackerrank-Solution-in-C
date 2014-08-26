#include<stdio.h>

void ascending(int *a,int size){
    int i,j,t;
    for(i=0;i<size;i++){
        for(j=i+1;j<size;j++){ 
            if( *(a+i)> *(a+j)){
                t= *(a+i);
                *(a+i)= *(a+j);
                *(a+j)= t;
            }
        }
    }
}
void descending(int *a,int size){
    int i,j,t;
    for(i=0;i<size;i++){
        for(j=i+1;j<size;j++){ 
            if( *(a+i)< *(a+j)){
                t= *(a+i);
                *(a+i)= *(a+j);
                *(a+j)= t;
            }
        }
    }
}


main (){
    int t,i,j,temp,flag;
    scanf("%d",&t);
    int n,k;
    for(i=0;i<t;i++){
        scanf("%d %d",&n,&k);
        int a[n],b[n];
        for(j=0;j<n;j++){
            scanf("%d",&a[j]);
        }
        for(j=0;j<n;j++){
            scanf("%d",&b[j]);
        }
        ascending(a,n);
        descending(b,n);
        flag=1;
        for(temp=0;temp<n;temp++){
            if((a[temp]+b[temp])<k)
                flag=0;
        }
        if(flag==1)
            printf("YES\n");
        else
            printf("NO\n");
    }
}
