# 둘만의 암호 (programmers Lv 1)
 문자열 s를 skip에 있는 알파벳을 제외하고 index 만큼 건너뛴 문자열을 구해야 한다.  
 입력 예 : "aukks", "wbqd", 5  
 출력 예 : "happy"
# 내가 푼 코드
 ```cs
  public string solution(string s, string skip, int index)
        {
            char[] skipChar = skip.ToCharArray();
            char[] chars = s.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                for (int j = 0; j < index; j++)
                {
                    chars[i]++;
                    if (chars[i] > 'z')
                    {
                        chars[i] = 'a';
                    }
                    if (Array.IndexOf(skipChar, chars[i]) != -1)
                    {
                        j--;
                    }
                }
            }
            return new string(chars);
    }
 ```
# 풀이 방법
 1. 문자열 s와 skip을 char[]로 변환한다.
 2. s를 index 만큼 반복하여 더할 때 더한 문자가 skip에 있다면 한 번 더 더한다.
 3. 문자가 z보다 커졌을 때 a로 바꾼다.
# 문제를 풀며 배운 것
 무식한게 최고야