# 영어 끝말잇기 (programmers Lv 1)
 사람의 수 n과 사람들이 순서대로 말한 단어 words 가 매개변수로 주어질 때  
 가장 먼저 탈락하는 사람의 번호와 그 사람이 자신의 몇 번째 차례에 탈락하는지를 구해야 한다.  
 입력 예 : 3, ["tank", "kick", "know", "wheel", "land", "dream", "mother", "robot", "tank"]  
 출력 예 : [3, 3]
# 내가 푼 코드
 ```cs
  public int[] solution(int n, string[] words)
        {
            int[] answer = new int[2];
            Queue<string> queue = new Queue<string>(words);
            Stack<string> stack = new Stack<string>(queue.Count);
            bool t = false;
            while (queue.Count > 0)
            {
                if (!stack.Contains(queue.Peek()))
                {
                    stack.Push(queue.Dequeue());
                    if (queue.Count == 0)
                    {
                        break;
                    }
                }
                else
                {
                    t = true;
                }
                if (stack.Peek().Last() != queue.Peek()[0] || t)
                {
                    answer[0] = (stack.Count % n) + 1;
                    answer[1] = (stack.Count / n) + 1;
                    break;
                }
            }
            return answer;
    }
 ```
# 풀이 방법
 1. 입력된 단어를 큐로 변환하고 말한 단어들을 모아놓을 스택을 만든다.
 1. 입력 단어들을 순회하면서 이미 말한 단어거나 끝말이 다를 때 스택의 카운트로 답을 구한다.
# 문제를 풀며 배운 것
 아니 왜 이렇게 풀었지 if 문 두 개를 ||로 묶으면 되는 거였잖아 완전 바보바보잖아