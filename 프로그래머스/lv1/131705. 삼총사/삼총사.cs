using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] number) {
        int answer = 0;
        
        //조합 리스트 체크를 위한 문자열
        string check = "";
        
        //현재 반복에서 선택된 학생 리스트
        List<int> selected = new List<int>();
        
        //지금까지 확인한 학생 조합 리스트
        List<string> combo = new List<string>();
        
        for(int i = 0 ; i < number.Length ; i ++){
            
            //j 가 이 전에 선택된 학생이 아니라면 진행
            for(int j = 0 ; j < number.Length ; j++ ){
                if(i != j){
                    //k 가 이 전에 선택된 학생이 아니라면
                    for(int k = 0 ; k < number.Length ; k++ ){
                        if(i != k && j != k){
                            selected.Add(i);
                            selected.Add(j);
                            selected.Add(k);
                            selected.Sort();
                            check = $"{selected[0]} {selected[1]} {selected[2]}";
                            
                            selected.Clear();
                            Console.WriteLine(check);
                            //지금까지 확인한 조합이 아니라면 진행
                            if(!combo.Contains(check)){
                                combo.Add(check);
                                
                                //삼총사 조합이라면
                                if(number[i] + number[j] + number[k] == 0){
                                    answer++;
                                }
                            }
                        }
                    }
                }
            }
        }
        
        return answer;
    }
}