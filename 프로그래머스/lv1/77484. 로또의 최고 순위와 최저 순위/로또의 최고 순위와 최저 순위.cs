using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int lower = 0;
        int upper = 0;
        
        int lowerMatched = 0;
        int upperMatched = 0;
        
        //로또는 1~45의 번호 중 6개를 중복되지 않게 선택하여 순서 상관 없이 맞히는 것.
        //1등은 6개, 2등은 5개, ... 5등은 2개, 6등은 그 외의 경우이다.
        //0으로 표시된 부분을 제외했을 때, 당첨 가능한 최고 순위와 최저 순위를 구하라.
        
        //식별 가능한 부분에서만 맞추었다고 가정하면 최저 순위. 
        //0 으로 표시된 부분이 식별된 부분과 중복되지 않은 횟수만큼 더하면 최고 순위.
        
        List <int> lotto = new List<int>();
        
        foreach(int l in lottos){
            if(l != 0) {lotto.Add(l);}
        }
        
        //현재 식별된 숫자들 중 당첨 숫자와 일치하는 갯수 구하기(최저 순위) 
        foreach(int w in win_nums){
            if(lotto.Contains(w)){lowerMatched++;}
        }
        
        //식별되지 않은 숫자들이 무조건 당첨 숫자라 가정했을 때(최고 순위)
        upperMatched = lowerMatched + (lottos.Length - lotto.Count);
               
        lower = getRate(lowerMatched);
        upper = getRate(upperMatched);
        
        int[] answer = new int[2] {upper, lower};
        
        return answer;
    }
    
    public static int getRate(int matched){
        int rate = 7-matched;
        
        if(rate >= 7){
            rate = 6;
        }
        
        return rate;
    }
}