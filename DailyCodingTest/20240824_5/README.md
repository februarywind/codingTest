# 이진 변환 반복하기 (programmers Lv 1)
 0과 1로 이루어진 문자열 s가 주어졌을 때 s가 1이 될 때까지 이진 변환한 횟수와 제거된 0의 개수를 구해야 한다.
 입력 예 : "110010101001"  
 출력 예 : [3,8]
# 내가 푼 코드
 ```cs
  public int[] solution(string s)
        {
            int[] answer = new int[2];
            List<char> list = new List<char>(s);
            int l = 0;
            while (list.Count > 1)
            {
                l = list.Count;
                list = list.Where(x => x == '1').ToList();
                answer[1] += l  - list.Count;
                answer[0]++;

                list = new List<char>(Convert.ToString(list.Count, 2));

            }
            return answer;
    }
 ```
# 풀이 방법
 1. s를 char List로 변환한다.
 1. list의 0을 제거하고 answer에 제거된 0의 개수와 횟수 1을 더한다.
 1. list의 길이를 이진수로 변환하여 list의 길이가 1이 될 때까지 반복해서 답을 구한다.
# 문제를 풀며 배운 것
 문자열의 계산이 비효율적이라는 얘기를 많이 들어서 계속 형 변환해서 계산하는데 다른 사람들은 그냥 구하네 흠