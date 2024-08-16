# 로또의 최고 순위와 최저 순위 (programmers Lv 1)
 몇개의 번호가 정해지지 않은 로또 번호의 최고 순위와 최저 순위를 구해야 한다.  
 입력 예 : [44, 1, 0, 0, 31, 25], [31, 10, 45, 1, 6, 19]  
 출력 예 : [3, 5]
# 내가 푼 코드
 ```cs
  public int[] solution(int[] lottos, int[] win_nums)
        {
            int[] answer = new int[2];
            int[] win = new int[] { 6, 6, 5, 4, 3, 2, 1 };

            int a = 0;

            foreach (var item in lottos)
            {
                for (int i = 0; i < 6; i++)
                {
                    if (win_nums[i] == item)
                    {
                        a++;
                    }
                }
            }
            answer[1] = win[a];
            a += lottos.Count(x => x == 0);
            answer[0] = win[a];
            return answer;
    }
 ```
# 풀이 방법
 1. foreach 문과 for 문으로 몇 개의 번호가 맞았는지 확인한다.
 2. 그 개수가 로또의 최저 순위이므로 맞은 개수의 인덱스에 원소값으로 등수가 들어간 배열인 win을 answer[1]에 넣는다.
 3. 주어진 번호의 0의 개수가 더 맞을 수 있는 개수이므로 a에 0의 개수를 더하고 answer[0] = win[a];해서 답을 구한다.
# 문제를 풀며 배운 것
 흠 로또 1등 되면 좋겠다.