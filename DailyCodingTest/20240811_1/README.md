# 콜라 문제 (programmers Lv 1)
 빈병 a개를 가져다주면 골라 b병을 주는 마트가 있을때  
 빈병 n개를 가져다주면 몇병의 콜라를 받을 수 있는지 구해야 한다.  
 입력 예 : 2, 1, 20  
 출력 예 : 19  
# 내가 푼 코드
 ```cs
  public int solution(int a, int b, int n)
        {
            int answer = 0;
            while (n >= a)
            {
                n -= (a - b);
                answer += b;
            }
            return answer;
    }
 ```
# 풀이 방법
 1. a 병을 주면 어차피 b 만큼 새로운 병이 생기기 때문에 n -= (a - b)를 반복한다.
 2. 반복할 때마다 answer에 b를 더해서 답을 구한다.
# 문제를 풀며 배운 것
 다른 사람들과 다르게 풀었지만 간결하게 푼 것 같아서 기분이가 좋다.