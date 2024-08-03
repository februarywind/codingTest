namespace programmersCodingTest
{
    internal class ProgrammersDayy25
    {
        //프로그래머스 입문 Day25
        public int solution1(string A, string B) // 문자열 밀기
        {
            char[] answer = A.ToArray();
            char temp;

            for (int i = 0; i < A.Length; i++)
            {
                if (new string(answer) == B)
                {
                    return i;
                }
                temp = answer[answer.Length - 1];
                Array.Copy(answer, 0, answer, 1, answer.Length - 1);
                answer[0] = temp;
            }
            return -1;
        }
        public int solution2(int M, int N) // 종이 자르기
        {
            int answer = M * N - 1;
            return answer;
        }
        public int[] solution3(int num, int total) // 연속된 수의 합
        {
            if (num == 1)
                return new int[] { total };
            int[] answer = new int[num];
            int max = Math.Max(num, total);
            for (int i = max; i > 0; i--)
            {
                for (int j = 0; j < num; j++)
                {
                    answer[j] = i - j;
                }
                if (answer.Sum() == total)
                {
                    Array.Sort(answer);
                    return answer;
                }
            }
            return answer;
        }

        public int solution4(int[] common) // 다음에 올 숫자
        {
            if (common[1] - common[0] == common[2] - common[1])
            {
                return common[common.Length - 1] + common[1] - common[0];
            }
            return common[common.Length - 1] * common[1] / common[0];
        }
    }
}
