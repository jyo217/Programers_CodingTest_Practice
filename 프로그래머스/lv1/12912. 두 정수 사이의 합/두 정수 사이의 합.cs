public class Solution {
    public long solution(int a, int b) {
        long answer = 0;
        int max = b;
        int nextNum = 0;
        
        if(a > b){max = a; nextNum = b;}
        else{max = b; nextNum = a;}

        
        while(nextNum <= max){
            answer += nextNum;
            nextNum++;
        }
        
        return answer;
    }
}