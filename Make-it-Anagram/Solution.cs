#include<stdio.h>
#include<string.h>
#include<math.h>

int main() {
    
    char s1[10000],s2[10000];
    scanf("%s",s1);
    scanf("%s",s2);
    int t,i,l1, l2;
    int c1[26]={0};
    int c2[26]={0};
    l1 = strlen(s1);
    l2 = strlen(s2);
    for(i=0;i<l1;i++){
        t = s1[i] - 'a';
        c1[t]++;
    }
    for(i=0;i<l2;i++){
        t= s2[i] - 'a';
        c2[t]++;
    }
    int ans = 0;
    for(i=0;i<26;i++){
        ans+= abs(c1[i]-c2[i]);
    }
    printf("%d",ans);
    return 0;
}
