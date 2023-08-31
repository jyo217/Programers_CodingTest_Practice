using System;

public class Solution {
    public int solution(int[,] sizes) {
        int answer = 0;
        int length1 = 0;
        int length2 = 0;
        int first = 0;
        int second = 0;
        
        for(int i = 0; i < sizes.GetLength(0); i++){
            if(sizes[i,0] > sizes[i,1]){
                first = sizes[i,0];
                second = sizes[i,1];
            }
            else{
                first = sizes[i,1];
                second = sizes[i,0];
            }
            
            if(length1 < first){length1 = first;}
            if(length2 < second){length2 = second;}
        }
        
        answer = length1 * length2;
        
        return answer;
    }
}