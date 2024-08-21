# 달리기 경주 (programmers Lv 1)
 선수들의 이름이 1등부터 현재 등수 순서대로 담긴 문자열 배열과 선수가 한 명을 제칠 때마다 부른 이름을 담은 문자열 배열이 매개변수로 주어질 때,  
 경주가 끝났을 때 선수들의 이름을 1등부터 등수 순서대로 배열에 담아 return 하는 solution 함수를 완성해야 한다.
 입력 예 : "2022.05.19", ["A 6", "B 12", "C 3"], ["2021.05.02 A", "2021.07.01 B", "2022.02.19 C", "2022.02.20 C"]  
 출력 예 : [1, 3]
# 내가 푼 코드
 ```cs
  public string[] solution(string[] players, string[] callings)
        {
            string[] answer = new string[players.Length];
            Dictionary<string, int> runner = new Dictionary<string, int>();
            Dictionary<int, string> rank = new Dictionary<int, string>();
            for (int i = 0; i < players.Length; i++)
            {
                runner.Add(players[i], i);
                rank.Add(i, players[i]);
            }
            foreach (var item in callings)
            {
                rank[runner[item]] = rank[runner[item] - 1];
                rank[runner[item] - 1] = item;

                runner[rank[runner[item]]]++;
                runner[item]--;
            }

            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] = rank[i];
            }

            return answer;
    }
 ```
# 풀이 방법
 1. 선수의 이름이 키 등수가 값으로 있는 딕셔너리와 선수의 등수가 키 이름이 값으로 있는 딕셔너리를 만든다.
 1. callings을 순회 하면서 여차여차 열심히 알잘딱하게 두 배열을 바꿔서 문제를 해결한다.
# 문제를 풀며 배운 것
 아오 복잡해 머리아파