using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] answers) {
        
        //주어진 모의고사 문제의 실제 정답 배열 : answers 
        //가장 많은 정답을 맞힌 수포자의 번호 배열 : answer
        
        //1, 2, 3 이라는 수포자가 있고, 모두가 문제를 찍지만 찍는 패턴은 전부 다르다.
        //가장 많은 정답을 맞힌 수포자의 번호를 반환하되, 최대 점수 동점자가 여럿이면 오름차순 정렬할 것.
        
        //1번은 1~5를 계속 반복.
        //2번은 2,1,2,3,2,4,2,5 반복.
        //3번은 3,3,1,1,2,2,4,4,5,5 반복.
        int n1 = 0;
        int n2 = 0;
        int n3 = 0;
        
        for(int i = 0; i < answers.Length ; i++){
            if(answers[i] == getN1(i)) n1++;
            if(answers[i] == getN2(i)) n2++;
            if(answers[i] == getN3(i)) n3++;
        }
        
        List <int> students = new List<int>();
        
        //n1 이 최대 점수일 때
        if(n1 >=  n2 && n1 >= n3){
            students.Add(1);
            //동점자가 있다면
            if(n1 == n2){students.Add(2);}
            if(n1 == n3){students.Add(3);}
        }
        //n2 가 최대 점수일 때
        else if(n2 >= n1 && n2 >= n3){
            students.Add(2);
            //동점자가 있다면
            if(n2 == n1){students.Add(1);}
            if(n2 == n3){students.Add(3);}
        }
        //n3 이 최대 점수일 때
        else if(n3 >=  n1 && n3 >= n2){
            students.Add(3);
            //동점자가 있다면
            if(n3 == n1){students.Add(1);}
            if(n3 == n2){students.Add(2);}
        }
        
        //오름차순 정렬
        students.Sort();
        
        int[] answer = students.ToArray();
        
        return answer;
    }
    
    public static int getN1(int i){
        return i%5 + 1;
    }
    public static int getN2(int i){
        if(i % 2 == 0){return 2;}
        else {
            switch(i % 8){
                case 1 : return 1;
                case 3 : return 3;
                case 5 : return 4;
                case 7 : return 5;
            } 
        }
        return 0;
    }
    public static int getN3(int i){
        int index = i % 10;
        
        if(index <= 1) return 3;
        else if(index <= 3) return 1;
        else if(index <= 5) return 2;
        else if(index <= 7) return 4;
        else if(index <= 9) return 5;
        
        return 0;
    }
}