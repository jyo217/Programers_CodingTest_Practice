using System;

public class Solution {
    public int solution(int num) {
        int answer = 0;
        int count = 0;
        double n = (double)num;
        
        while(count <= 500){
            if(n == 1){ 
                answer = count; 
                break;
            }
            
            if(n % 2 < 1){n = Math.Truncate(n); n /= 2;}
            else{n = Math.Truncate(n); n *= 3; n += 1;}
            count++;
        }  
        
        if(count >= 500){answer = -1;}
        
        return answer;
    }
}