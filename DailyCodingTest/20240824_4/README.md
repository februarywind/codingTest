# JadenCase 문자열 만들기 (programmers Lv 1)
 문자열 s가 주어졌을 때, s를 JadenCase로 바꾼 문자열을 구해야 한다.  
 입력 예 : "3people unFollowed me"  
 출력 예 : "3people Unfollowed Me"
# 내가 푼 코드
 ```cs
  public string solution(string s)
        {
            s = s.ToLower();
            StringBuilder sb = new StringBuilder(s);
            sb[0] = char.ToUpper(sb[0]);
            for (int i = 0; i < sb.Length - 1; i++)
            {
                if (sb[i] == ' ')
                {
                    sb[i + 1] = char.ToUpper(sb[i + 1]);
                }
            }
            return sb.ToString();
    }
 ```
# 풀이 방법
 1. s를 소문자로 바꾸고 StringBuilder로 만든다.
 1. s의 첫 글자를 대문자로 바꾼다.
 1. 공백 다음 글자를 대문자로 바꿔 답을 구한다.
# 문제를 풀며 배운 것
 StringBuilder냐 char array냐 그것이 문제로다.