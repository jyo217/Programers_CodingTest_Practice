using System;
using System.Text;

public class Solution {
    public string solution(string s, string skip, int index) {
        string answer = "";
        StringBuilder sb = new StringBuilder("");
        //s 와 skip 은 알파벳 소문자로 이루어져 있다. 
        //s 의 각 문자는 index 만큼 뒤의 알파벳으로 바꾼다.
        //만약 z 를 넘어간다면, 다시 a 부터 시작한다.
        //skip 에 있는 알파벳은 그대로 건너뛴다.
        //s 를 이 규칙대로 변환한 answer 를 구하라.
        
        //index 를 더한 값이 skip 의 각 원소의 배수인지만 체크하면 된다.
        //그 배수만큼 각각 더해주면 된다?
        
        int count = 0;
        int val = 0;
        char ch = ' ';
        foreach(char c in s){
            count = 0;
            val = c;
            while(count < index){
                val += 1;
                if(val > 122) {val -= 26;}
                
                for(int i = 0 ; i < skip.Length ; i++){
                    //val 이 현재 문자의 아스키 코드와 같다면
                    if(val == (int)skip[i]){
                        //카운트하지 않고 넘어간다.
                        break;
                    }
                    //skip 에서 동일한 아스키 코드가 존재하지 않는다면 카운트한다.
                    else if(i >= skip.Length-1){
                        count++;//카운트.
                    }
                }
            }
            
            ch = (char)val;
            sb.Append(ch);
        }
        
        answer = sb.ToString();
        return answer;
    }
}