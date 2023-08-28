using System;

public class Solution {
    public int solution(int left, int right) {
        int answer = 0;
        int check;
        int count = 0;
        int div;
        
        for(int i = left; i<= right; i++){
            check = i;
            div = 1;
            count = 0;
            
            while(check >= div){
                if(check % div == 0){
                    count++;
                }
                div++;
            }
            
            if(count % 2 == 0){answer += i;}
            else{answer -= i;}
        }
        
        
        return answer;
    }
}