namespace programmersCodingTest
{
    internal class ProgrammersDayy12
    {
        //프로그래머스 입문 Day12
        public string solution1(string my_string) // 모음 제거
        {
            char[] b = my_string.ToCharArray();
            char[] c = { 'a', 'e', 'i', 'o', 'u' };
            my_string = "";

            foreach (var item in c)
            {
                int i = b.Count(x => x == item);
                for (int j = 0; j < i; j++)
                {
                    b[Array.IndexOf(b, item)] = '@';
                }
            }
            foreach (var item in b)
            {
                if (item != '@')
                {
                    my_string += item;
                }
            }

            return my_string;
        }
        public int[] solution2(string my_string) // 문자열 정렬하기(1)
        {
            int[] answer = new int[0];
            foreach (var item in my_string)
            {
                if (item - '0' >= 0 && item - '0' < 10)
                {
                    Array.Resize(ref answer, answer.Length + 1);
                    answer[answer.Length - 1] = item - '0';
                }
            }
            Array.Sort(answer);
            return answer;
        }
        public int solution3(string my_string) // 숨어있는 숫자의 덧샘(1)
        {
            int answer = 0;
            foreach (var item in my_string)
            {
                if (item - '0' >= 0 && item - '0' < 10)
                {
                    answer += item - '0';
                }
            }
            return answer;
        }
        public int[] solution4(int n) // 소인수분해
        {
            int[] answer = new int[0];
            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0)
                {
                    n /= i;
                    if (Array.IndexOf(answer, i) == -1)
                    {
                        Array.Resize(ref answer, answer.Length + 1);
                        answer[answer.Length - 1] = i;
                    }
                    i = 1;
                }
            }
            return answer;
        }
    }
}
