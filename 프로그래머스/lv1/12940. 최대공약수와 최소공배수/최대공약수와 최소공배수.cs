using System;
using System.Collections.Generic;

public class Solution {
    public int mod(int min, int max){
            if(max == 0){return min;}
            return mod(max, min % max);
        }
    
    public int[] solution(int n, int m) {
        
        
        
        int[] answer = new int[2];
        
        int n1 = n;
        int m1 = m;
        //최대공약수 : 서로의 약수들 중에서 같은 값을 가지는 가장 큰 수
        //최소공배수 : 서로의 배수 중에서 같은 값을 가지는 가장 작은 수
        
        int maxDiv = 1;
        int minMul = 1;
        
        
        
        maxDiv = mod(n, m);
        
        minMul = (n1*m1)/maxDiv;
             
        answer[0] = maxDiv;
        answer[1] = minMul;
        
        return answer;
    }
}