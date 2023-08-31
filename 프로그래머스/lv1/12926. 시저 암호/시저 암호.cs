public class Solution {
    public string solution(string s, int n) {
        
        char[] code = s.ToCharArray();
        
        for(int i = 0 ; i < code.Length; i++){
            //알파벳 대문자라면
            if(code[i] >= 65 && code[i] <= 90){
                code[i] += (char)n;
                
                if(code[i] > 90) {code[i] -= (char)26;}
            }
            //알파벳 소문자라면
            else if(code[i] >= 97 && code[i] <= 122){
                code[i] += (char)n;
                
                if(code[i] > 122) {code[i] -= (char)26;}
            }
                
            //n 만큼 아스키 코드를 더한다. 소문자건 대문자건 z 를 초과한다면, 
            //다시 a로 돌아가서 남은 횟수만큼 민다
        }
        
        string answer = new string(code);
        
        return answer;
    }
}