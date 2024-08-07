# 3진법 뒤집기 (programmers Lv 1)
 정수값이 입력으로 주어진다.  
 해당 값을 3진법으로 변환한 후  
 변환값을 뒤집어 다시 10진법으로 출력해야 한다.  
 입력 예 : 45(3진법: 1200)  
 출력 예 : 7  
# 내가 푼 코드
 ```cs
  public int solution(int n) {
        int answer = 0;
        List<int> list = new List<int>();
        while (n > 0)
        {
            list.Add(n % 3);
            n /= 3;
        }
        for (int i = 0; i < list.Count; i++)
        {
            answer += list[i] * (int)Math.Pow(3, list.Count - 1 - i);
        }
        return answer;
    }
 ```
# 풀이 방법
 1. 정수를 n으로 나누고 그 나머지들을 역순으로 작성하면 n진법 표현으로 바꿀 수 있다.
 2. 리스트에 순서대로 삽입하고 앞에서부터 3의 list.Count - 1 제곱을 하여 answer에 더한다.
# 문제를 풀며 배운 것
  Math.Pow는 double로 반환된다.  
  진법 변환하는 방법을 정확하게 알았다.  

 