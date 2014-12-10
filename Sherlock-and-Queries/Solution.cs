import java.io.*;
import java.util.*;

public class Solution {
   public static void main(String[] args) {
       Scanner scanner = new Scanner(System.in);
       Long N = scanner.nextLong();
       Long M = scanner.nextLong();
       scanner.nextLine();

       ArrayList<Long> A = new ArrayList<Long>();
       ArrayList<Long> B = new ArrayList<Long>();
       ArrayList<Long> C = new ArrayList<Long>();

       A.add(0L);
       for (String string : scanner.nextLine().split(" ")) {
           A.add(new Long(string));
       }
       B.add(0L);
       for (String string : scanner.nextLine().split(" ")) {
           B.add(new Long(string));
       }
       C.add(0L);
       for (String string : scanner.nextLine().split(" ")) {
           C.add(new Long(string));
       }

       HashMap<Long, Long> counts = new HashMap<Long, Long>();

       for (int i = 1; i < M+1; i++) {
           if (counts.containsKey(B.get(i))) {
               counts.put(B.get(i), (counts.get(B.get(i)) * C.get(i)) % 1000000007L);
           }
           else {
               counts.put(B.get(i), C.get(i));
           }
       }

       for (Long i = 1L; i < N+1; i++) {
           for (Long j = 1L; j < (N / i) + 1L; j++) {
               if (counts.containsKey(i)) {
                   A.set((int)(i * j), (A.get((int)(i * j)) * counts.get(i)) % 1000000007L); 
               }
           }
       }

       System.out.print(A.get(1));
       for (int i = 2; i < A.size(); i++) {
           System.out.print(" " + A.get(i));
       }
    } 
}
