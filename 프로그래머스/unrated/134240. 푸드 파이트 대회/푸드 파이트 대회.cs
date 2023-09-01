using System;

public class Solution {
    public string solution(int[] food) {
        //한명은 왼쪽=>오른쪽 음식 먹기, 다른 한명은 오른쪽=>왼쪽 음식 먹기
        //정 가운데의 '물' 에 먼저 도착한 쪽이 승리, 음식의 종류와 양, 순서는 같아야 한다.
        //각자의 초반 구간에는 칼로리 낮은 음식을 배치하고 점차 높아지도록 하였음.
        //정 가운데 구간은 0이며, 반환할 answer 배열은 이러한 규칙성을 가짐. 
        //food 배열은 칼로리가 적은 순으로 인덱스에 배치된 음식의 양을 나타내는 정수 리스트이다. 
        //food[0] 은 음식 배치의 정 가운데에 들어갈 물이며, 항상 1이다
        //물을 제외하고 배치되는 음식의 수는 반드시 짝수여야 하며, 나머지 음식들은 전부 버려지게 된다.
    
        int foodAmount = 0;
        
        //food 에서 물 제외하고 수량이 홀수인 음식은 1씩 빼기.
        for(int i = 0 ; i < food.Length; i++){
            if(i == 0){foodAmount += 1;}
            else{
                if(food[i] % 2 != 0 && food[i] > 0){
                    food[i] -= 1;
                }
                foodAmount += food[i];
            }
        }
        
        //이렇게 음식이 배치될 자리의 길이와 최종적으로 사용될 food 구하기.
        char[] foodTable = new char[foodAmount];
        //food[0] 는 가장 가운데에 위치해야 하고, food[1] 부터 answer 의 양 끝에서 
        //가운데 방향으로 채워나간다. 
        int currentFood = 1;
        int tableIndex = 0;
        Console.WriteLine($"foodAmount : {foodAmount}");
        //물 하나를 제외하곤 모든 음식이 짝을 맞추어 배치되어야 함.
        while(foodAmount >= 3 && currentFood < food.Length){
            //해당 종류의 음식 수량이 1 이상이라면
            if(food[currentFood] > 1){
                //테이블의 양 끝에 세팅, 전체적으로 남은 음식 수량 감소
                foodTable[tableIndex] = (char)(currentFood + '0'); 
                Console.WriteLine((char)(currentFood + '0'));
                food[currentFood]--; foodAmount--;
                foodTable[foodTable.Length - (tableIndex+1)] = (char)(currentFood + '0'); 
                food[currentFood]--; foodAmount--;
                tableIndex++;
            }
            //해당 종류의 음식 세팅이 끝났다면
            else{
                currentFood++;
            }
        }
        
        //결과적으로, 물만 남기고 나머지 음식이 배치된 상태가 됨. 여기서 물만 한 가운데에 세팅하면 끝.
        
        foodTable[foodTable.Length/2] = '0';
        
        string answer = new string(foodTable);
        
        return answer;
    }
}