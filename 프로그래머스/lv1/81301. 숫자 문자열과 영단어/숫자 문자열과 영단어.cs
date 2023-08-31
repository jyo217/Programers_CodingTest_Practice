using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        string num = "";
        List<int> numList = new List<int>();
        
        foreach(char c in s){
            //현재 문자가 알파벳이라면
            if(c >= 'a' && c <= 'z'){
                num += c;
                //현재까지의 알파벳 문자열을 숫자로 변환 및 삽입 시도. 성공했다면 누적 문자열 초기화
                if(ConvertNum(num, numList)){
                    Console.Write($"{numList[numList.Count-1]} ");
                    num = "";
                }
                //실패했다면 그대로 넘김.
                else{
                    
                }
            }
            //현재 문자가 숫자라면 삽입.
            else{
                numList.Add((int)Char.GetNumericValue(c));
                Console.Write($"{numList[numList.Count-1]} ");
            }
        }
        
        for(int i = 0; i < numList.Count; i++){
            answer += numList[i] * (int)Math.Pow(10,numList.Count-(i+1));
        }
        
        return answer;
    }
    
    public static bool ConvertNum(string str, List<int> numList){
        
        bool isDone = true;
        
        switch(str){
            case "zero":{
                numList.Add(0);
                break;
            }
            case "one":{
                numList.Add(1);
                break;
            }
            case "two":{
                numList.Add(2);
                break;
            }
            case "three":{
                numList.Add(3);
                break;
            }
            case "four":{
                numList.Add(4);
                break;
            }
            case "five":{
                numList.Add(5);
                break;
            }
            case "six":{
                numList.Add(6);
                break;
            }
            case "seven":{
                numList.Add(7);
                break;
            }
            case "eight":{
                numList.Add(8);
                break;
            }
            case "nine":{
                numList.Add(9);
                break;
            }
            default:{
                isDone = false;
                break;
            }
        }
        return isDone;
    }
}