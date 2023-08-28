public class Solution {
    public int[] solution(int[] arr) {
        
        int size = 0;
        if(arr.Length <= 1){size = 1;}
        else{size = arr.Length-1;}
        
        int[] answer = new int[size];
        
        if(answer.Length == 1){answer[0] = -1;}
        else{
            int min = 9999;
            int count = 0;
            foreach(int n in arr){
                if(min > n){
                    min = n;
                }
            }
        
            for(int i = 0; i < arr.Length ; i++){
                if(arr[i] != min){
                    answer[count] = arr[i];
                    count++;
                }
            }
        }
        
        return answer;
    }
}