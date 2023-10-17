using System;

public class Solution {
    long[] howMany = new long[2000];
    
    public long solution(int n) {
        howMany[0] = 1;
        howMany[1] = 2;
        
        for (int i = 2; i < n; i++)
            howMany[i] = (howMany[i - 2] + howMany[i - 1]) % 1234567;
        
        return howMany[n - 1];
    }
}