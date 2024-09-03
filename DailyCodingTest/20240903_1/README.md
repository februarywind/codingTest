# H-Index (programmers Lv 2)
 과학자가 발표한 논문 중, h번 이상 인용된 논문이 h편 이상이고 h의 최댓값이 이 과학자의 H-Index입니다.
 입력 예 : [3, 0, 6, 1, 5]  
 출력 예 : 3
# 내가 푼 코드
 ```cs
  public int solution(int[] citations) 
  {
        int answer = 0;
        Array.Sort(citations);
        Stack<int> stack = new Stack<int>(citations);
        int count = stack.Count;
        for (int i = 0; i < count; i++)
        {
            int temp = stack.Pop();
            if (temp > answer && temp != 0)
            {
                answer++;
            }
        }
        return answer;
    }
 ```
# 풀이 방법
 1. 입력받은 배열을 정렬하고 스택으로 변형한다.
 1. stack.Pop가 answer보다 크다면 answer에 1을 더해서 답을 구한다.
# 문제를 풀며 배운 것
 정답을 쓰고 10분 동안 이게 왜 정답인지 고민했다. 이게 왜 되지?