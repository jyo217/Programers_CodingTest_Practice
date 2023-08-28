public class Solution {
    public string solution(string phone_number) {
        
        char[] str = phone_number.ToCharArray();
        
        for(int i = 0 ; i < str.Length-4;i++){
            str[i] = '*';
        }
        
        string answer = new string(str);
        
        return answer;
    }
}