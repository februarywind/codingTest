# 웰컴 키트 (Baekjoon Silver 4)
 연필의 개수 n, 티셔츠 사이즈별 개수 배열, 한 번에 주문할 수 있는 개수 T, P가 주어졌을 때  
 티셔츠의 최소 주문 횟수와 연필의 최소 주문 횟수 + 나머지를 구해야 한다.  
 입력 예 : 23, [3 1 4 1 5 9], [5 7]  
 출력 예 : 7, 3, 2
# 내가 푼 코드
 ```cs
  static void Main(string[] args)
        {
            int answer = 0;
            int n = int.Parse(Console.ReadLine());
            int[] s = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
            int[] tp = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

            for (int i = 0; i < s.Length; i++)
            {
                int temp = s[i] / tp[0];
                answer += s[i] % tp[0] == 0 ? temp : temp + 1;
            }
            Console.WriteLine(answer);
            Console.WriteLine(n / tp[1] + " " + n % tp[1]);

        }
 ```
# 풀이 방법
 1. 티셔츠의 주문 횟수는 각 사이즈별 나머지가 있다면 최소 주문 횟수 +1 해서 구한다.
 1. 연필은 몫과 나머지를 계산해서 구한다.
# 문제를 풀며 배운 것
 c#은 별로 인기가 없나?