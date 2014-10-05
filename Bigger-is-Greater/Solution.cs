import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {
    
    public static void solve (char str[])
    {
        int i, flag=0;
        loop:
        for(i=str.length-1; i>0; i--)
        {
            
            if(str[i]>str[i-1])
            {
                int j = str.length-1;
                while(flag==0 && j!=i-1){
                    if(str[i-1]<str[j])
                    {
                        char t = str[j];
                        str[j] = str[i-1];
                        str[i-1] = t;
                        flag = 1;
                        break loop;
                    }
                    j--;
                }
            }
                
        }
        
      Arrays.sort(str,i,str.length);
        
        if(flag==0)
            System.out.println("no answer");
        else 
            System.out.println(str);
        
    }
    
    public static void main(String[] args) {
        char name[];
        int t;
        Scanner in = new Scanner(System.in);
        t = in.nextInt();
        for(int i=0; i<t; i++)
        {
            name = in.next().toCharArray();
            solve(name);
        }
    }
}
