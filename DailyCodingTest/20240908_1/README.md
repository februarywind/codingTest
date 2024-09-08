# 약수 (Baekjoon Bronze 1)
 임의의 수 n의 모든 약수가 주어졌을때 n을 구해야 한다.  
 입력 예 : "6", "3 4 2 12 6 8"  
 출력 예 : 24
# 내가 푼 코드
 ```cs
  static void Main(string[] args)
        {
            Console.ReadLine();
            int[] ints = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
            Array.Sort(ints);
            Console.WriteLine(ints[0] * ints.Last());
        }
 ```
# 풀이 방법
 1. 첫 번째 입력을 무시하고 약수들을 Select 메서드로 int[] 형으로 바꾼다.
 1. 정렬하고 가장 큰 수와 가장 작은 수를 곱하면 n을 구할 수 있다.
# 문제를 풀며 배운 것
 Select 메서드의 출력값인 IEnumerable의 max 값과 min 값으로 해결할 수 있었다. 