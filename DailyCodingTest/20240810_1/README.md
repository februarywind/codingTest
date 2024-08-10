# 최대공약수와 최소공배수 (programmers Lv 1)
 두 수를 입력받아 두 수의 최대공약수와 최소공배수를 반환하는 함수를 만들어야 한다.  
 입력 예 : 3, 12  
 출력 예 : [3, 12]  
# 내가 푼 코드
 ```cs
  public int[] solution(int n, int m)
        {
            int[] answer = new int[2];
            for (int i = n; i > 0; i--)
            {
                if (m % i == 0 && n % i == 0)
                {
                    answer[0] = i;
                    break;
                }
            }
            int a = n;
            int b = m;
            while (a != b)
            {
                if (a < b)
                {
                    a += n;
                }
                else
                {
                    b += m;
                }
            }

            answer[1] = a;
            return answer;
    }
 ```
# 풀이 방법
 1. n부터 0까지 두 수를 나눈다. 두 수가 동시에 나누어떨어지면 그 수가 최대공약수다.
 2. n과 m을 복제한 a, b를 만들어 두 수가 다르다면 각각 n, m을 더한다. 두 수가 같아지면 그 수가 최소공배수다.
# 문제를 풀며 배운 것
 최대공약수와 최소공배수를 구하는 방법을 배웠다.  
 다른 사람의 풀이로 n * m / 최대공약수 == 최소공배수 임을 알게 되었다.  
 내가 수학을 못한다는 것을 배웠다.  
