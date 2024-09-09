# 붙임성 좋은 총총이 (Baekjoon Silver 4)
 총총이와 만나는 사람은 무지개 댄스를 춘다.  
 사람 둘이 만나는 횟수 n과 만나는 기록이 주어질 때 무지개 댄스를 추는 사람을 구해야 한다.  
 입력 예 : 12  
 bnb2011 chansol  
chansol chogahui05  
chogahui05 jthis  
jthis ChongChong  
jthis jyheo98  
jyheo98 lms0806  
lms0806 pichulia  
pichulia pjshwa  
pjshwa r4pidstart  
r4pidstart swoon  
swoon tony9402  
tony9402 bnb2011  
 출력 예 : 10
# 내가 푼 코드
 ```cs
  static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> list = new List<string>() { "ChongChong" };
            for (int i = 0; i < n; i++)
            {
                string[] strings = Console.ReadLine().Split(" ");
                if (list.Contains(strings[0]))
                {
                    list.Add(strings[1]);
                }
                else if (list.Contains(strings[1]))
                {
                    list.Add(strings[0]);
                }
            }
            Console.WriteLine(list.Distinct().ToList().Count);
        }
 ```
# 풀이 방법
 1. 총총이가 있는 list를 만든다.
 1. 만나는 사람들을 입력받아 배열로 만든다.
 1. 각 값이 list에 있다면 그 반대 값을 list에 넣는다.
 1. 원소 값이 겹치는 경우를 대비하여 Distinct 하고 그 개수를 구한다.
# 문제를 풀며 배운 것
 중복을 허용하지 않는 리스트?인 HashSet을 사용하면 Distinct를 하지 않고 답을 구할 수 있다.  