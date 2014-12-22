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
        for(int i=0; i<n; i++){
            a[i] = in.nextInt();
        }
        int min=0, temp=0;
        HashMap<Integer, ArrayList<Integer>> minMap = new HashMap<Integer,ArrayList<Integer>>();
        Arrays.sort(a);
        for(int i=0; i<n-1; i++){
            temp = a[i+1] - a[i];
            if(!minMap.containsKey(temp))
                minMap.put(temp, new ArrayList<Integer>());
            minMap.get(temp).add(a[i]);
            minMap.get(temp).add(a[i+1]); 
            if(min>temp || i==0)
                min = temp;
        }
        
        for(int i=0; i<minMap.get(min).size();i++)
            System.out.print(minMap.get(min).get(i)+" ");
    }
}
