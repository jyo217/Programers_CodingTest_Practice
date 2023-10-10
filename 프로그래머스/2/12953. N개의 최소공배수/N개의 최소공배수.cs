using System;

public class Solution {
    public int solution(int[] arr) {
        
        //n 개의 수를 담은 배열 arr 의 모든 원소들의 최소공배수를 구하라.
        //가장 작은 원소 min 을 구하고, 이것의 배수를 늘려가며 모든 원소들로 나누어떨어지면 이것이 최소공배수이다.
        
        int max = 0;
        
        foreach(int i in arr){
            if(max == 0 || max < i){
                max = i;
            } 
        }
        
        int LCM = max;
        int count = 0;
        while(true){
            for(int i  = 0 ; i < arr.Length; i++){
                if(LCM % arr[i] == 0){count++;}
            }
            
            if(count == arr.Length){break;}
            count = 0;
            LCM += max;
        }
        
        int answer = LCM;
        return answer;
    }
}