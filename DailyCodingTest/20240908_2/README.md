# 인사성 밝은 곰곰이 (Baekjoon Silver 4)
 새로운 유저가 채팅방에 들어오면 채팅방에 ENTER가 출력된다.  
 이때 각 유저가 쓰는 첫 번째 채팅은 인사하는 곰돌이 이모티콘이다.  
 채팅의 개수 n과 채팅들이 주어졌을 때 이모티콘의 개수를 구해야 한다.
 입력 예 : 7 ENTER pjshwa chansol chogahui05 ENTER pjshwa chansol  
 출력 예 : 5
# 내가 푼 코드
 ```cs
  static void Main(string[] args)
        {
            int answer = 0;
            int n = int.Parse(Console.ReadLine());
            string[] strings = new string[n+1];
            List<string> list = new List<string>();
            for (int i = 0; i < n; i++)
            {
                strings[i] = Console.ReadLine();
            }
            strings[n] = "ENTER";
            foreach (var item in strings)
            {
                if (item == "ENTER")
                {
                    answer += list.Distinct().Count();
                    list.Clear();
                }
                else
                {
                    list.Add(item);
                }
            }
            Console.WriteLine(answer);
        }
 ```
# 풀이 방법
 1. 입력받은 채팅을 배열에 넣는다.
 1. 배열을 순회하며 각 원소가 "ENTER"가 아니라면 list에 넣는다.
 1. "ENTER"라면 answer에 list에 중복을 제거하고 남은 개수를 더한 후 list를 초기화한다.
# 문제를 풀며 배운 것
 입력과 처리를 동시에 했다면 더 간결한 코드가 됐을것 같다.