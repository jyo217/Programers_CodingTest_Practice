using System;

public class Solution {
    public int solution(int k, int m, int[] score) {
        
        //상태가 가장 좋을 때의 품질점수 : k
        //한 상자에 담기는 사과의 갯수 : m
        //과일장수가 얻는 최대 이익 : answer
        //주어진 사과 각각의 점수 : score
        
        //사과는 무조건 상자 단위로 팔며, 상자 단위 이하의 남는 사과는 버려진다.
        //상자로 묶인 사과는 모두 팔린다고 가정한다.
        //각 사과 상자의 가격은 담긴 사과들 중 가장 낮은 품질점수 * m(상자 당 사과 갯수) 이다.
        
        int answer = 0;
        //각 사과의 점수별 수량을 나타내는 배열
        int[] apples = new int[k+1];
        
        //점수별 수량 배열 초기화. 헷갈리지 않도록 0번 인덱스는 사용하지 않는다.
        foreach(int s in score){
            apples[s]++;
        }
        foreach(int s in apples){
            Console.Write(s);
        }
        Console.WriteLine();
        //각 점수별 수량마다 상자 단위로 묶는다.
        for(int i = 1; i < apples.Length; i++){
            while(apples[i] >= m){
                answer += (i * m);
                apples[i] -= m;
            }
        }
        Console.WriteLine($"first answer = {answer}");
        
        //각 점수별로 상자 묶기를 마친 나머지를 최대한 가격이 높은 것들끼리 상자 단위로 묶는다.
        int remain = 0;
        
        for(int i = apples.Length-1; i >= 1; i--){
            remain += apples[i];
            
            while(remain >= m){
                answer += (i * m);
                remain -= m;
            }
        }
        Console.WriteLine($"second answer = {answer}");
        
        return answer;
    }
}