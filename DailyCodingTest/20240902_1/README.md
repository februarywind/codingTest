# 할인 행사 (programmers Lv 2)
 원하는 제품을 나타내는 배열 want와 원하는 제품의 수량을 나타내는 배열 number, 할인하는 제품을 나타내는 배열 discount가 주어졌을 때  
 원하는 제품을 모두 할인받을 수 있는 회원 등록 날짜의 총 일수를 구해야 한다.
 입력 예 :  
 ["banana", "apple", "rice", "pork", "pot"],  
 [3, 2, 2, 2, 1],  
 ["chicken", "apple", "apple", "banana", "rice", "apple", "pork", "banana", "pork", "rice", "pot", "banana", "apple", "banana"]  
 출력 예 : 3
# 내가 푼 코드
 ```cs
  public int solution(string[] want, int[] number, string[] discount)
        {
            int answer = 0;
            Dictionary<string, int> dic = new Dictionary<string, int>();
            Queue<string> _want = new Queue<string>(10);
            Queue<string> temp = new Queue<string>(10);
            for (int i = 0; i < want.Length; i++)
            {
                for (int j = 0; j < number[i]; j++)
                {
                    _want.Enqueue(want[i]);
                }
                dic.Add(want[i], number[i]);
            }
            foreach (var item in discount)
            {
                temp.Enqueue(item);
                if (temp.Count == 10)
                {
                    for (int i = 0; i < want.Length; i++)
                    {
                        if (temp.Count(x => x == want[i]) != dic[want[i]])
                        {
                            temp.Dequeue();
                            break;
                        }
                    }
                    if (temp.Count == 10)
                    {
                        temp.Dequeue();
                        answer++;
                    }
                }
            }
            return answer;
    }
 ```
# 풀이 방법
 1. _want 큐를 만들어서 원하는 상품을 모두 넣고, 원하는 물건을 키로 개수를 값으로 하는 딕셔너리를 만든다.
 1. discount를 순회하며 temp에 한 개씩 넣고 10개가 됐을 때 temp에 개수와 dic의 개수를 비교하여 다르다면 Dequeue 한다.
 1. 만약 모두 개수가 같다면 answer에 1을 더하고 Dequeue 한다. 이를 반복하여 답을 구한다.
# 문제를 풀며 배운 것
 문제를 안 읽어서 물건을 모두 구할 수 있는 최소 날짜를 구하는 줄 알았다. 다음부터는 문제를 잘 읽도록 하자.