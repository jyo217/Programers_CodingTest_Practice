using System;

public class Solution {
    public string solution(string s) {
        
        //문자열 s 는 "숫자1 숫자2 ... 숫자n" 형태이다.
        //이 숫자들 중 최소값과 최대값을 구하고, "최소값 최대값" 형태의 문자열을 반환하라.
        
        string[] str = s.Split(' ');
        int max = 0; int min = 0;
        int n = 0;
        for(int i = 0 ; i < str.GetLength(0) ; i++){
            n = Convert.ToInt32(str[i]);
            if(i == 0){max = n; min = n; }
            else if(max < n){ max = n; }
            else if(min > n){ min = n; }
        }
        
        string answer = $"{min} {max}";
        return answer;
    }
}