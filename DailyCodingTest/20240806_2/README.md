# 삼총사 (programmers Lv 1)
 정수형 배열이 입력 값으로 주어진다.  
 3개 원소 값의 합이 0이 되는 조합의 가짓수를 출력하는 문제다.  
 입력 예 : [-2, 3, 0, 2, -5]  
 출력 예 : 2  
# 내가 푼 코드
 ```cs
  public int solution(int[] number)
        {
            int answer = 0;
            for (int i = 0; i < number.Length - 2; i++)
            {
                for (int j = i + 1; j < number.Length - 1; j++)
                {
                    for (int k = j + 1; k < number.Length; k++)
                    {
                        if (number[i] + number[j] + number[k] == 0)
                        {
                            answer++;
                        }
                    }
                }
            }
            return answer;
    }
 ```
# 풀이 방법
 1. 반복반복반복문으로 해결했다.  
# 다른 사람의 풀이로 배운 것
  다들 비슷하게 푼 것 같다.

 