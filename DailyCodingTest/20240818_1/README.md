# 성격 유형 검사하기 (programmers Lv 1)
 세상에 지문이 너무 길어요 그냥 딕셔너리를 잘 활용하면 풀수있는 문제였어요  
 https://school.programmers.co.kr/learn/courses/30/lessons/118666  
 입력 예 : ["AN", "CF", "MJ", "RT", "NA"], [5, 3, 2, 7, 5]  
 출력 예 : "TCMA"
# 내가 푼 코드
 ```cs
  public string solution(string[] survey, int[] choices)
        {
            string answer = "";
            int[] score = { -1, 3, 2, 1, 0, 1, 2, 3 };
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>() { { 'R', 0 }, { 'T', 0 }, { 'C', 0 }, { 'F', 0 }, { 'J', 0 }, { 'M', 0 }, { 'A', 0 }, { 'N', 0 }, };

            for (int i = 0; i < survey.Length; i++)
            {
                char temp = (choices[i] < 4) ? survey[i][0] : survey[i][1];
                keyValuePairs[temp]+= score[choices[i]];
            }
            answer += (keyValuePairs['R'] >= keyValuePairs['T']) ? 'R' : 'T';
            answer += (keyValuePairs['C'] >= keyValuePairs['F']) ? 'C' : 'F';
            answer += (keyValuePairs['J'] >= keyValuePairs['M']) ? 'J' : 'M';
            answer += (keyValuePairs['A'] >= keyValuePairs['N']) ? 'A' : 'N';
            return answer;
    }
 ```
# 풀이 방법
 1. 8가지 유형을 키값으로 딕셔너리에 추가한다.
 1. 4를 기준으로 삼항연산자를 통해 키값을 구한다.
 1. 키값에 선택지별 점수를 더한다.
 1. 유형별 점수가 높은 것을 answer에 더하여 답을 구한다.
# 문제를 풀며 배운 것
 삼항연산자최고다너무간결해지는코드가좋다.