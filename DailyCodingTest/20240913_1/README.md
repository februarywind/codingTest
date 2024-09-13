# 수 찾기 (Baekjoon Silver 5)
 N 배열이 주어졌을 때 M 배열의 값이 N 배열에 있다면 1을 아니면 0을 출력해야 한다.
 입력 예 : [4 1 5 2 3], [1 3 7 9 5]  
 출력 예 : 1 1 0 0 1
# 내가 푼 코드
 ```cs
  static void Main(string[] args)
        {
            Console.ReadLine();
            HashSet<long> N = Array.ConvertAll(Console.ReadLine().Split(), long.Parse).ToHashSet();
            Console.ReadLine();
            long[] Q = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);

            char[] answer = new char[Q.Length];
            for (int i = 0; i < Q.Length; i++)
            {
                if (N.Contains(Q[i]))
                {
                    answer[i] = '1';
                }
                else
                {
                    answer[i] = '0';
                }
            }
            Console.WriteLine(string.Join('\n', answer));
        }
 ```
# 풀이 방법
 1. 입력값을 HashSet으로 저장한다.
 1. 찾아야 할 값을 순회하여 Contains로 확인하고 답을 출력한다.
# 문제를 풀며 배운 것
 HashSet의 Contains는 매우 빠르다.  
 ConvertAll이 Select 보다 빠르다.