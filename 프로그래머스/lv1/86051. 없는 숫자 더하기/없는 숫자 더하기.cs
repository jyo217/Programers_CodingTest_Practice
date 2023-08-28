using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        bool[] num = new bool[10];
        
        foreach(int n in numbers){
            num[n] = true;
        }
        
        for(int i = 0 ; i < num.Length ; i++ ){
            if(!num[i]){answer += i;}
        }
        
        return answer;
    }
}