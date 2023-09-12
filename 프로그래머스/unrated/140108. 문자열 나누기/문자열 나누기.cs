using System;

public class Solution {
    public int solution(string s) {
        
        char first = ' ';
        int firstCount = 0;
        int others = 0;
        int answer = 0;
        
        for(int i = 0 ; i < s.Length ; i++){
            //문자열의 끝에 도달했다면 answer 증가, 반복 종료.
            if(i >= s.Length-1){
                answer++; break;
            }
            
            //남은 문자열의 첫 글자라면 first 로 지정한다.
            if(first == ' '){
                first = s[i];
                firstCount++;
            }
            //남은 문자열의 첫 글자가 아니라면
            else{
                //첫 글자와 동일한 문자라면 firstCount 증가, 아니라면 others 증가
                if(s[i] == first){firstCount++;}
                else{others++;}
                //firstCount 와 others 가 같다면 첫 글자와 각 카운트를 초기화하고, answer 증가
                if(firstCount > 0 && firstCount == others){
                    first = ' '; others = 0; firstCount = 0; answer++;
                }
            }    
        }
        
        return answer;
    }
}