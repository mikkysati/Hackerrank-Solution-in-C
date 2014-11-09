import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        String s = in.nextLine().toLowerCase();
        char[] c = s.toCharArray();
        int[] a = new int[26];
        int t,f=1;
        for(int i=0; i<c.length; i++){
            if(c[i]!=32){
            t = c[i] - 'a';
                a[t] = 1;}
        }
        for(int i=0; i<26; i++){
            if(a[i]!=1){
                f = 0;
                break;
            }
        }
        if(f==0)
            System.out.print("not pangram");
        else 
            System.out.print("pangram");
    }
}
