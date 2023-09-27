using System;

public class Solution {
    public int[] solution(int brown, int yellow) {
        
        //격자 무늬 카펫의 가장 바깥 1줄은 갈색으로, 중앙의 나머지 부분은 노란색으로 칠해져 있다.
        //갈색으로 칠해진 격자의 갯수와 노란색으로 칠해진 격자의 갯수를 각각 brown, yellow 라 한다.
        //카펫의 가로 길이는 세로 길이와 같거나 길다. 
        //이것으로 격자 무늬 카펫의 가로, 세로 길이를 담은 배열을 구하라.
        
        //가로, 세로 길이를 각각 a, b 라 하면 brown + yellow == ab 이다.
        
        //갈색 부분은 2a + 2b - 4 이다.
        //노란색 부분은 (a-2) * (b-2) => ab -2a -2b + 4 이다.
        
        //ab == (2a + 2b - 4) + (ab -2a -2b + 4) == ab 이다. 
        
        int width = 3;
        int length = 3;
        
        int n =  (brown + 4) / 2;
        int size = brown + yellow;
        
        if(n % 2 == 0){
            width = n/2;
            length = width;
        }
        else{
            length = n/2;
            width = length+1;
        }
        
        while(true){
            if(size == width * length){
                break;
            }
            else{
                width += 1;
                length -= 1;
                
                if(length < 3){break;}
            }
        }
        
        int[] answer = new int[2] {width, length};
        return answer;
    }
}