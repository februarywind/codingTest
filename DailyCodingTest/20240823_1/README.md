# 가장 많이 받은 선물 (programmers Lv 1)
 친구들의 이름을 담은 1차원 문자열 배열 friends 이번 달까지 친구들이 주고받은 선물 기록을 담은 1차원 문자열 배열 gifts가 주어졌을 때  
 다음달에 가장 많은 선물을 받는 친구가 받을 선물의 수를 구해야 한다.  
 입력 예 : ["muzi", "ryan", "frodo", "neo"], ["muzi frodo", "muzi frodo", "ryan muzi", "ryan muzi", "ryan muzi", "frodo muzi", "frodo ryan", "neo muzi"]  
 출력 예 : 2
# 내가 푼 코드
 ```cs
  public int solution(string[] friends, string[] gifts)
        {
            int answer = 0;
            Dictionary<string, List<string>> present = new Dictionary<string, List<string>>();
            Dictionary<string, int> presentIndex = new Dictionary<string, int>();

            foreach (var item in friends)
            {
                present.Add(item, new List<string>());
                presentIndex.Add(item, 0);
            }

            foreach (var item in gifts)
            {
                present[item.Split(' ')[0]].Add(item.Split(' ')[1]);
                presentIndex[item.Split(' ')[0]]++;
                presentIndex[item.Split(' ')[1]]--;
            }

            foreach (var item in friends)
            {
                int tmep = 0;
                foreach (var item1 in friends)
                {
                    if (present[item].Count(x => x == item1) == present[item1].Count(x => x == item))
                    {
                        tmep += presentIndex[item] > presentIndex[item1] ? 1 : 0;
                        continue;
                    }
                    if (present[item].Count(x => x == item1) > present[item1].Count(x => x == item))
                    {
                        tmep++;
                    }
                }
                answer = Math.Max(answer, tmep);
            }
            return answer;
    }
 ```
# 풀이 방법
 1. 선물 준 사람을 키로 받은 사람들을 값으로 하는 딕셔너리와 선물 지수를 담을 딕셔너리를 만든다.
 1. gifts를 순회하며 두 딕셔너리를 완성한다.
 1. Count 메서드를 활용해서 두 사람이 주고받은 선물의 개수를 구한다.
 1. 주고받은 선물의 개수가 같다면 선물 지수를 확인해서 item의 선물 지수가 크다면 temp에 1을 더한다.
 1. item이 준 선물이 더 많다면 temp에 1을 더한다.
 1. temp가 answer보다 크다면 answer에 temp를 저장해서 답을 구한다.
# 문제를 풀며 배운 것
와 1레벨 문제 다 풀었다 이제 나도 코딩고수?