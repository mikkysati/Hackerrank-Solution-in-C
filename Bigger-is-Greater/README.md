Please note that this is a team event, and your submission will be accepted only as a part of a team, even single member teams are allowed. Please click here to register as a team, if you have NOT already registered.

Given a word w, rearrange the letters of w to construct another word s in such a way that, s is lexicographically greater than w. In case of multiple possible answers, find the lexicographically smallest one.

Input Format 

The first line of input contains t, number of test cases. Each of the next t lines contains w.

Constraints 

1≤t≤105 

1≤|w|≤100 

w will contain only lower case english letters and its' length will not exceed 100.

Output Format 

For each testcase, output a string lexicographically bigger than w in a separate line. In case of multiple possible answers, print the lexicographically smallest one and if no answer exists, print no answer.

Sample Input

3

ab

bb

hefg

Sample Output

ba

no answer

hegf

Explanation

Testcase 1 : There exists only one string greater than ab which can be built by rearranging ab. That is ba. 

Testcase 2 : Not possible to re arrange bb and get a lexicographically greater string. 

Testcase 3 : hegf is the next string ( lexicographically greater ) to hefg.
