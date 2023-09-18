using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] players, string[] callings) {

        //해설진은 선수가 자기 바로 앞 선수를 추월할 때마다 추월한 선수의 이름을 부른다.
        //players 는 1등부터 마지막 등수까지 순서대로 담긴 문자열 배열.
        //callings 는 해설진이 부른 이름을 담은 문자열 배열.
        //경주가 끝났을 때 선수들의 이름을 1등부터 순서대로 담은 배열을 구하라.
        
        //1등이 불리는 경우는 없음.
        //이름이 불렸다는 건, 해당 선수의 그 바로 앞 선수의 순위가 바뀌었다는 것.
        //배열을 쓴다면 인덱스끼리 이리저리 바꿔주는 과정이 시간을 엄청 잡아먹을 것.
        //Dictionary 를 써서 순위를 의미하는 값만 바꿔주는 게 더 나을 것임.
        //다만 둘 중 하나만을 키로 두고서 사용하기에는 각각 기수의 이름과 현재 순위를 
        //따로 탐색해야 하므로 별다른 이점이 없음.
        //키와 값이 둘 다 고유하므로 Inverse Dictionary를 사용, 이를 극복한다.
        
        Dictionary<string,int> player = new Dictionary<string,int>();
        Dictionary<int,string> rank = new Dictionary<int,string>();
        for(int i = 0 ; i < players.Length ; i++){
            player.Add(players[i], i+1);
            rank.Add(i+1, players[i]);
        }
        
        string playerTemp = "";
        int rankTemp = 0;
        for(int i = 0 ; i < callings.Length ; i++){
            //현재 이름이 불린 사람의 추월 전 순위
            rankTemp = player[callings[i]];
            
            //추월당한 사람의 이름
            playerTemp = rank[rankTemp-1];
            
            //추월한 사람의 순위값 1 감소
            player[callings[i]] -= 1;
            //추월당한 사람의 순위값 1 증가
            player[playerTemp] += 1;
            
            //해당 순위인 사람의 이름을 추월당한 사람의 이름으로 변경
            rank[rankTemp] = playerTemp;
            //앞 순위인 사람의 이름을 추월한 사람의 이름으로 변경
            rank[rankTemp-1] = callings[i];
        }
        
        
        string[] answer = new string[rank.Count];
        rank.Values.CopyTo(answer,0);
        return answer;
    }
}