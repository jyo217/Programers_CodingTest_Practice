public class Solution {
    public string[] solution(string[] strings, int n) {
        string temp = "";
        int shorter = 0;
        for (int i = 0; i < strings.Length; i++)
            {
                for (int j = i + 1; j < strings.Length; j++)
                {
                    //인덱스 n 의 문자를 기준으로 정렬.
                    if (strings[i][n] > strings[j][n])
                    {
                        temp = strings[i];
                        strings[i] = strings[j];
                        strings[j] = temp;
                    }
                    //인덱스 n 의 문자가 동일하다면, 사전순으로 정렬.
                    else if (strings[i][n] == strings[j][n])
                    {
                        //길이가 더 짧은 쪽의 길이를 구하고
                        if(strings[i].Length > strings[j].Length){shorter = strings[j].Length;}
                        else{shorter = strings[i].Length;}

                        for (int k = 0; k < shorter; k++)
                        {
                            if (strings[i][k] > strings[j][k])
                            {
                                temp = strings[i];
                                strings[i] = strings[j];
                                strings[j] = temp;
                                break;
                            }
                            else if (strings[i][k] < strings[j][k])
                            {
                                break;
                            }
                            else{}
                        }
                    }
                }
            }
        
        string[] answer = strings;
        return answer;
    }
}