using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];
        string str = "";
        
        //문자열 s 내의 각 문자들에 대한 정보를 정수로 나타낸 배열 반환.
        //가장 앞에 처음으로 나온 문자는 -1, 이 전에 나온 문자가 존재한다면 앞 뒤 중 가장 가까운 문자와의 거리이다.
        for(int i = 0; i < s.Length ; i++){
            //처음으로 발견한 문자라면
            if(!str.Contains(s[i])){
                str += s[i];//str 에 추가
                answer[i] = -1;
            }
            //전에 발견한 적이 있는 문자라면 동일한 문자가 나올 때 까지 앞뒤로 탐색하고 그 거리를 삽입 
            else{
                int distance = 1;
                while(i - distance >= 0 || i + distance < s.Length){
                    if(i - distance >= 0){
                        if(s[i - distance] == s[i]){
                            break;
                        }
                    }
                    else if(i + distance < s.Length){
                        if(s[i + distance] == s[i]){
                            break;
                        }
                    }
                    distance++;
                }
                answer[i] = distance;
            }
        }
        
        return answer;
    }
}