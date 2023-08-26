using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int divisor) {
        
        List<int> answerList = new List<int>{};
        
        foreach(int n in arr){
            if(n % divisor == 0){
                answerList.Add(n);
            }
        }        
        
        int[] answer;
        
        if(answerList.Count == 0){answer = new int[1]; answer[0] = -1;}
        else{
            answer = new int[answerList.Count];
            answerList.CopyTo(answer);
            Array.Sort(answer);
        }
        
        return answer;
    }
}