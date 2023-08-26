using System;

public class Solution {
    public int solution(int[] absolutes, bool[] signs) {
        int answer = 0;
        int abs = 0;
        
        for(int i = 0 ; i < absolutes.Length ; i++){
            abs = absolutes[i];
            
            if(!signs[i]){abs *= -1;}
            answer += abs;
        }
        
        return answer;
    }
}