using System;

public class Solution {
    public bool solution(int x) {
        bool answer = false;
        int max_index = x.ToString().Length;
        int temp = x;
        int[] num = new int[max_index];
        
        for(int i = 0 ;i < num.Length ; i++){
            num[i] = x % 10; x /= 10;       
        }
        
        int div = 0;
        
        foreach(int n in num){div += n;}
        
        if(div > 0 && temp % div == 0){answer = true;}
        
        
        return answer;
    }
}