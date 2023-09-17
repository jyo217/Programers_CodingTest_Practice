using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string today, string[] terms, string[] privacies) {
        
        //today 는 오늘 날짜. terms 는 "약관종류 유효기간".
        //privacies 는 "수집일자 약관종류". 
        //각각 날짜는 yyyy.mm.dd 형태이며, 한 자릿수는 앞에 0이 붙는다.
        //년도는 2000 이상 2022 이하, 월은 1~12월이고 28일 단위이다. 일은 28일까지만 있다.
        //오늘 기준으로 해당 개인정보에 적용된 약관의 유효기간(월 단위) + 수집일자 이상이라면 삭제해야 한다.
        //삭제해야 할 개인정보의 번호(인덱스+1)를 구하라.
        
        //날짜 부분은 가공할 필요가 있다.
        
        List<int> ans = new List<int>();
        string[] thisDay = today.Split('.');
        int[] td = new int[3];
        
        for(int i = 0; i < thisDay.Length; i++){td[i] = Convert.ToInt32(thisDay[i]);}
        
        Dictionary<string, int> term = new Dictionary<string, int>();
        for(int i = 0 ; i < terms.Length ; i++){
            string[] t = terms[i].Split(' '); 
            term.Add(t[0], Convert.ToInt32(t[1]));  
        }
        
        int[] day = new int[3];
        int count = 0;
        for(int i = 0 ; i < privacies.Length ; i++){
            string[] priv = privacies[i].Split(' ');
            string[] priDay = priv[0].Split('.');
            for(int x = 0; x < priDay.Length; x++){day[x] = Convert.ToInt32(priDay[x]);}
            
            //유효기간을 더한 개월수에서 12개월 단위로 년으로 변환
            day[1] += term[priv[1]];
            
            count = 0;
            while(day[1] > 12){
                day[1] -= 12;
                count++;
            }
            day[0] += count;
            
            //유효기간을 더한 수집일자 <= 오늘 날짜라면 ans 에 추가.
            if(td[0] > day[0]){
                ans.Add(i+1);
            }
            else if(td[0] == day[0]){
                if(td[1] > day[1]){
                    ans.Add(i+1);
                }
                else if(td[1] == day[1]){
                    if(td[2] >= day[2]){
                        ans.Add(i+1);
                    }
                }
            }
        }
            
        int[] answer = ans.ToArray();
        
        return answer;
    }
}