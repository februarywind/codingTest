# 기능개발 (programmers Lv 2)
먼저 배포되어야 하는 순서대로 작업의 진도가 적힌 정수 배열 progresses와 각 작업의 개발 속도가 적힌 정수 배열 speeds가 주어질 때  
각 배포마다 몇 개의 기능이 배포되는지를 return 하도록 solution 함수를 완성하세요.
 입력 예 : [93, 30, 55], [1, 30, 5]  
 출력 예 : [2, 1]
# 내가 푼 코드
 ```cs
  public int[] solution(int[] progresses, int[] speeds)
        {
            List<int> answer = new List<int>();
            for (int i = 0; i < progresses.Length; i++)
            {
                progresses[i] = (100 - progresses[i]) % speeds[i] == 0 ? (100 - progresses[i]) / speeds[i] : (100 - progresses[i]) / speeds[i] + 1;
            }
            Queue<int> q = new Queue<int>(progresses);
            q.Enqueue(int.MaxValue);
            int max = -1;
            int temp = 1;
            while (q.Count > 1)
            {
                max = Math.Max(max, q.Dequeue());
                if (max >= q.Peek())
                {
                    temp++;
                }
                else
                {
                    answer.Add(temp);
                    temp = 1;
                }
            }
            return answer.ToArray();
    }
 ```
# 풀이 방법
 1. progresses 배열을 완성까지 남은 날자 값으로 바꿔서 큐에 넣는다.
 1. q를 하나씩 제거하고 그 값이 제거된 값중 가장 크다면 max에 대입한다.
 1. max가 Peek보다 크다면 temp에 1을 더하고 작다면 temp를 answer 리스트에 넣고 초기화한다.
 1. q의 마지막 값은 int.MaxValue이므로 입력된 마지막 원소는 무조건 max보다 크다.
 1. 답을 구한다.
# 문제를 풀며 배운 것
 Peek 할 때 오류가 나서 큐 마지막 값으로 큰 수를 넣었다. 다른 방법은 없었나?