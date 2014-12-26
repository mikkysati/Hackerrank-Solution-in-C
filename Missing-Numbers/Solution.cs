import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        
    Scanner in = new Scanner(System.in);
    int n = in.nextInt();
    
    int[] a = new int[n];
    
    ArrayList<Integer> ans = new ArrayList<Integer>(); 
    int temp;
    HashMap<Integer, Integer> hash = new HashMap<Integer, Integer>();
    for(int i=0; i<n; i++){
      a[i] = in.nextInt();
      if(!hash.containsKey(a[i]))
        hash.put(a[i],1);
      else{
        temp = hash.get(a[i]);
        hash.put(a[i],temp+1);
      }
    }
    int m = in.nextInt();
    int[] b = new int[m];
    for(int i=0; i<m; i++){
      b[i] = in.nextInt();
      if(!hash.containsKey(b[i]) || hash.get(b[i])==0)
        ans.add(b[i]);
      else{
        temp = hash.get(b[i]);
        hash.put(b[i],temp-1);
      }
    }
    Collections.sort(ans);
    for(int i: ans)
      System.out.print(i+" ");
    }
}
