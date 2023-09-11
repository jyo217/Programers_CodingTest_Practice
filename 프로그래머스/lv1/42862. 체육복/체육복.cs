using System;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        //학생번호는 체격 순. 자신의 바로 앞, 또는 뒷번호에게만 체육복 공유 가능
        //최대한 많은 인원이 체육복을 입어야 함.
        //n 은 전체 학생 수, lost 는 체육복을 도난당한 학생번호 배열, reserve 는 여분 체육복이 있는 학생번호 배열
        //여분 체육복은 항상 한 벌이며, 여분 체육복이 있는 학생도 도난당했을 수 있으나 여분만 도난당했다 가정한다.
        //최대한 많은 수의 인원에게 체육복을 입혔을 때 해당 인원의 수는?
        
        //여분 체육복이 있는 인원의 도난 여부 확인, 단순히 체육복을 빌릴 필요가 없는 인원으로 분류.
        //체육복이 필요한 나머지 인원의 번호와 아직 여분 체육복이 남은 인원의 번호 대조, 
        
        int answer = n;
        
        //결과적으로 체육복이 필요 없는 인원이거나 빌려줄 수 없는 인원의 번호는 0 으로 친다.
        //체육복이 필요한 인원이 체육복이 남는 인원의 번호와 같거나 +- 1인지 확인.
        //맞다면 서로의 번호를 0으로 만든다. 
        
        Array.Sort(lost);
        Array.Sort(reserve);
        
        for(int i = 0 ; i < lost.Length; i++){
            for(int j = 0 ; j < reserve.Length ; j++){
                if(reserve[j] == lost[i]){
                        lost[i] = 0; reserve[j] = 0;
                    
                }
            }
        }
        
        for(int i = 0 ; i < lost.Length; i++){
            for(int j = 0 ; j < reserve.Length ; j++){
                if(reserve[j] != 0){
                    //번호가 +- 1 이라면 빌려준다.
                    if(reserve[j] == lost[i] || reserve[j]-1 == lost[i] || reserve[j]+1 == lost[i]){
                        lost[i] = 0; reserve[j] = 0;
                        break;
                    }
                }
            }
        }
        
        foreach(int i in lost){
            if(i != 0){answer--;} 
        }
        
        return answer;
    }
}