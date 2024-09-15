# 듣보잡 (Baekjoon Silver 4)
 두개의 명단이 주어졌을 때 겹치는 이름을 출력해야 한다.  
 입력 예 : 각 명단의 사람 수(3, 4), 그 합의 이름들  
 출력 예 : 겹치는 인원, 그 이름들
# 내가 푼 코드
 ```cs
  static void Main(string[] args)
        {
            HashSet<string> set1 = new HashSet<string>();
            HashSet<string> set2 = new HashSet<string>();
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            for (int i = 0; i < n[0]; i++)
                set1.Add(Console.ReadLine());
            for (int i = 0; i < n[1]; i++)
                set2.Add(Console.ReadLine());
            set1.IntersectWith(set2);
            set1 = set1.OrderBy(x => x).ToHashSet();
            Console.WriteLine(set1.Count);
            Console.WriteLine(string.Join('\n', set1));
        }
 ```
# 풀이 방법
 1. 두개의 해시셋을 만들어서 각 명단의 이름을 저장한다.
 1. IntersectWith으로 set1을 교집합으로 만든다.
 1. OrderBy로 정렬하고 정답을 출력한다.
# 문제를 풀며 배운 것
 해시셋은 편리한 기능이 많다.