public class Solution {
    public int solution(int n) {
        
        //피보나치 수 F(n): F(0) = 0, F(1) = 1이라 할 때, 
        //2 이상의 n 에 대해서 F(n) = F(n-1) + F(n-2) 인 수. 
        
        //2 이상의 n 이 입력되었을 때 F(n) 을 1234567 로 나눈 나머지를 구하라.
        
        int answer = GetFibonacci(n) % 1234567;
        return answer;
    }
    public static int GetFibonacci(int n){
        if(n == 0){return 0;}
        else if(n == 1){return 1;}
        else {
            //재귀 안 쓰고 구하기
            //1 작은 피보나치 수 + 2 작은 피보나치 수 반복임.
            //0 = 0 , 1 = 1, 2 = 1, 3 = 2, 4 = 3, 5 = 5, 6 = 8, 7 = 13, 8 = 21, 9 = 33, 10 = 54
            int first = 1;
            int second = 0;
            int temp = 0;
            
            for(int i = 2 ; i <= n; i++){
                temp = (first + second) % 1234567;
                second = first; first = temp;
            }
            return temp;
        }
    }
}