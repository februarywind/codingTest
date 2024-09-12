# 단어 정렬 (Baekjoon Silver 5)
 알파벳 소문자로 이루어진 N 개의 단어가 주어졌을 때 길이가 짧은 것부터 정렬한 후  
 길이가 같다면 알파벳순으로 정렬해야 한다.  
 입력 예 : int N, string  
 출력 예 : string
# 내가 푼 코드
 ```cs
  static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] strings = new string[n];
            for (int i = 0; i < n; i++)
                strings[i] = Console.ReadLine();

            var answer = strings.Distinct().OrderBy(x => x.Length).ThenBy(x => x);
            foreach (var item in answer)
                Console.WriteLine(item);

            //Console.WriteLine(string.Join("\n",
            //    strings.Distinct()
            //    .OrderBy(x => x.Length)
            //    .ThenBy(x => x)));
        }
 ```
# 풀이 방법
 1. 주어진 단어들을 배열에 넣는다.
 1. 배열의 중복을 제거하고 OrderBy로 길이 순으로 정렬한 후 ThenBy로 사전 순으로 정렬하여 답을 구한다.
# 문제를 풀며 배운 것
 주석 처리된 부분은 다른 사람의 코드를 보고 작성한 것이다.  
 내 코드와 다르게 한 번의 WriteLine으로 정답을 출력하기 때문에 소모 시간이 적지만  
 정답을 하나의 문자열로 저장하기 때문에 메모리 소모량이 크다. 