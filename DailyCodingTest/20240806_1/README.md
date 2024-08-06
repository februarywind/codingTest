# 햄버거 만들기 (programmers Lv 1)
 햄버거를 만들기 위해서 빵(1), 야채(2), 고기(3), 빵(1) 이 필요하다.  
 입력받은 배열에서 1231이 연속되면 햄버거를 만들 수 있다.  
 배열에서 사용한 재료는 없는 걸로 판단한다.  
 입력 예 : [2, 1, 1, 2, 3, 1, 2, 3, 1]  
 출력 예 : 2  
# 내가 푼 코드
 ```cs
  public int solution(int[] ingredient)
        {
            int answer = 0;
            Stack<int> stack = new Stack<int>(ingredient.Length);
            int[] ints = new int[4];
            int[] answers = { 1, 2, 3, 1 };
            foreach (var item in ingredient)
            {
                stack.Push(item);
                if (stack.Count > 3)
                {
                    ints[0] = stack.ElementAt(3);
                    ints[1] = stack.ElementAt(2);
                    ints[2] = stack.ElementAt(1);
                    ints[3] = stack.ElementAt(0);
                }

                if (Enumerable.SequenceEqual(ints, answers))
                {
                    answer++;
                    for (int i = 0; i < 4; i++)
                    {
                        stack.Pop();
                    }
                    ints[0] = -1;
                }
            }
            return answer;
    }
 ```
# 풀이 방법
 1. 스택을 만들고 입력받은 배열을 순서대로 Push 한다.
 2. 스택의 크기가 4 이상일 때 배열에 스택의 앞 4개 원소를 저장한다.
 3. Enumerable.SequenceEqual(ints, answers) 메서드로 배열의 원소가 1231이면 answer++;하고 Pop로 스택 앞 4개 원소를 삭제한다.
# 다른 사람의 풀이로 배운 것
 해당 문제를 리스트로 해결할 수 있었다.  
 list.RemoveRange(index, count); 해당 메서드로 배열의 특정 부분을 삭제할 수 있다.  
 stack.ElementAt();를 사용할 바에 리스트를 사용하는 게 나았을 것 같다.  

 