using System;

public class Solution {
    
    public int solution(string[] babbling) {
        int answer = 0;
        string[] bab = new string[4] {"aya", "ye", "woo", "ma"};
        
        //aya, ye, woo, ma 네 가지 발음 또는 이것들을 연속되지 않게 조합한 발음밖에 하지 못 한다.
        //문자열 배열 babbling 이 주어질 때 발음할 수 있는 문자열의 갯수는?
        
        bool isPossible;
        string foreStr = "";//이 전 문자열과 동일한지 확인할 때 사용
        string str = "";//서브스트링 탐색에 사용
        foreach(string s in babbling){
            isPossible = false;
            foreStr = "";
            for(int i = 0 ; i < s.Length;){
                //앞에서부터 일단 두 개의 문자열을 따 온다. 
                //그 후, ye 또는 ma 라면 직전의 문자열과 같은지 검사한다. 
                //ay 또는 wo 였다면 바로 뒤의 문자열을 하나 더 따 온다. 이것이 aya 또는 woo 일 때 
                //직전의 문자열과 같은지 검사한다.
                //직전의 문자열과 같거나, 발음이 불가능한 문자열이라면 불가능하다고 판정한다.
                //마지막 탐색까지 완료했다면 가능하다고 판정한다.
                if(i >= s.Length-1){
                    isPossible = false; break;
                }
                str = s.Substring(i,2);
                Console.WriteLine("start str : " + str);
                if(str == "ye" || str == "ma"){
                    if(str == foreStr) {isPossible = false; break;}
                    else{foreStr = str; i+=2; isPossible = true;}
                }
                else if(str == "ay" && i+2 < s.Length){
                    if(s[i+2] == 'a'){
                        if(str == foreStr) {isPossible = false; break;}
                        else{foreStr = str; i+=3; isPossible = true;}
                    }
                    else{isPossible = false; break;}
                }
                else if(str == "wo" && i+2 < s.Length){
                    if(s[i+2] == 'o'){
                        if(str == foreStr) {isPossible = false; break;}
                        else{foreStr = str; i+=3; isPossible = true;}
                    }
                    else{isPossible = false; break;}
                }
                else{isPossible = false; break;}
            }
            if(isPossible){answer++;}
            Console.WriteLine("count : " + answer);
        }
        
        return answer;
    }
}