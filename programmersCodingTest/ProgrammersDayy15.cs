namespace programmersCodingTest
{
    internal class ProgrammersDayy15
    {
        //프로그래머스 입문 Day15
        public long solution1(string numbers) // 영어가 싫어요
        {
            long answer = 0;
            string number = "";
            string[] answers = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            for (int i = 0; i < numbers.Length; i++)
            {
                number += numbers[i];
                if (Array.IndexOf(answers, number) != -1)
                {
                    answer = answer * 10 + Array.IndexOf(answers, number);
                    number = "";
                }
            }
            return answer;
        }
        public string solution2(string my_string, int num1, int num2) // 인덱스 바꾸기
        {
            string answer = "";
            char[] b = my_string.ToCharArray();
            b[num1] = my_string[num2];
            b[num2] = my_string[num1];
            for (int i = 0; i < b.Length; i++)
            {
                answer += b[i];
            }
            return answer;
        }
        public string solution3(string s) // 한 번만 등장한 문자
        {
            string answer = "";
            char[] b = s.ToCharArray().Distinct().ToArray();
            List<char> list = new List<char>();
            for (int i = 0; i < b.Length; i++)
            {
                if (Array.IndexOf(s.ToCharArray(), b[i]) == Array.LastIndexOf(s.ToCharArray(), b[i]))
                    list.Add(b[i]);
            }
            list.Sort();
            foreach (var item in list)
            {
                answer += item;

            }
            return answer;
        }
        public int[] solution4(int n) // 약수 구하기
        {
            List<int> answer = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    answer.Add(i);
                }
            }
            return answer.ToArray();
        }
    }
}
