# 기사단원의 무기 (programmers Lv 1)
 1부터 number까지의 수의 약수를 구하고 모두 더하되 limit보다 큰 값은 power로 바꿔 더한다.  
 입력 예 : 5, 3, 2  
 출력 예 : 10  
# 내가 푼 코드
 ```cs
  public static int solution(int number, int limit, int power)
        {
            int[] answer = new int[number];
            answer[0] = 1;
            for (int i = 2; i <= number; i++)
            {
                int num = 0;
                for (int j = 1; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        num++;
                    }
                }
                if (Math.Sqrt(i) % 1 == 0)
                {
                    num += num - 1;
                }
                else
                {
                    num += num;
                }
                answer[i - 1] = num;
            }
            int b = answer.Count(x => x > limit);
            answer = answer.Where(x => x <= limit).ToArray();
            return answer.Sum() + b * power;
        }
 ```
# 풀이 방법
 1. 약수가 1개인 1을 answer에 넣고 2부터 number까지 약수를 구한다.
 2. 약수를 구할 때 그 수의 제곱근까지만 구하면 나머지는 그 개수와 같다. 하지만 완전제곱수는 예외로 약수가 홀수개이다.
 Math.Sqrt(i) % 1 == 0로 완전제곱수를 구하여 num - 1을 더한다.
 3. Count메서드로 limit보다 큰 값의 개수를 구한다.
 4. Where메서드로 answer를 limit보다 작거나 같은 값만 남긴다.
 5. answer.Sum() + b * power;로 답을 구한다.
 # 문제를 풀며 배운 것
 문제 예제에 약수를 배열로 만들어 푸는 것을 보고 그냥 멍 때리면서 똑같이 만들어 버렸다.  
 그냥 정수형 answer 변수를 만들고 num을 더하면 되잖아 뭐하니 나야  
 answer += (num > limit) ? power : num;