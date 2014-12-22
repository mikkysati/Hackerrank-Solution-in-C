Problem Statement

Sorting is often useful as the first step in many different tasks. The most common task is to make finding things easier, but there are other uses also.

Challenge 

Given a list of unsorted numbers, can you find the numbers that have the smallest absolute difference between them? If there are multiple pairs, find them all.

Input Format 

There will be two lines of input:

n - the size of the list

array - the n numbers of the list

Output Format 

Output the pairs of numbers with the smallest difference. If there are multiple pairs, output all of them in ascending order, all on the same line (consecutively) with just a single space between each pair of numbers. If there's a number which lies in two pair, print it two times (see sample case #3 for explanation).

Constraints 

2 <= n <= 200000 

-(107) <= x <= (107), where x ∈ array 

array[i] != array[j], 0 <= i, j < N, and i != j

Sample Input #1

10

-20 -3916237 -357920 -3620601 7374819 -7330761 30 6246457 -6461594 266854 

Sample Output #1

-20 30

Explanation 

(30) - (-20) = 50, which is the smallest difference.

Sample Input #2

12

-20 -3916237 -357920 -3620601 7374819 -7330761 30 6246457 -6461594 266854 -520 -470 

Sample Output #2

-520 -470 -20 30

Explanation 

(-470) - (-520) = 30 - (-20) = 50, which is the smallest difference.

Sample Input #3

4

5 4 3 2

Sample Output #3

2 3 3 4 4 5

Explanation 

Here, the minimum difference will be 1. So valid pairs are (2, 3), (3, 4), (4, 5). So we have to print 2 one time, 3 and 4 two times, and 5 one time.
