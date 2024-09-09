# 통계학 (Baekjoon Silver 4)
 N 개의 수가 주어졌을 때 해당 수들의 산술평균, 중앙값, 최빈값, 범위를 구해야 한다.  
 입력 예 : 5, 1, 3, 8, -2, 2  
 출력 예 : 2, 2, 1, 10
# 내가 푼 코드
 ```cs
  static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int[] ints = new int[n];
            for (int i = 0; i < n; i++)
            {
                ints[i] = int.Parse(Console.ReadLine());
                if (!dic.TryAdd(ints[i], 1))
                {
                    dic[ints[i]]++;
                }
            }
            Array.Sort(ints);
            double temp = Math.Round((double)ints.Sum() / ints.Length);
            Console.WriteLine(temp == 0 ? 0 : temp);
            Console.WriteLine(ints[ints.Length / 2]);
            List<int> list = new List<int>();
            int m = dic.Values.Max();
            foreach (var item in dic)
            {
                if (item.Value == m)
                {
                    list.Add(item.Key);
                }
            }
            list.Sort();
            Console.WriteLine(list.Count > 1 ? list[1] : list[0]);
            Console.WriteLine(ints.Max() - ints.Min());
        }
 ```
# 풀이 방법
 1. N 개의 숫자를 배열에 입력받을 때 최빈값을 구하기 위해 해당 값을 키로 하는 딕셔너리를 만든다.
 1. 입력받은 수들을 모두 더해서 나누고 Round로 반올림해 산술평균을 구한다.
 1. 배열의 길이에 2를 나눠 중앙값을 구한다.
 1. 배열 중 가장 같은 수가 많은 값을 딕셔러리.Max로 구한다. 리스트를 만들어 최빈값들을 구한다.
 1. 가장 큰 수 - 가장 작은 수로 범위를 구한다.
# 문제를 풀며 배운 것
 평균을 구할 때 -0이 나와서 수정했다.  
 평균을 구할 때 float을 반올림했더니 오답이 나서 double로 변경했다. 정확도 차이가 꽤 심한 것 같다.