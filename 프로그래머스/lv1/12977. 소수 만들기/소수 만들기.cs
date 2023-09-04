using System;
using System.Collections.Generic;
using System.Diagnostics;

class Solution
{
    public int solution(int[] nums)
    {
        Stopwatch s = new Stopwatch();
        
        int answer = 0;
        //nums 의 원소 3개를 골라 더했을 때 소수가 되는 경우의 수 구하기.
        
        //지금까지 시도한 조합인지 체크해가며 해야 함 - string 리스트 사용, 문자열 변환 전에 오름차순 정렬하기
        
        //더한 값이 소수인지 빠르게 확인할 방법이 있는가? - 에라토스테네스의 체.
        //문제에서 나온 nums 의 도메인은 1000 이하의 자연수이다.
        //그렇다면 1000 의 약 3배를 에라토스테네스의 체 알고리즘으로 처리한
        //결과값들의 배열에 포함된 값인지 확인하면 될 것이다.
        
        List<(int, int, int)> strList = new List<(int, int, int)>();
        s.Start();
        List<int> primeList = getPrimeList(3000);//3000 이하의 소수들로 이루어진 리스트 구하기
        s.Stop();
        Console.WriteLine(s.ElapsedMilliseconds);
        int[] combo = new int[3];
        
        s = new Stopwatch(); s.Start();
        for(int i = 0; i < nums.Length ; i++){
            for(int j = 0; j < nums.Length ; j++){
                if(j != i){
                    for(int k = 0; k < nums.Length ; k++){
                        if(k != i && k != j){
                            combo[0] = nums[i]; combo[1] = nums[j]; combo[2] = nums[k];
                            
                            //정렬 후 문자열로 형변환
                            Array.Sort(combo);
                            
                            //지금까지 시도한 조합이 아닐 때, 시도한 조합 리스트에 넣어두고
                            if(!strList.Contains((combo[0], combo[1], combo[2]))){
                                strList.Add((combo[0], combo[1], combo[2]));
                                //결과값이 소수인지 확인한다. 
                                if(primeList.Contains(combo[0] + combo[1] + combo[2])){
                                    answer++;
                                }
                            }
                        }
                    }   
                }
            }
        }
        s.Stop();
        Console.WriteLine(s.ElapsedMilliseconds);

        return answer;
    }
    
    public static List<int> getPrimeList(int num){
        int[] numbers = new int[num];
        
        //배열을 1~num 으로 초기화
        for(int i = 1 ;i <= numbers.Length ; i++){
            numbers[i-1] = i;
        }
        
        //에라토스테네스의 체 알고리즘.
        //2 부터 자연수 N 사이의 소수 구하기 => 2를 제외한 2의 배수 모두 제거 
        //=> 남은 값들 중 가장 작은 값 a 를 제외한 a의 배수 모두 제거 
        //=> ... N 에 도달할 때 까지 반복한다
        //여기서, 소수가 아닌 것은 0으로 만든다
        for(int i = 0 ; i < numbers.Length ; i++){
            if(i == 0){numbers[i] = 0;}//1은 소수가 아니므로
            else if(numbers[i] > 0){
                for(int j = i+1 ; j < numbers.Length ; j++){
                    if(numbers[j] % numbers[i] == 0){
                        numbers[j] = 0;
                    }
                }
            }
        }
        
        List<int> primes = new List<int>();
        
        foreach(int n in numbers){
            if(n > 0){
                primes.Add(n);
            }
        }
        
        return primes;
    }
}