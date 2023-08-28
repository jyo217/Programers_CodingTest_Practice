public class Solution {
    public string solution(string s) {
        string answer = "";
        int size = s.Length;
        
        if(size % 2 == 0){
            answer += s[size/2 -1];
            answer += s[size/2];
        }
        else{
            answer += s[size/2];
        }
        
        return answer;
    }
}