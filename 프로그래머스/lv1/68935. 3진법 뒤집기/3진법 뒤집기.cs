using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        Stack<int> stack = new Stack<int>();
        int div = 3;
        
        while(n > 0){
            stack.Push((n % div));
            n /= div;
            Console.WriteLine(stack.Peek());
        }      
        
        int count = 0;
        
        while(stack.Count > 0){
            answer += stack.Pop()*(int)Math.Pow(div, count);
            count++;
        }
        
        return answer;
    }
}