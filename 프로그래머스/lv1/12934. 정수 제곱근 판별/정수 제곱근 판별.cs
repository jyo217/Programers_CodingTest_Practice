using System;

public class Solution {
    public long solution(long n) {
        long answer = -1;
        double sqrt = Math.Sqrt(n);
        
        if(Math.Floor(sqrt) == sqrt){
            answer = (long)Math.Pow((sqrt+1),2);
        }
        
        return answer;
    }
}