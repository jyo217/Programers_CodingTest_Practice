public class Solution {
    public string solution(int a, int b) {
        string answer = "";
        int day = 4;
        
        //1월 1일은 금요일. a월 b일의 요일은?
        //윤년 : 2월이 29일이며, 8월과 시작 요일이 같아진다.
        //1월 31, 2월 29, 3월 31, 4월 30, 5월 31, 6월 30, 7월 31, 8월 31,
        //9월 30, 10월 31, 11월 30, 12월 31
        
        for(int i = 1 ; i < a ; i++){
            //1월~7월은 2월 제외 홀수 달이 31, 짝수 달이 30.
            //8월부터는 홀수 달이 30, 짝수 달이 31.
            if(i >= 1 && i <= 7 && i != 2){
                day += i % 2 != 0 ? 31 : 30;
            }
            else if(i == 2){
                day += 29;
            }
            else if(i >= 8){
                day += i % 2 != 0 ? 30 : 31;
            }
        }
        
        day += b;
        day %= 7;
        
        switch(day){
            case 0:
                answer = "SUN";
                break;
            case 1:
                answer = "MON";
                break;
            case 2:
                answer = "TUE";
                break;                
            case 3:
                answer = "WED";
                break;
            case 4:
                answer = "THU";
                break;
            case 5:
                answer = "FRI";
                break;
            case 6:
                answer = "SAT";
                break;        
            default:
                answer = "OUT_OF_RANGE_ERROR";
                break;
        }
        
        return answer;
    }
}