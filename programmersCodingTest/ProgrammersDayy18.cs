namespace programmersCodingTest
{
    internal class ProgrammersDayy18
    {
        //프로그래머스 입문 Day18
        public int solution1(string str1, string str2) // 문자열안에 문자열
        {
            int answer = 0;
            foreach (var item in str1)
            {
                if (str2[answer] == item)
                    answer++;
                else
                    answer = 0;
                if (answer == str2.Length)
                {
                    return 1;
                }
            }
            return 2;
        }
        public int solution2(int n) // 제곱수 판별하기
        {
            for (int i = 1; i < 1001; i++)
            {
                if (i * i == n)
                    return 1;
            }
            return 2;
        }
        public int solution3(int n, int t) // 세균 증식
        {
            for (int i = 1; i <= t; i++)
            {
                n *= 2;
            }
            return n;
        }
        public string solution4(string my_string) // 문자열 정렬하기 (2)
        {
            string answer = "";
            for (int i = 0; i < my_string.Length; i++)
            {
                if (my_string[i] < 'a')
                    answer += (char)(my_string[i] + 32);
                else
                    answer += my_string[i];
            }
            char[] chars = answer.ToCharArray();
            Array.Sort(chars);
            answer = new string(chars);
            return answer;
        }
    }
}
