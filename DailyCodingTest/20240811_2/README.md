# 명예의 전당 (1) (programmers Lv 1)
 명예의 전당 목록의 개수 k, 1일부터 마지막 날까지 출연한 가수들의 점수인 score가 주어졌을 때,  
 매일 발표된 명예의 전당의 최하위 점수를 return하는 solution 함수를 완성해야한다.  
 입력 예 : 3, [10, 100, 20, 150, 1, 100, 200]  
 출력 예 : [10, 10, 10, 20, 20, 100, 100]
# 내가 푼 코드
 ```cs
  public int[] solution(int k, int[] score)
        {
            int[] answer = new int[score.Length];
            List<int> list = new List<int>();

            for (int i = 0; i < score.Length; i++)
            {
                list.Add(score[i]);
                list.Sort();
                if (list.Count > k)
                {
                    list.Remove(list[0]);
                }
                answer[i] = list[0];
            }

            return answer;
    }
 ```
# 풀이 방법
 1. score를 순회하여 list에 추가하고 정렬한다.
 2. answer배열에 list[0]을 추가한다.
 3. 만약 list의 Count가 k보다 크다면 list[0]을 제거한다.
# 문제를 풀며 배운 것
 list.Remove(list[0])을 쓰기 보다는 list.RemoveAt(0)이 빠르고 효율적이다.  