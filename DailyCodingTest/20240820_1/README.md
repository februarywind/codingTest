# 개인정보 수집 유효기간 (programmers Lv 1)
 약관 종류별 수집 유효기간과 수집 일이 주어졌을 때 유효기간이 지나 파기해야 할 번호를 구해야 한다.  
 입력 예 : "2022.05.19", ["A 6", "B 12", "C 3"], ["2021.05.02 A", "2021.07.01 B", "2022.02.19 C", "2022.02.20 C"]  
 출력 예 : [1, 3]
# 내가 푼 코드
 ```cs
  public int[] solution(string today, string[] terms, string[] privacies)
        {
            List<int> answer = new List<int>();
            Dictionary<Char, int> map = new Dictionary<Char, int>();
            DateTime day = DateTime.Parse(today);

            for (int i = 0; i < terms.Length; i++)
            {
                int a = int.Parse(terms[i].Substring(1));
                map.Add(terms[i][0], a);
            }
            for (int i = 0; i < privacies.Length; i++)
            {
                DateTime temp = DateTime.Parse(privacies[i].Substring(0, 10));
                int m = map[privacies[i][11]];
                temp = temp.AddMonths(m);
                if (temp <= day)
                {
                    answer.Add(i + 1);
                }
            }

            return answer.ToArray();
    }
 ```
# 풀이 방법
 1. 약관의 종류와 기한이 있는 terms를 약관 종류를 키값으로 딕셔너리를 만든다.
 1. privacies 배열의 날짜를 DateTime으로 변환하고 약관의 유효기간을 더하여 만료일을 구한다.
 1. 만료일이 오늘 날짜보다 작거나 같다면 유효기간이 지났으므로 answer에 추가하여 답을 구한다.
# 문제를 풀며 배운 것
 DateTime을 사용해 보았다.