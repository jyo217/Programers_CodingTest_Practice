using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers) {
        
        //서로 다른 인덱스의 두 수? 지금까지 시도한 조합인지 확인하는 과정 필요
        //스트링 리스트로 조합 중복 검사, 정수 리스트로 결과값들을 담음
        List<string> strList = new List<string>();
        List<int> num = new List<int>();
        string str = "";
        
        for(int i = 0 ; i < numbers.Length ; i++){
            for(int j = 0 ; j < numbers.Length; j++){
                if( i != j ) {
                    if(numbers[i] > numbers[j]){str = $"{numbers[j]} {numbers[i]}";}
                    else{str = $"{numbers[i]} {numbers[j]}";}
                    
                    //전에 시도한 조합이 아니라면
                    if(!strList.Contains(str)){
                    //다른 결과값이라면
                    if(!num.Contains(numbers[i] + numbers[j])){
                        num.Add(numbers[i] + numbers[j]);
                    }
                    strList.Add(str);
                }
                }
            }
        }
        
        //결과값들을 배열에 담고 오름차순 정렬 후 반환
        
        int[] answer = num.ToArray();
        Array.Sort(answer);
        
        return answer;
    }
}