using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int k, int[] score) {
        int[] answer = new int[score.Length];
        List<int> list = new List<int>();
        int minScore = 0;
        
        //k 는 명예의 전당 목록 점수의 개수, score 는 처음부터 마지막까지 출연한 가수들의 점수 배열.
        //List 를 사용한다면 관리하기 더 쉬울 듯 하다.
        
        
        for(int i = 0 ; i < score.Length; i++){
            //list 의 크기가 k 미만일 때는 일단 무조건 받아들임.
            //새 값이 들어올 때마다 오름차순 정렬. 0번 인덱스가 최소값이 된다
            if(list.Count < k){
                list.Add(score[i]);
                list.Sort();
            }
            //list 의 크기가 k 이상이라면 
            else if(list.Count >= k){
                //새 값이 최소값보다 클 때 0번 인덱스의 원소를 제거, 재정렬
                if(score[i] > list[0]){
                    list.RemoveAt(0);
                    list.Add(score[i]);
                    list.Sort();
                }
            }
            answer[i] = list[0];
        }
        
        
        //answer 은 매일 명예의 전당 최하위 점수 배열
        
        return answer;
    }
}