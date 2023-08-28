using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long m = (long)money;
        long p = (long)price;
        
        for(int i = 1; i <= count; i++){
            m -= p*i;
        }
        
        if(m > 0){return 0;}
        
        return m*-1;
    }
}