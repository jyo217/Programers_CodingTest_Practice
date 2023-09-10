using System;
using System.Collections.Generic;
using System.Text;

public class Solution {
    public string solution(string X, string Y) {
        //X 와 Y 에 공통적으로 들어가는 숫자들을 가져온다.(중복 허용)
        //이 숫자들을 각 자릿수에 집어넣어 만들 수 있는 가장 큰 수를 구한다.
        //X와 Y 의 문자 배열 x, y 를 만들고 x 의 각 원소에 대해 y 와 같은 값이 있는지 비교.
        
        //10 크기의 int 배열 nums를 선언한다. 각 인덱스가 공통으로 나타나는 해당 숫자이며, 
        //원소값은 X, Y 에서 해당 숫자가 공통으로 나타나는 횟수이다.
        
        //탐색은 0~9 까지만, X 와 Y 에서 해당 숫자가 나타나는 갯수를 체크한다. 
        //둘 중 나타난 횟수가 적은 쪽이 해당 숫자가 공통으로 나타나는 횟수이다.
        //탐색이 끝났다면, nums 에서 원소가 0이 아닌 가장 뒤쪽 인덱스부터 차례로 answer 에 집어넣는다(가장 큰 수)
        
        string answer = "";
    
        int[] nums = new int[10];
        int count = 0;
        int xCount = 0;
        int yCount = 0;
        for(int i = 0 ; i < nums.Length ; i++){
            xCount = 0; yCount = 0;
            foreach(char c in X){
                if(c == (char)(i + '0')){xCount++;}
            }
            foreach(char c in Y){
                if(c == (char)(i + '0')){yCount++;}
            }
            
            if(xCount < yCount){nums[i] = xCount;}
            else{nums[i] = yCount;}
            
            count += nums[i];
        }
        
        StringBuilder sb = new StringBuilder("");
        
        for(int i = nums.Length-1 ; i >= 0 ; i--){
            for(int j = 0 ; j < nums[i] ; j++){
                sb.Append(i);
            }
        }
        
        answer = sb.ToString();
        
        //공통된 숫자들로 만든 최대값이 0 이고 공통된 숫자가 있긴 했다면 
        if(answer.Length > 0 && answer[0] == '0'){ 
            answer = "0"; 
        }
        else if (answer == ""){
            answer = "-1";
        }
        
        return answer;   
    }
}