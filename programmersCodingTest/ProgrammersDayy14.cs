namespace programmersCodingTest
{
    internal class ProgrammersDayy14
    {
        //프로그래머스 입문 Day14
        public int solution1(int[] array, int n) // 가까운 수
        {
            int answer = 0;
            int temp = 100;
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i] - n) < temp)
                {
                    temp = Math.Abs(array[i] - n);
                    answer = array[i];
                }
            }
            return answer;
        }
        public int solution2(int order) // 369게임
        {
            char[] b = order.ToString().ToCharArray();
            for (int i = 0; i < b.Length; i++)
            {
                b[i] -= '0';
            }
            return b.Count(x => x % 3 == 0 && x != 0);
        }
        public string solution3(string cipher, int code) // 암호 해독
        {
            string answer = "";
            for (int i = code; i <= cipher.Length; i += code)
            {
                answer += cipher[i - 1];
            }
            return answer;
        }
        public string solution4(string my_string) // 대문자와 소문자
        {
            string answer = "";
            foreach (var item in my_string)
            {
                if (item < 'a')
                {
                    answer += (char)(item + 32);
                }
                else
                    answer += (char)(item - 32);
            }
            return answer;
        }
    }
}
