namespace programmersCodingTest
{
    internal class ProgrammersDay8
    {
        //프로그래머스 입문 Day8
        public int[] solution1(int[] numbers, int num1, int num2) // 배열 자르기
        {
            int[] answer = new int[num2 - num1 + 1];
            Array.Copy(numbers, num1, answer, 0, num2 - num1 + 1);
            return answer;
        }
        public string solution2(int age) // 외계행성의 나이
        {
            string ageString = age.ToString();
            string answer = "";
            foreach (var item in ageString)
            {
                int a = item - '0';
                char b = 'a';
                for (int i = 0; i < a; i++)
                {
                    b++;
                }
                answer += b;
            }
            return answer;
        }
        public int[] solution3(int[] emergency) // 진료순서 정하기
        {
            int[] answer = new int[emergency.Length];
            Array.Copy(emergency, answer, emergency.Length);
            Array.Sort(emergency);
            Array.Reverse(emergency);
            int temp = 0;
            foreach (var item in emergency)
            {
                temp++;
                answer[Array.IndexOf(answer, item)] = temp * 111;
            }
            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] /= 111;
            }

            return answer;
        }
        public int solution4(int n) // 순서쌍의 개수
        {
            int answer = 1;
            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0)
                    answer++;
            }
            return answer;
        }
    }
}
