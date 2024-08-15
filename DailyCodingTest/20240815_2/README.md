# 덧칠하기 (programmers Lv 1)
 벽의 길이 n 룰러의 길이 m 칠해야 할 벽 번호 int[]가 주어졌을 때 페인트칠해야 하는 최소 횟수를 구해야 한다.  
 입력 예 : 8, 4, [2, 3, 6]  
 출력 예 : 2
# 내가 푼 코드
 ```cs
  public int solution(int n, int m, int[] section)
        {
            int answer = 0;
            Queue<int> queue = new Queue<int>(section);
            while (queue.Count > 0) 
            {
                if (queue.Count == 0) break;
                int tmep = queue.Peek() + m;
                for (int i = 0; i < m; i++)
                {
                    if (queue.Peek() < tmep)
                    {
                        queue.Dequeue();
                        if (queue.Count == 0) break;
                    }
                    else
                    {
                        break;
                    }
                }
                answer++;
            }
            return answer;
    }
 ```
# 풀이 방법
 1. 입력받은 배열을 큐로 바꾼다.
 2. temp에 큐의 첫번째 값과 m을 더한다.
 3. 큐에서 temp보다 작은 값을 제거하고 answer에 1을 더한다.
# 문제를 풀며 배운 것
 다른 사람의 풀이를 보니 그냥 입력받은 배열로 척척 풀던데 난 큐로 어렵게 풀어 버렸다. 이게 지식의 저주인가.