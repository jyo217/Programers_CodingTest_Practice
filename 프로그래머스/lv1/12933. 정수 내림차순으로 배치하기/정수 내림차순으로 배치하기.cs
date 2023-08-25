using System;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        
        string num = n.ToString();
        
        int[] ans = new int[num.Length];
        
        for(int i = 0 ; i < ans.Length; i++){
            ans[i] = (int)Char.GetNumericValue(num[i]);
        }
        
        Array.Sort(ans);
        Array.Reverse(ans);
        
        for(int i = 0 ; i < ans.Length; i++){
            answer += (ans[ans.Length-(i+1)] * (long)(Math.Pow(10,i))) ;
        }
        
        return answer;
    }
}