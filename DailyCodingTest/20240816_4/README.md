# 대충 만든 자판 (programmers Lv 1)
 자판 keymap와 입력해야 할 문자열 targets가 주어졌을 때 해당 문자열을 입력하기 위한 최소 횟수를 구해야 한다.  
 입력 예 : ["ABACD", "BCEFD"], ["ABCD","AABB"]  
 출력 예 : [9, 4]
# 내가 푼 코드
 ```cs
  public int[] solution(string[] keymap, string[] targets)
        {
            int[] answer = new int[targets.Length];
            for (int i = 0; i < targets.Length; i++)
            {
                foreach (var item in targets[i])
                {
                    int temp = 100;
                    for (int j = 0; j < keymap.Length; j++)
                    {
                        int index = Array.IndexOf(keymap[j].ToCharArray(), item);
                        if (index < temp && index != -1)
                        {
                            temp = index;
                        }
                    }
                    if (temp == 100)
                    {
                        answer[i] = -1;
                        break;
                    }
                    answer[i] += (temp + 1);
                }
            }
            return answer;
    }
 ```
# 풀이 방법
 1. 입력해야 할 string[] targets의 각각 문자들을 순회한다.
 2. 각각의 문자들을 모든 keymap에 IndexOf를 통해 가장 빠르게 입력할 수 있는 횟수를 구하여 answer[i]에 더한다.
 3. 만약 입력할 수 있는 버튼이 없다면 -1을 answer[i]에 입력한다.
# 문제를 풀며 배운 것
 string은 IndexOf에 입력할 수 없다. 그래서 char[]로 변환해서 구했다.