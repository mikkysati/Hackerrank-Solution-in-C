import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {
    
    public static void solve(int n){
        long s=4,m=1;
        if(n==0){
            System.out.println(s);
        }
        else{
            for(int i=1; i<=n; i++){
                m = 2*m;
                if(m>1000000007)
                    m = m % 1000000007;
                s = s + m;
                if(s > 1000000007)
                    s = s % 1000000007;
            }
            System.out.println(s);
        }
        
    }

    public static void main(String[] args) {
        int n,t;
        Scanner in = new Scanner(System.in);
        t = in.nextInt();
        for(int i=0; i<t; i++){
            n = in.nextInt();
            solve(n);
        }
    }
}
