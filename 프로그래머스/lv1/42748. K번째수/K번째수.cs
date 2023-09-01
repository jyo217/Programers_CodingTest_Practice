using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        List<int> list = new List<int>();
        
        //commands 의 행 단위로 루프 
        for(int index = 0 ; index < commands.GetLength(0) ; index++){
            int i = commands[index,0];
            int j = commands[index,1];
            int k = commands[index,2];
            int newArrLength = j-i+1;
            //부분배열 구하기
            int[] newArr = new int[newArrLength];
            
            Array.Copy(array, i-1, newArr, 0, newArrLength);
            Array.Sort(newArr);
            list.Add(newArr[k-1]);
        }
        
        
        int[] answer = list.ToArray();
        
        return answer;
    }
}