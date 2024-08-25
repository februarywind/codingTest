# 올바른 괄호 (programmers Lv 1)
 ( 또는 ) 로만 이루어진 문자열 s가 주어졌을 때, 문자열 s가 올바른 괄호인지 구해야 한다.  
 입력 예 : "()()"  
 출력 예 : true
# 내가 푼 코드
 ```cs
  public bool solution(string s)
        {
            int open = 0;
            int close = 0;
            foreach (var item in s)
            {
                if (item == '(')
                    open++;
                else
                    close++;
                if (close > open)
                {
                    return false;
                }
            }
            return open == close ? true : false;
    }
 ```
# 풀이 방법
 1. 문자열을 순회하면서 ( 라면 open + 1 아니면 close + 1 한다.
 1. close가 더 많다면 false를 반환한다.
 1. 문자열 순회가 끝나고 open과 close의 수가 같다면 true를 반환하여 답을 구한다.
# 문제를 풀며 배운 것
 다른 다람의 풀이 중 s에서 ()를 찾아 제거하는 방식으로 답을 구한 사람도 있었다.