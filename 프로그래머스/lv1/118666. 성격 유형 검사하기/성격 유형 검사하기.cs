using System;

public class Solution {
    public string solution(string[] survey, int[] choices) {
        
        //4개 지표로 성격 유형 구분. 성격은 각 지표에서 두 유형 중 하나로 결정.
        //1번 지표는 R, T
        //2번 지표는 C, F
        //3번 지표는 J, M
        //4번 지표는 A, N
        //이렇게 되므로 성격 유형은 2^4 인 16가지가 된다.
        
        //검사지에는 n 개의 질문이 있고 응답 유형은 긍정, 부정의 각 3단계와 중립 선택지를 포함해 7개로 나뉜다.
        //긍정 계통의 응답을 선택했다면 긍정의 정도에 따라 이에 배정된 유형 점수를 최대 3까지 얻는다.
        //부정 계통의 응답을 선택했다면 부정의 정도에 따라 이에 배정된 유형 점수를 최대 3까지 얻는다.
        //중립 응답을 선택했다면 아무런 점수도 얻지 않는다. 
        
        //survey 의 원소는 각 지표에 해당하는 두 개의 문자로 이루어진 문자열이다. 
        //survey[i] 의 첫 문자는 i+1 번 질문에서 부정 계열의 응답을 했을 때 점수를 얻게 될 유형,
        //두 번째 문자는 긍정 계열의 응답을 했을 때 점수를 얻게 될 유형이다.
        
        //choices 는 응답 내용이 담긴 배열로, 크기는 survey 와 같다. 
        //choices[i] 는 i+1 번 질문에 대한 응답이다.
        //choices 의 원소는 숫자 1~7 중 하나이며, 1은 부정 3점, 2는 부정 2점, 3은 부정 1점이다.
        //4 는 중간이므로 점수를 얻지 않는다. 5는 긍정 1점, 6은 긍정 2점, 7은 긍정 3점이다.
        
        //모든 검사 결과를 종합, 각 지표 내에서 더 높은 점수를 받은 성격 유형이 검사자의 성격 유형이 된다.
        //해당 지표에서 성격 유형 점수가 동일하다면 사전 순으로 더 빠른 쪽을 선택한다.
        
        //이 조건 하에, 응답자의 성격 유형 검사 결과를 구하라. 
        
        string answer = "";
        
        //지표별 각 유형의 점수 기록을 위한 크기가 4인 2차원 정수 배열과 이에 할당된 문자 배열 선언
        int[,] typeScore = new int[4,2];
        char[,] types = new char[4,2] {{'R','T'},{'C','F'},{'J','M'},{'A','N'}};
        int typeIndex = 0;
        int neg = 0;
        int pos = 0;
        
        //응답, 유형점수 for 문 돌리기.
        //1~3 이면 부정 3~1, 4 면 그냥 넘기고, 5~7 이면 긍정 1~3
        for(int i = 0 ; i < survey.Length; i++){
            if(choices[i] != 4){
                    if(survey[i][0] == 'R' || survey[i][0] == 'T'){
                    typeIndex = 0;
                    if(survey[i][0] == 'R'){neg = 0; pos = 1;}
                    else{neg = 1; pos = 0;}
                }
                else if(survey[i][0] == 'C' || survey[i][0] == 'F'){
                    typeIndex = 1;
                    if(survey[i][0] == 'C'){neg = 0; pos = 1;}
                    else{neg = 1; pos = 0;}
                }
                else if(survey[i][0] == 'J' || survey[i][0] == 'M'){
                    typeIndex = 2;
                    if(survey[i][0] == 'J'){neg = 0; pos = 1;}
                    else{neg = 1; pos = 0;}
                }
                else if(survey[i][0] == 'A' || survey[i][0] == 'N'){
                    typeIndex = 3;
                    if(survey[i][0] == 'A'){neg = 0; pos = 1;}
                    else{neg = 1; pos = 0;}
                }
                
                //해당 유형의 점수에 반영
                switch(choices[i]){
                    case 1:{
                        typeScore[typeIndex,neg] += 3; break;
                    }
                    case 2:{
                        typeScore[typeIndex,neg] += 2; break;
                    }
                    case 3:{
                        typeScore[typeIndex,neg] += 1; break;
                    }
                    case 5:{
                        typeScore[typeIndex,pos] += 1; break;
                    }
                    case 6:{
                        typeScore[typeIndex,pos] += 2; break;
                    }
                    case 7:{
                        typeScore[typeIndex,pos] += 3; break;
                    }
                    default:{break;}
                }
            }
        }
        
        //모든 응답을 마치고, 지표별 유형 점수를 통합한 상태
        
        //지표별 foreach
        //0 부터 3 까지 {R,T}, {C,F}, {J,M}, {A,N}
        //유형 점수가 높은 쪽을 answer 에 추가. 유형 점수가 같다면 사전 순으로 빠른 쪽을 추가.
        char c = ' ';
        for(int i = 0 ; i < typeScore.GetLength(0); i++){
            if(typeScore[i,0] >= typeScore[i,1]){
                c = types[i,0];
            }
            else if(typeScore[i,0] < typeScore[i,1]){
                c = types[i,1];
            }
            answer += c;
        }
        
        return answer;
    }
}