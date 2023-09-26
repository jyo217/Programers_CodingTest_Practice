public class Solution {
    public string solution(string s) {
        
        //Jaden Case : 모든 '단어의 첫 문자' 는 대문자, 나머지는 소문자인 문자열.
        
        //하지만 주어진 문자열의 첫 문자가 알파벳이 아니더라도 나머지 뒤의 알파벳은 소문자가 되도록 만든다.
        
        char[] jadenCase = s.ToCharArray();
        
        for(int i = 0 ; i < jadenCase.Length ; i++){
            //현재 단어의 첫 문자라면 알파벳일 때 대문자로 바꾼다.
            if(i > 0 && jadenCase[i-1] == ' ' || i == 0){
                if('a' <= jadenCase[i] && 'z' >= jadenCase[i]){
                    jadenCase[i] -= ' ';  
                }
            }
            //현재 단어의 첫 문자가 아니고, 알파벳이라면 소문자로 바꾼다.
            else if('A' <= jadenCase[i] && 'Z' >= jadenCase[i]){
                jadenCase[i] += ' ';  
            }
        }
        
        string answer = new string(jadenCase);
        return answer;
    }
}