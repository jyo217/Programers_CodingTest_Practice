using System;

public class Solution {
    public int[] solution(string[] wallpaper) {
        //wallpaper : 컴퓨터 바탕화면의 상태를 나타내는 배열.
        //각 파일들은 바탕화면의 격자칸에 위치하며, 가장 왼쪽 위를 (0,0) 으로 취급한다.
        //빈 칸은 '.', 파일이 있는 칸은 '#' 으로 표현한다.
        //주어진 wallpaper 에는 하나 이상의 파일이 존재한다.
        
        //드래그하여 범위를 지정하고, 지정된 파일들을 삭제할 수 있다.
        //최소한의 이동 거리를 갖는 드래그로 모든 파일을 선택해 한 번에 지우려 한다.
        
        //드래그의 이동 거리는 드래그 시작 좌표를 A(ax, ay), 드래그 종료 좌표를 B(bx, by) 라 할 때,
        //|ax - bx| + |ay - by| 이다.
        
        //좌표 A 에서 B 까지 드래그하면 두 좌표를 각각 왼쪽 상단, 
        //오른쪽 하단으로 하는 직사각형 내부의 모든 파일이 선택된다.
        
        //모든 파일을 지정하면서도 최소한의 이동 거리를 갖는 드래그의 시작점과 끝점 좌표를 구하라.
        
        const int EMPTY = -999;
        const int X = 0;
        const int Y = 1;
        
        int[] answer = new int[4];
        
        int[] leftUpper = new int[2] {EMPTY, EMPTY};
        int[] rightLower = new int[2] {EMPTY, EMPTY};
        
        //결국, 바탕화면 배열에서 '#' 이 있는 인덱스 중에서 
        //파일이 있는 가장 왼쪽 x 좌표와 위쪽 y 좌표, 파일이 있는 가장 오른쪽 x 좌표와 아래쪽 y 좌표를 구해야 한다.
        //가장 왼쪽 상단의 좌표를 (ax,ay) 라 할 때 드래그 시작점 좌표는 (ax, ay) 이다.
        //가장 오른쪽 하단의 좌표를 (bx, by) 라 할 때 드래그 끝점 좌표는 (bx+1, by+1) 이다. 
        //파일이 단 하나만 있다면 해당 위치에서 두 좌표를 바로 구하면 된다.
        
        //wallpaper 를 탐색할 때 파일이 있는 위치를 발견했다면 
        //y 좌표가 leftUpper 의 y 좌표보다 작으면 교체, x 의 좌표가 leftUpper 의 x 좌표보다 작으면 교체.
        //y 좌표가 rightLower 의 y 좌표보다 크면 교체, x 의 좌표가 rightLower 의 x 좌표보다 크면 교체.
        //파일이 있는 위치를 처음 발견했다면 leftUpper 와 rightLower 를 같이 초기화한다.
        
        for(int i = 0 ; i < wallpaper.GetLength(0) ; i++){
            for(int j = 0 ; j < wallpaper[i].Length ; j++){
                if(wallpaper[i][j] == '#'){
                    //첫 파일이라면
                    if(leftUpper[X] == EMPTY){
                        leftUpper[X] = i; leftUpper[Y] = j;
                        rightLower[X] = i; rightLower[Y] = j;
                    }
                    //y 좌표가 leftUpper 의 y 좌표보다 크면 교체, x 의 좌표가 leftUpper 의 x 좌표보다 작으면 교체.
                    //y 좌표가 rightLower 의 y 좌표보다 작으면 교체, x 의 좌표가 rightLower 의 x 좌표보다 크면 교체.
                    else{
                        if(i < leftUpper[X]){leftUpper[X] = i;}
                        if(i > rightLower[X]){rightLower[X] = i;}
                        if(j < leftUpper[Y]){leftUpper[Y] = j;}
                        if(j > rightLower[Y]){rightLower[Y] = j;}
                    }
                }
            }
        }
        //드래그 시작점 좌표는 (ax, ay), 드래그 끝점 좌표는 (bx+1, by+1) 이다. 
        answer[0] = leftUpper[X]; answer[1] = leftUpper[Y];
        answer[2] = rightLower[X]+1; answer[3] = rightLower[Y]+1;
        
        return answer;
    }
}