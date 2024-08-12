# 모의고사 (programmers Lv 1)
 3명의 학생이 특정한 순서대로 문제를 찍었을 때 가장 많이 맞춘 학생을 출력해야 한다.  
 입력 예 : [1,2,3,4,5]  
 출력 예 : [1]
# 내가 푼 코드
 ```cs
  public int[] solution(int[] answers)
        {
            int[] answer = new int[3];
            int[] test1 = { 1, 2, 3, 4, 5 };
            int[] test2 = { 2, 1, 2, 3, 2, 4, 2, 5 };
            int[] test3 = { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };

            for (int i = 0; i < answers.Length; i++)
            {
                if (answers[i] == test1[i % test1.Length])
                {
                    answer[0]++;
                }
                if (answers[i] == test2[i % test2.Length])
                {
                    answer[1]++;
                }
                if (answers[i] == test3[i % test3.Length])
                {
                    answer[2]++;
                }
            }
            int[] ints = answer.Where(x => x == answer.Max()).ToArray();
            if (ints.Length == 3)
            {
                return new int[] { 1, 2, 3 };
            }
            if (ints.Length == 2)
            {
                return new int[] { Array.IndexOf(answer, answer.Max()) + 1, Array.LastIndexOf(answer, answer.Max()) + 1 };
            }
            if (ints.Length == 1)
            {
                return new int[] { Array.IndexOf(answer, answer.Max()) + 1 };
            }
            return new int[] { };
    }
 ```
# 풀이 방법
 1. 정답을 순회하면서 i % length로 각 학생의 정답과 같은지 확인하고 맞으면 answer 배열 원소에 +1 한다.
 2. Where을 통해서 가장 많이 맞춘 학생의 수를 구한다. 3명이라면 [1,2,3] 리턴, 1, 2명이면 IndexOf를 통해 구해서 출력한다. 
 3. 모두 틀렸을 경우에는 빈 배열을 리턴한다.
 # 문제를 풀며 배운 것
  answer.Where(x => x == answer.Max()).ToArray();가 아니라 Count를 써서 int에 넣으면 되는데 왜그랬담.