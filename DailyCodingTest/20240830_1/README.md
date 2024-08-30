# 귤 고르기 (programmers Lv 2)
 한 상자에 담으려는 귤의 개수 k와 귤의 크기를 담은 배열 tangerine이 매개변수로 주어집니다.  
 귤 k개를 고를 때 크기가 서로 다른 종류의 수의 최솟값을 구해야 한다. 
 입력 예 : 6. [1, 3, 2, 5, 4, 5, 2, 3]  
 출력 예 : 3
# 내가 푼 코드
 ```cs
  public int solution(int k, int[] tangerine)
        {
            int answer = 0;
            Dictionary<int, int> map = new Dictionary<int, int>();
            foreach (var item in tangerine)
            {
                if (map.ContainsKey(item))
                {
                    map[item]++;
                }
                else
                {
                    map.Add(item, 1);
                }
            }
            List<int> list = new List<int>(map.Values);
            list.Sort();
            list.Reverse();
            foreach (var item in list)
            {
                k -= item;
                answer++;
                if (k <= 0)
                {
                    break;
                }
            }
            return answer;
    }
 ```
# 풀이 방법
 1. tangerine의 크기를 key로 개수를 value로 하는 딕셔너리를 만든다.
 1. 딕셔너리의 값을 리스트에 넣어 역순 정렬한다.
 1. k에 리스트의 값들을 빼면서 answer에 1을 더한다 k <= 0 일 때 순회를 종료하여 답을 구한다.
# 문제를 풀며 배운 것
 ContainsKey를 사용하는 것보다 TryAdd를 사용하여 더 효율적인 코드를 작성할 수 있다.