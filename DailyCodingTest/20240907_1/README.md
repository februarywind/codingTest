# 프로세스 (programmers Lv 2)
 실행 대기 큐에 있는 프로세스의 중요도가 순서대로 담긴 배열 priorities와  
 몇 번째로 실행되는지 알고싶은 프로세스의 위치를 알려주는 location이 매개변수로 주어질 때  
 해당 프로세스가 몇 번째로 실행되는지 return 하도록 solution 함수를 작성해주세요.
 입력 예 : [2, 1, 3, 2], 2  
 출력 예 : 1
# 내가 푼 코드
 ```cs
  public int solution(int[] priorities, int location)
        {
            int answer = 0;
            int l = priorities[location];
            priorities[location] = 0;
            Queue<int> q = new Queue<int>(priorities);
            while (q.Count > 1) 
            {
                int temp = q.Dequeue();
                if (temp == 0)
                {
                    if (l >= q.Max())
                        return ++answer;
                    else
                        q.Enqueue(0);
                }
                else
                {
                    if (temp >= q.Max() && temp >= l)
                        answer++;
                    else
                        q.Enqueue(temp);
                }
            }
            return priorities.Length;
    }
 ```
# 풀이 방법
 1. 배열에 구하고자 하는 원소를 0으로 변경하고 그 값을 l에 저장한다.
 1. 배열을 큐로 바꾸고 순회하여 답을 구한다.
 1. 만약 q.Count가 1이라면 answer는 주어진 배열의 길이를 리턴한다.
# 문제를 풀며 배운 것
 KeyValuePair<int, int> keyValuePair = new KeyValuePair<int, int>(n, m);  
 위 메서드를 사용하여 문제를 해결한 사람도 있었다.  