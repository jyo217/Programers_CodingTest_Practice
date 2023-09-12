using System;
using System.Text;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
        //같은 키를 연속으로 누르면 거기에 배정된 여러 개의 문자들이 순차적으로 바뀐다.
        //다만, 특정 키를 눌러야 입력되는 문자도 있고, 같은 문자가 자판 전체에 여러 번 배정되어 있을 수도 있다.
        //거기다가 아예 배정되지 않아 입력 불가능한 문자도 있다.
        //1번 키부터 할당된 문자가 담긴 문자열 배열 keymap 과 입력하려는 문자열 targets 가 주어질 때,
        //각 문자열을 작성하기 위해 최소한 키를 몇 번 씩 눌러야 하는지를 담은 배열 answer 를 구하라.
        //입력 불가능한 문자라면 -1 이 저장된다.
        
        //각 문자별로 입력하는 데 필요한 최소한의 키 입력을 구한다.
        //각 targets 원소 문자열에서 해당 문자가 나오는 횟수를 곱한 값을 모두 더한다.
        //만약 존재하지 않는 원소가 있다면 -1.
        
        //각 문자별로 입력하는 데 필요한 최소한의 키 입력을 구한다.
        //keymap 을 처음부터 끝까지 탐색하면서 처음으로 나오는 문자라면 모두 배열에 저장한다.
        //다른 자료형은 비효율적일 듯 하다. 각 문자와 이에 대응하는 최소한의 키 입력 횟수를 저장하면서도 
        //문자를 키 값으로 사용해야 하므로 Dictionary 를 쓰는 것이 가장 좋아 보인다.
        
        Dictionary<char, int> keys = new Dictionary<char, int>();
        int[] answer = new int[targets.Length];
        
        //keymap 의 각 원소에 대해서
        foreach(string s in keymap){
            for(int i = 0 ; i < s.Length ; i++){
                //현재 반복의 문자를 키로 가지는 원소가 keys 에 존재한다면 
                if(keys.ContainsKey(s[i])){
                    //해당 문자를 입력하는 데 필요한 키 입력 횟수가 더 작은 쪽을 저장한다.
                    if(keys[s[i]] > i+1){
                        keys[s[i]] = i+1;
                    }
                }
                //현재 반복의 문자를 키로 가지는 원소가 keys 에 없다면 
                else{
                    keys.Add(s[i], i+1);
                }
            }
        }
        
        for(int i = 0 ; i < targets.Length ; i++){
            for(int j = 0 ; j < targets[i].Length ; j++){
                //현재 반복의 문자를 키로 가지는 원소가 keys 에 존재한다면 
                if(keys.ContainsKey(targets[i][j])){
                    //해당 문자를 입력하는 데 필요한 최소 키 입력 횟수만큼 answer 의 해당 원소를 증가시킨다.
                    answer[i] += keys[targets[i][j]];
                }
                //존재하지 않는다면 answer 의 해당 인덱스에 -1을 저장하고 targets 의 다음 인덱스로 넘어간다.
                else{
                    answer[i] = -1; break;
                }
            }
        }
        
        return answer;
    }
}