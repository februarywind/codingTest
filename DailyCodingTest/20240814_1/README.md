# 소수 만들기 (programmers Lv 1)
 주어진 숫자 중 3개를 더해서 만들 수 있는 소수의 개수를 출력해야 한다.  
 입력 예 : [1,2,3,4]  
 출력 예 : 1
# 내가 푼 코드
 ```cs
  public int solution(int[] nums)
        {
            int answer = 0;
            for (int i = 0; i < nums.Length - 2; i++)
            {
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        int temp = nums[i] + nums[j] + nums[k];
                        answer++;
                        for (int i1 = 2; i1 < temp; i1++)
                        {
                            if (temp % i1 == 0)
                            {
                                answer--;
                                break;
                            }
                        }
                    }
                }
            }

            return answer;
    }
 ```
# 풀이 방법
 1. 반복반복반복반복문으로 풀었다.  
# 문제를 풀며 배운 것
 무식한게 최고야