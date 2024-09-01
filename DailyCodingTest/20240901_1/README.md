# 괄호 회전하기 (programmers Lv 2)
 문자열 s가 주어졌을 때 왼쪽으로 1칸씩 s.Length 번 밀었을 때 몇 번 올바른 괄호가 되는지 구해야 한다.
 입력 예 : "[](){}"  
 출력 예 : 3
# 내가 푼 코드
 ```cs
  public int solution(string s)
        {
            char[] open = { '(', '{', '[' };
            char[] close = { ')', '}', ']' };
            int len = s.Length;
            StringBuilder sb = new StringBuilder(s);
            int answer = 0;
            for (int i = 0; i < len; i++)
            {
                Stack<char> temp = new Stack<char>(len);
                answer++;
                for (int j = 0; j < len; j++)
                {
                    int n = (j + i) % len;
                    if (Array.IndexOf(open, sb[n]) != -1)
                    {
                        temp.Push(sb[n]);
                    }
                    else if (temp.Count == 0 || Array.IndexOf(open, temp.Peek()) != Array.IndexOf(close, sb[n]))
                    {
                        answer--;
                        break;
                    }
                    else
                    {
                        temp.Pop();
                    }
                    if (j == len - 1 && temp.Count != 0)
                    {
                        answer--;
                    }
                }
            }
            return answer;
    }
 ```
# 풀이 방법
 1. 반복문을 통해 s.Legnth 번 반복하면서 (j + i) % len으로 왼쪽으로 밀어버린 것과 같은 인덱스를 구한다.
 1. 현재 문자가 open이라면 stack에 넣는다.
 1. 현재 문자가 close고 stack의 Peek와 다를 때 answer--하고 반복을 종료한다.
 1. 연재 문자가 close고 stack의 Peek와 같다면 stack.Pop 한다.
# 문제를 풀며 배운 것
 뭔가 코드가 안 예쁘다 더 신경 써서 해봐야겠다. 내일 부터