using System;
using System.Text;

public class Solution {
    public int[] solution(string s) {
        
        //주어진 문자열 s 에서 모든 '0' 을 제거한다. 이 과정을 거친 s 의 길이를 length 라 한다.
        //s 가 length 를 2진법으로 표현한 문자열로 대체하는 것을 '이진 변환' 이라 한다.
        
        //s가 "1" 이 될 때 까지 이 과정을 반복했을 때, 
        //반복한 횟수와 그 과정에서 제거된 0의 갯수를 담은 배열을 구하라. 
        
        StringBuilder sb = new StringBuilder(s);
        int length = 0;
        int loop = 0;
        int removedZero = 0;
        while(sb.ToString() != "1"){
            for(int i = 0 ; i < sb.Length ;){
                if(sb[i] == '0'){
                    sb.Remove(i,1);
                    removedZero++;
                }
                else{ i++; }
            }
            sb = new StringBuilder(Convert.ToString(sb.Length, 2));
            loop++;
        }
        
        int[] answer = new int[2] {loop, removedZero};
        return answer;
    }
}