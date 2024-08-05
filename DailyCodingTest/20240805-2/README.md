# 옹알이 (2) (programmers Lv 1)
 아이가 할 수 있는 발음은 "aya", "ye", "woo", "ma" 뿐이다.  
 아이는 연속해서 같은 발음은 말 하지 못한다. 예) ayaaya  
 입력받은 문자열 배열 중 이 아이가 발음 할 수 있는 단어의 개수를 출력해야 한다.  
 입력 예 : ["ayaye", "uuu", "yeye", "yemawoo", "ayaayaa"]  
 출력 예 : 2  
# 내가 푼 코드
 ```cs
  public int solution(string[] babbling) {
        int answer = 0;
        string[] ongal = { "aya", "ye", "woo", "ma" };
        for (int i = 0; i < babbling.Length; i++)
        {
            List<string> list = new List<string>();
            string temp = "";
            foreach (var item in babbling[i])
            {
                temp += item;
                if (Array.IndexOf(ongal, temp) != -1)
                {
                    if (!(list.Count > 0 && list[list.Count - 1] == temp))
                    {
                        list.Add(temp);
                        temp = "";
                    }
                }
            }
            temp = "";
            foreach (var item in list)
            {
                temp += item;
            }
            if (babbling[i] == temp)
            {
                answer++;
            }
        }
        return answer;
    }
 ```
# 풀이 방법
 1. 할 수 있는 발음을 배열로 만든다.
 2. 입력 받은 문자열 만큼 반복한다.
 3. 각각 문자열을 foreach문으로 순회한다.
 4. 각각 char값을 temp에 저장하고 temp가 발음 할 수 있고 이전 발음과 다르면 list에 추가한다.
 5. list와 babbling[i]가 같다면 answer++를 한다.
