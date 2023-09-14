using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] ingredient) {
        
        //재료는 아래에서 위로 쌓인다. 빵-야채-고기-빵 순서로 쌓였을 때만 
        //해당 재료를 제거하고 햄버거 1개를 만듦. 
        //맨 위부터 아래로 4개가 순서대로 들어왔는지만 검사하면 됨.
        //빵은 1, 야채는 2, 고기는 3. ingredient 는 해당 숫자들이 무작위로 들어 있다.
        //ingredient 의 값이 첫 인덱스부터 순서대로 쌓이는 중이라면, 
        //규칙에 따라 최대한으로 만들 수 있는 햄버거의 수량은?
        
        //배열을 참조하여 스택에 순서대로 집어넣으면서 검사.
        //1231 이 붙어서 나올 때마다 제거하고 햄버거 카운트 +1.
        //햄버거 하나를 완성했을 때, 잠시 스택에 추가로 재료를 집어넣는 것을 멈추고 
        //3번째 앞에서부터 햄버거를 더 만들 수 있는지 검사함.
        //마지막 재료까지 집어넣었을 때 햄버거를 더 만들 수 없다면 종료.
        
        int answer = 0;
        int [] ing = ingredient;
        Stack<int> stack = new Stack<int>();
        List<int> list = new List<int>();
        
        foreach(int i in ing){
            list.Add(i);
        }
        
        for(int i = 0; i < list.Count; i++){
            if(i + 3 < list.Count){
                //현재 위치에서부터 1231이 연속으로 나온다면
                if(list[i] == 1 && list[i+1] == 2 && list[i+2] == 3 && list[i+3] == 1){
                    //해당 인덱스들을 제거하고 햄버거 수량 +1
                    for(int j = 0; j < 4; j++){
                        list.RemoveAt(i);
                    }
                    answer++;
                    
                    //최대 앞에서 3자리부터 다시 탐색하도록 한다
                    if(i > 3){i -= 4;}
                    else{i -= i+1;}
                }
            }
        }
        
        return answer;
    }
    
    public static bool isHamberger(int[] arr, int a, int b, int c, int d){
        if(arr[a] == 1 && arr[b] == 2 && arr[c] == 3 && arr[d] == 1){
            arr[a] = 0; arr[b] = 0; arr[c] = 0; arr[d] = 0;
            return true;
        }
        else{return false;}
    }
}