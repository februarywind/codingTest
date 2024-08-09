# 문자열 내 마음대로 정렬하기 (programmers Lv 1)
 문자열로 구성된 리스트 strings와, 정수 n이 주어졌을 때,  
 각 문자열의 인덱스 n번째 글자를 기준으로 오름차순 정렬해야 한다.  
 입력 예 : ["sun", "bed", "car"]  
 출력 예 : ["car", "bed", "sun"]  
# 내가 푼 코드
 ```cs
  public string[] solution(string[] strings, int n)
        {
            List<string> list = new List<string>(strings.Length) { };
            bool check= false;
            Array.Sort(strings);
            Array.Reverse(strings);

            for (int i = 0; i < strings.Length; i++)
            {
                check = false;
                for (int j = 0; j < list.Count; j++)
                {
                    if (strings[i][n] <= list[j][n])
                    {
                        list.Insert(j, strings[i]);
                        check = true;
                        break;
                    }
                }
                if (!check)
                {
                    list.Add(strings[i]);
                }
            }

            return list.ToArray();
        }
 ```
# 풀이 방법
 1. 빈 리스트를 만들고 n 번째 글자가 같은 문자열이 있을 때 정렬되도록 입력 받은 배열을 역순 정렬 한다.  
 2. 입력받은 문자열의 n 번째 글자가 리스트의 n 번째 글자보다 작다면 해당 자리에 insert 한다.
 3. 해당 문자열의 n 번째 글자가 리스트의 모든 n 번째 글자보다 크다면 리스트의 마지막에 Add 한다.
 
# 문제를 풀며 배운 것
 Array.Sort(strings);  
 strings.OrderBy(c => c[n]).ToArray();  
 이 두 줄로 해결이 가능했다.  
 앞으로 정렬할 때 OrderBy에 대해 한번 찾아봐야겠다.