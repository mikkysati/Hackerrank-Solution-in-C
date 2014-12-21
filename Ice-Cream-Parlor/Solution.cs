import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        int T;
        Scanner in = new Scanner(System.in);
        T = in.nextInt();
        for(int t=0; t<T; t++){
            int m,n,temp1=0,temp2=0;
            m = in.nextInt();
            n = in.nextInt();
            int[] c = new int[n];
            HashMap<Integer,Integer> hash = new HashMap<Integer,Integer>(n);
            for(int i=0; i<n; i++){
                c[i] = in.nextInt();
                hash.put(c[i],i+1);
            }
            for(int i=0; i<n; i++){
                if(hash.containsKey(m-c[i]) && i+1!=hash.get(m-c[i])){
                    temp1 = i+1;
                    temp2 = hash.get(m-c[i]);
                    break;
                }
            }
            if(temp1<temp2)
                System.out.println(temp1+" "+temp2);
            else
                System.out.println(temp2+" "+temp1);
            
        }
    }
}
