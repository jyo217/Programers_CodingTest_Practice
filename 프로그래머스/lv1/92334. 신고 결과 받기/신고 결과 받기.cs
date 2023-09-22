using System;
using System.Collections.Generic;
using System.Linq;

struct User{
    //파라미터가 없는 생성자(기본 생성자)는 사용 불가능하다고 함(이미 있으므로 재정의 불가)
    public User(string name){
        this.name = name;
        reportList = new List<string>();
        reported = 0;
        msgCount = 0;
    }
    
    public string name; 
    public List<string> reportList;
    public int reported;
    public int msgCount;
}

public class Solution {
    public int[] solution(string[] id_list, string[] report, int k) {
        
        //각 유저는 한 번에 한 유저만 신고 가능. 신고 횟수 제한은 없으나, 
        //한 유저가 특정 유저를 여러 번 신고했을 땐 해당 유저에 대한 신고 횟수를 추가로 카운트하지 않는다.
        //n 번 이상 신고된 유저는 게시판 이용이 정지, 해당 유저를 신고한 모든 유저에게 처리 사실을 알린다.
        //모든 유저들의 신고 내용을 종합, 마지막에 한 번에 이용정지 처리를 시키고 신고한 유저들에게 알림 메시지를 보낸다.
        
        //id_list : 이용자들의 id 
        //report : 신고한 유저 id 와 신고당한 유저 id. "신고한유저 신고당한유저" 형태.
        //k : 이용 정지 처리 기준 신고 누적 횟수
        
        //위의 사항대로 처리했을 때, id_list 에 담긴 순서대로 
        //각 유저가 받은 처리 결과 알림 메시지 수를 구하라.
        
        //Dictionary 를 쓰면 편할 것이다. 
        //각 유저별 신고한 유저 리스트, 각 유저별 신고당한 횟수 리스트, 각 유저별 메시지를 받은 횟수 리스트         
        //=> 차라리 구조체를 쓰자.
        
        User[] users = new User[id_list.Length];
        
        for(int i = 0 ; i < id_list.Length ; i++){
            users[i] = new User(id_list[i]);
        }

        for(int i = 0 ; i < report.GetLength(0) ; i++){
            string[] repo = report[i].Split(' ');
            for(int j = 0 ; j < users.Length ; j++){
                //현재 신고한 유저가
                if(users[j].name == repo[0]){
                    //해당 유저를 처음으로 신고했다면 신고 내역 추가, 신고당한 유저의 신고받은 횟수 증가
                    if(!users[j].reportList.Contains(repo[1])){
                        users[j].reportList.Add(repo[1]);
                        for(int l = 0 ; l < users.Length ; l++){
                            if(users[l].name == repo[1]){
                                users[l].reported++;
                                break;
                            }
                        }
                    }
                    break;
                }
            }
        }
        
        //유저별 누적 신고 횟수를 검사하면서 정지된 유저라면 해당 유저를 신고한 유저들의 알림 메시지 카운터 증가
        for(int i = 0 ; i < users.Length ; i++){
            if(users[i].reported >= k){
                for(int j = 0; j < users.Length ; j++){
                    //해당 유저가 신고한 유저 목록에 정지된 유저가 포함되어 있다면 해당 유저에 대한 알림 메시지 카운터 증가   
                    if(users[j].reportList.Contains(users[i].name)){
                        users[j].msgCount++;
                    }
                }
            }
        }
            
        int[] answer = new int[id_list.Length];
        
        for(int i = 0 ; i < answer.Length ; i++){
            answer[i] = users[i].msgCount;
        }
        
        return answer;
    }
}