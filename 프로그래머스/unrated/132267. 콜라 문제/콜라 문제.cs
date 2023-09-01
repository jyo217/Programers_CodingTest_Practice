using System;

public class Solution {
    public int solution(int a, int b, int n) {
        int answer = 0;
        int bottles = n;
        int newBottles = 0;
        
        while(bottles >= a){
            newBottles = (bottles / a) * b;
            bottles = (bottles % a) + newBottles;
            answer += newBottles;
        }
        
        return answer;
    }
}