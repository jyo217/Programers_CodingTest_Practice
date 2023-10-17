using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int k, int[] tangerine) {

        //수확한 귤에서 k 개를 상자 하나에 담는다.
        //크기별로 귤을 분류했을 떄 최대한 귤의 종류의 수를 줄여서 담고자 한다.
        //수확한 귤들의 크기를 표현한 배열 tangerine 이 주어질 때, 
        //상자 하나에 담은 귤들의 크기 종류의 최소값을 구하라
        
        //크기별 수량 구하기 + 수량이 가장 많은 것부터 담기.
        
        Dictionary<int, int> tan = new Dictionary<int, int>();
        
        //크기별 수량 구하기
        foreach(int i in tangerine){
            if(tan.ContainsKey(i)){
                tan[i]++;
            }
            else{tan.Add(i,1);}
        }
        
        //양이 많은 순으로 정렬
        var tanDesc = tan.OrderByDescending(x => x.Value);
        
        int answer = 0;
        
        //양이 많은 것부터 담기. 상자에 다 담았다면 탈출.
        foreach(var v in tanDesc){
            if(k <= 0){break;}
            k -= v.Value;
            answer++;
        }
        
        return answer;
    }
}