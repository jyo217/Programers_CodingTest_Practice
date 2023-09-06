using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int number, int limit, int power) {
        //기사의 수 = number, 공격력 제한수치 = limit
        //제한수치 초과 시 설정될 공격력 = power, 모든 기사의 공격력 합 = answer 
        //각 기사는 자기 기사 번호의 약수 갯수의 공격력을 가진 무기를 필요로 함.
        //하지만 공격력이 제한수치를 초과하면 power 만큼의 공격력을 가진 무기를 받는다.
        
        //약수의 개수는 소인수의 지수에 +1 해서 곱한 값.
        
        //number 이하의 소수 배열 구하기
        int answer = 0;
        
        int atk = 0;
        for(int i = 1; i <= number ; i++){
            atk = getDivCount(i);
            
            if(atk > limit){atk = power;}
            
            answer += atk;
        }
        
        return answer;
    }
    
    //약수의 갯수를 구하는 메소드 
    public static int getDivCount(int num){
        int divCount = 0; 
        
        for (int i = 1; i <= (int)Math.Sqrt(num); i++){
            if (num % i == 0){
                divCount++;
                if (i != num / i) {divCount++;}
            }
        }
        return divCount;
    }
}