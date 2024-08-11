# 카드 뭉치 (programmers Lv 1)
 단어가 적혀있는 두 개의 카드 뭉치가 주어졌을 때  
 카드를 순서대로 사용해서 특정 단어의 배열을 만들 수 있는지 확인해야 한다.  
 카드는 사용하지 않고 넘길 수는 없다.  
 입력 예 : ["i", "drink", "water"], ["want", "to"],	["i", "want", "to", "drink", "water"]  
 출력 예 : "Yes"
# 내가 푼 코드
 ```cs
  public string solution(string[] cards1, string[] cards2, string[] goal)
        {
            Queue<string> queue1 = new Queue<string>(cards1);
            Queue<string> queue2 = new Queue<string>(cards2);
            Queue<string> queue3 = new Queue<string>(goal);
            queue1.Enqueue("END");
            queue2.Enqueue("END");
            for (int i = 0; i < goal.Length; i++)
            {
                if (queue1.Peek() == queue3.Peek())
                {
                    queue1.Dequeue();
                    queue3.Dequeue();
                }
                else if (queue2.Peek() == queue3.Peek())
                {
                    queue2.Dequeue();
                    queue3.Dequeue();
                }
                else
                {
                    return "No";
                }
            }

            return "Yes";
        }
 ```
# 풀이 방법
 1. 입력을 모두 큐로 바꾼다.
 2. 만들어야 하는 단어 목록 queue3의 Peek가 queue1 혹은 queue2의 Peek와 같다면 해당하는 두 큐에 Dequeue 하여 삭제한다.
 3. queue의 원소가 모두 제거되어 생기는 오류를 막기 위해서 각 큐의 마지막에 "END"문자열을 넣어 오류를 방지했다.
 # 문제를 풀며 배운 것
  다 풀고 보니 goal을 굳이 큐로 만들 필요가 없었다. for 문을 쓰고 있으니 그냥 goal[i]로 했어야 했다.  
