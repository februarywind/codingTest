# 신고 결과 받기 (programmers Lv 1)
 이용자의 ID가 담긴 문자열 배열 id_list, 각 이용자가 신고한 이용자의 ID 정보가 담긴 문자열 배열 report  
 정지 기준이 되는 신고 횟수 k가 매개변수로 주어질 때, 각 유저별로 처리 결과 메일을 받은 횟수를 구해야 한다.  
 입력 예 : ["muzi", "frodo", "apeach", "neo"], ["muzi frodo","apeach frodo","frodo neo","muzi neo","apeach muzi"], 2  
 출력 예 : [2, 1, 1, 0]
# 내가 푼 코드
 ```cs
  public int[] solution(string[] id_list, string[] report, int k)
        {
            int[] answer = new int[id_list.Length];
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
            Dictionary<string, int> mail = new Dictionary<string, int>();
            for (int i = 0; i < id_list.Length; i++)
            {
                dic.Add(id_list[i], new List<string>());
                mail.Add(id_list[i], i);

            }
            foreach (var item in report)
            {
                string[] strings = item.Split(' ');
                if (!dic[strings[1]].Contains(strings[0]))
                {
                    dic[strings[1]].Add(strings[0]);
                }
            }
            foreach (var item in id_list)
            {
                if (dic[item].Count >= k)
                {
                    foreach (var item1 in dic[item])
                    {
                        answer[mail[item1]]++;
                    }
                }
            }
            return answer;
    }
 ```
# 풀이 방법
 1. 신고 당한 사람을 키로 신고 한 사람들을 값으로 하는 딕셔너리와 닉네임과 answer의 인덱스에 대응하는 딕셔너리를 만든다.
 1. 동일 아이디를 신고하지 않았다면 딕셔너리 값에 추가한다.
 1. 신고 당한 횟수가 k 이상이라면 신고 한 사람들에게 ++해서 답을 구한다.
# 문제를 풀며 배운 것
 소... 솔직히 10줄 코딩보다는 제 코드가 더 이해하기 쉽다고 생각해요...  
 변수 이름 막 정하는 습관을 고쳐야 한다고 생각해요 이놈아