# 피보나치 수 (programmers Lv 1)
 2 이상의 n이 입력되었을 때, n 번째 피보나치 수를 1234567으로 나눈 나머지를 구해야 한다.  
 입력 예 : 3  
 출력 예 : 2
# 내가 푼 코드
 ```cs
  public int solution(int n)
        {
            int answer = 0;
            int[] temp = { 0, 1 };
            for (int i = 1; i < n; i++)
            {
                answer = temp[1];
                temp[1] = (temp[0] + temp[1]) % 1234567;
                temp[0] = (answer % 1234567);
            }
            return temp[1];
    }
 ```
# 풀이 방법
 1. answer에 임시로 temp[1]을 저장하고 answer[1]에 temp의 합 answer[0]에 임시 저장한 값을 넣어 피보나치를 구한다.
# 문제를 풀며 배운 것
 메모장 수학으로 풀었다. 이게 왜 되는지는 모른다. 변수 이름이 반대로 됐어