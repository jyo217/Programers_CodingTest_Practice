public class Solution {
    public string solution(string s) {
        char[] msg = s.ToCharArray();
        bool isOdd = false;
        
        for(int i = 0 ; i < msg.Length; i++){
            //공백문자가 아니라면 홀짝 체크 시작 
            if(msg[i] != ' '){
                //홀수 번째라면 대문자를 소문자로
                if(isOdd){
                    if(msg[i] >= 65 && msg[i] <= 90){
                        msg[i] += ' ';
                    }
                }
                //짝수 번째라면 소문자를 대문자로
                else{
                    if(msg[i] >= 97 && msg[i] <= 122){
                        msg[i] -= ' ';
                    }
                }
                
                isOdd = !isOdd;
            }
            //현재 위치가 공백 문자라면 홀짝 체크 리셋.
            else{
                isOdd = false;
            }
        }
        
        string answer = new string(msg);
        return answer;
    }
}