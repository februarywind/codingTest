# 문자열 나누기 (programmers Lv 1)
 문자열 s가 입력되었을 때 첫 글자 x와 x가 아닌 글자의 개수가 같아졌을 때 문자열을 나눈다.  
 나눈 문자열을 제외하고 다시 반복하여 분해한 문자열의 개수를 구해야 한다.  
 입력 예 : "banana"  
 출력 예 : 3
# 내가 푼 코드
 ```cs
  public int solution(string s)
        {
            int answer = 0;
            int[] check = new int[2];
            Queue<char> queue = new Queue<char>(s);
            char first = queue.Peek();
            while (queue.Count > 0) 
            {
                if (queue.Count == 1)
                {
                    answer++;
                    break;
                }
                if (first == queue.Dequeue())
                {
                    check[0]++;
                }
                else
                {
                    check[1]++;
                }
                if (check[0] == check[1])
                {
                    queue.TryPeek(out first);
                    answer++;
                }
            }
            return answer;
    }
 ```
# 풀이 방법
 1. 문자열 s를 큐로 변환한다.
 2. 첫 번째 글자를 Peek로 구하여 저장하고 Dequeue를 반복하여 첫 글자와 아닌 글자 수를 구한다.
 3. 두 개수가 같아지면 첫 번째 글자를 바꾸고 answer에 1을 더하여 답을 구한다.
# 문제를 풀며 배운 것
 TryPeek를 써봐서 기분이 좋다.