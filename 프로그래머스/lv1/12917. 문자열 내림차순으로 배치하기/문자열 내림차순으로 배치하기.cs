public class Solution {
    public string solution(string s) {
        
        char[] msg = s.ToCharArray();
        char temp = ' ';
        
        for(int i = 0; i< msg.Length; i++){
            for(int j = 0; j < msg.Length ; j++){
                if(msg[i] > msg[j]){
                    temp = msg[i];
                    msg[i] = msg[j];
                    msg[j] = temp;
                }
            }
        }
                
        string answer = new string(msg);
        
        return answer;
    }
}