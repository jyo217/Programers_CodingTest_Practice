public class Solution {
    public bool solution(string s) {
        bool answer = false;
        
        bool isCurrectLength = false;
        bool isOnlyNumber = true;
        
        if(s.Length == 4 || s.Length == 6){isCurrectLength = true;}
        
        foreach(char c in s){
            if(c < 48 || c > 57) {isOnlyNumber = false; break;}
        }
        
        if(isCurrectLength && isOnlyNumber){answer = true;}
        
        
        return answer;
    }
}