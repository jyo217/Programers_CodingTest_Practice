    using System;

    public class Solution
    {
        public int[] solution(string[] park, string[] routes)
        {
            int[] currPosition = new int[2] { -1, -1 };

            // 출발 위치 찾기
            for (int i = 0; i < park.Length; i++)
            {
                for (int j = 0; j < park[i].Length; j++)
                {
                    if (park[i][j] == 'S')
                    {
                        currPosition[0] = i;
                        currPosition[1] = j;
                        break;
                    }
                }
                if (currPosition[0] != -1 && currPosition[1] != -1)
                    break;
            }

            // 길 찾기
            for (int i = 0; i < routes.Length; i++)
            {
                int y, x;
                y = currPosition[0];
                x = currPosition[1];
                bool isMove = true;

                for (int j = 0; j < (int)routes[i][2] - (int)'0'; ++j)
                {
                    if (routes[i][0] == 'E') x += 1;
                    else if (routes[i][0] == 'W') x -= 1;
                    else if (routes[i][0] == 'S') y += 1;
                    else if (routes[i][0] == 'N') y -= 1;

                    if (y < 0 || y >= park.Length || x < 0 || x >= park[0].Length || park[y][x] == 'X')
                    {
                        isMove = false;
                        break;
                    }
                }

                if (isMove)
                    currPosition = new int[2] { y, x };
            }

            return currPosition;
        }
    }