using System;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        string answer = "ERROR MESSAGE";
        
        
        
        //1번, 2번 카드뭉치의 현재 탐색할 문자열의 위치
        int card1Index = 0;
        int card2Index = 0;
        
        //목표 배열을 처음부터 끝까지 탐색. 
        for(int i = 0; i < goal.Length; i++){
            //1번 카드뭉치의 첫 문자열이 목표 배열의 현재 문자열인지 비교.
            //같다면 다음 문자열을 가리키도록 하고 넘어감.
            if(card1Index < cards1.Length && cards1[card1Index] == goal[i]){
                card1Index++;
            }
            else if(card2Index < cards2.Length && cards2[card2Index] == goal[i]){
                card2Index++;
            }
            else{
                answer = "No";
                break;
            }
            
            if(i == goal.Length-1){answer = "Yes";}
        }
        return answer;
    }
}