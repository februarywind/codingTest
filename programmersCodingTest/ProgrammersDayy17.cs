namespace programmersCodingTest
{
    internal class ProgrammersDayy17
    {
        //프로그래머스 입문 Day17
        public int solution1(int num, int k) // 숫자 찾기
        {
            char[] arr = num.ToString().ToCharArray();
            int answer = Array.IndexOf(arr, (char)(k + '0'));
            if (answer != -1)
            {
                answer++;
            }
            return answer;
        }
        public int[] solution2(int n, int[] numlist) // n의 배수 고르기
        {
            List<int> answer = new List<int>();
            for (int i = 0; i < numlist.Length; i++)
            {
                if (numlist[i] % n == 0)
                {
                    answer.Add(numlist[i]);
                }
            }
            return answer.ToArray();
        }
        public int solution3(int n) // 자릿수 더하기
        {
            int answer = 0;
            string s = n.ToString();
            foreach (var item in s)
            {
                answer += item - '0';
            }
            return answer;
        }
        public string[] solution4(string[] quiz) //OX퀴즈
        {
            string[] answer = new string[quiz.Length];
            for (int i = 0; i < quiz.Length; i++)
            {
                string[] quiz2 = quiz[i].Split(' ');
                int temp = -1;
                if (quiz2[1] == "+")
                    temp = 1;
                if (int.Parse(quiz2[0]) + int.Parse(quiz2[2]) * temp == int.Parse(quiz2[4]))
                {
                    answer[i] = "O";
                }
                else
                {
                    answer[i] = "X";
                }
            }
            return answer;
        }
    }
}
