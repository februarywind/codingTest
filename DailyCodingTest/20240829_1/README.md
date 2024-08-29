# 예상 대진표 (programmers Lv 1)
 게임 참가자 수 N, 참가자 번호 A, 경쟁자 번호 B가 매개변수로 주어질 때  
 처음 라운드에서 A번을 가진 참가자는 경쟁자로 생각하는 B번 참가자와 몇 번째 라운드에서 만나는지 구해야 한다.  
 입력 예 : 8, 4, 7  
 출력 예 : 3
# 내가 푼 코드
 ```cs
  public int solution(int n, int a, int b)
    {
        int answer = 1;
        while (n > 2)
        {
            if (Math.Min(a, b) > n / 2)
            {
                n /= 2;
                a -= n;
                b -= n;
                continue;
            }
            else if (Math.Max(a, b) <= n / 2)
            {
                n /= 2;
                continue;
            }
            else
            {
                int temp = 2;
                while (temp != n)
                {
                    temp *= 2;
                    answer++;
                }
                break;
            }
        }
        return answer;
    }
 ```
# 풀이 방법
 1. a, b 중 작은 값이 n의 절반보다 크다면 n을 2로 나누고 a, b에 그 값을 뺀다.
 1. a, b 중 큰 값이 n의 절반보다 작다면 n을 2로 나눈다.
 1. 만약 두 조건 모두 맞지 않는다면 a, b는 n 강의 마지막 라운드에서 만난다.
# 문제를 풀며 배운 것
 다른 사람의 풀이를 보니 정말 가지각색으로 풀었다. 나도 풀었으니 오케이다.