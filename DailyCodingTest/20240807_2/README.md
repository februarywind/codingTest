# 최소직사각형 (programmers Lv 1)
 가로 길이와 세로 길이를 가지는 명함들이 2차원 배열이 입력으로 주어진다.  
 모든 명함을 담을 수 있는 지갑의 최소 넓이를 출력해야 한다.  
 입력 예 : [[60, 50], [30, 70], [60, 30], [80, 40]]  
 출력 예 : 4000  
# 내가 푼 코드
 ```cs
  public int solution(int[,] sizes)
        {
            int[] garo = new int[sizes.GetLength(0)];
            int[] sero = new int[sizes.GetLength(0)];
            for (int i = 0; i < sizes.GetLength(0); i++)
            {
                garo[i] = sizes[i, 0];
                sero[i] = sizes[i, 1];
            }
            while (true)
            {
                int maxGaro = garo.Max();
                int maxGaroIndex = Array.IndexOf(garo, maxGaro);
                int maxSero = sero.Max();
                int maxSeroIndex = Array.IndexOf(sero, maxSero);
                if (maxGaro <= maxSero && maxGaro > sero[maxGaroIndex])
                {
                    int temp = garo[maxGaroIndex];
                    garo[maxGaroIndex] = sero[maxGaroIndex];
                    sero[maxGaroIndex] = temp;
                }
                else if (maxSero <= maxGaro && maxSero > garo[maxSeroIndex])
                {
                    int temp = sero[maxSeroIndex];
                    sero[maxSeroIndex] = garo[maxSeroIndex];
                    garo[maxSeroIndex] = temp;
                }
                else
                {
                    return garo.Max() * sero.Max();
                }
            }
        }
 ```
# 풀이 방법
 1. 가장 넓은 가로와 세로를 구한다.  
 2. 가장 큰 가로(세로)가 가장 큰 세로(가로)보다 작고 해당 명함의 세로(가로) 보다 크면 해당 명함의 가로와 세로를 바꾼다.
 3. 더 이상 바꿀 명함이 없다면 가장 큰 가로와 세로의 곱을 리턴한다.
# 문제를 풀며 배운 것
 그냥 각각의 명함의 가로와 세로를 비교해서 한쪽에 큰 값을 몰아넣으면 되는 거였다.  
 다음엔 더 생각하고 풀어봐야겠다. 상상력이 부족했다.  

 
