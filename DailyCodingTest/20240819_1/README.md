# 바탕화면 정리 (programmers Lv 1)
 컴퓨터 바탕화면의 파일 위치가 주어졌을 때 최소한의 드래그 크기로 모두 선택하기 위한 점 두 개를 구해야 한다.  
 입력 예 : [".#...", "..#..", "...#."]  
 출력 예 : [0, 1, 3, 4]
# 내가 푼 코드
 ```cs
  public int[] solution(string[] wallpaper)
        {
            int[] answer = new int[] {-1,50,0,-1 };
            for (int i = 0; i < wallpaper.Length; i++)
            {
                for (int j = 0; j < wallpaper[i].Length; j++)
                {
                    if (wallpaper[i][j] == '#')
                    {
                        if (answer[0] == -1)
                        {
                            answer[0] = i;
                        }
                        if (answer[1] > j)
                        {
                            answer[1] = j;
                        }
                        if (answer[3] < j)
                        {
                            answer[3] = j;
                        }
                        answer[2] = i;
                    }
                }
            }
            answer[2]++;
            answer[3]++;
            return answer;
    }
 ```
# 풀이 방법
 1. 주어진 문자열 배열의 각 단어를 순회한다.
 1. '#'이 처음 발견된다면 그때 순회하는 단어의 위치가 드래그 해야할 두 점중 y값이므로 answer[0] = i;한다.
 1. answer[1]은 드래그해야 할 점의 최소 x축 값이므로 '#'이 발견될 때 j 값이 가장 작은 값을 넣는다.
 1. answer[2] 값은 '#'의 가장 큰 y값이므로 '#'이 발견될 때마다 answer[2] = i;한다.
 1. answer[3]은 드래그해야 할 점의 최대 x축 값이므로 '#'이 발견될 때 j 값이 가장 큰 값을 넣는다.
 1. answer 2와 3에 1을 더해서 답을 구한다.
# 문제를 풀며 배운 것
 IndexOf로 더 빨리 구할 수 있었을 것 같기도 하고