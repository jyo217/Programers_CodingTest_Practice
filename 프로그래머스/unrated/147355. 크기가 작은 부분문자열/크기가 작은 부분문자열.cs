using System;

public class Solution {
    public int solution(string t, string p) {
        int answer = 0;
        int num = 0;
        string sub = "";
        
        for(int i = 0 ; i < t.Length-(p.Length-1); i++){
            sub = t.Substring(i,p.Length);
            if(Convert.ToDouble(sub) <= Convert.ToDouble(p)){answer++;}
        }
        
        return answer;
    }
}