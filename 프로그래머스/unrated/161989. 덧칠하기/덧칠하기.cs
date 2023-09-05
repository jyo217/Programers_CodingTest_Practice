using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int n, int m, int[] section) {
        
        int answer = 0;
        
        bool[] sections = new bool[n];
        
        foreach(int sec in section){
            sections[sec-1] = true;
        }
        
        for(int i = 0 ; i < n; i++){
            if(sections[i] == true){
                answer++;
                i += (m-1);
            }
        }
        
        return answer;
    }
}