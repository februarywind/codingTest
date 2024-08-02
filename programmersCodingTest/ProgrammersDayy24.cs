namespace programmersCodingTest
{
    internal class ProgrammersDayy24
    {
        //프로그래머스 입문 Day24
        public int solution1(int chicken) // 치킨 쿠폰
        {
            int answer = chicken;
            while (chicken > 9)
            {
                if (chicken < 100 && chicken % 10 != 0)
                {
                    chicken %= 10;
                }
                else
                {
                    chicken /= 10;
                }
                answer += chicken;
            }
            return answer / 10;
        }
        public string solution2(string bin1, string bin2) // 이진수 더하기
        {
            int b = 0;
            int c = 1;
            for (int i = bin1.Length - 1; i >= 0; i--)
            {
                if (bin1[i] == '1')
                {
                    b += c;
                }
                c *= 2;
            }
            c = 1;
            for (int i = bin2.Length - 1; i >= 0; i--)
            {
                if (bin2[i] == '1')
                {
                    b += c;
                }
                c *= 2;
            }
            return Convert.ToString(b, 2);
        }
        public int solution3(string before, string after) // A로 B만들기
        {
            int answer = 0;
            int a = 0;
            for (int i = 0; i < before.Length; i++)
            {
                answer += before[i];
                a += after[i];
            }
            return (answer == a) ? 1 : 0;
        }

        public int solution4(int i, int j, int k) // k의 개수
        {
            int answer = 0;

            for (int e = i; e <= j; e++)
            {
                answer += e.ToString().Where(x => x == k + '0').ToList().Count;
            }

            return answer;
        }
    }
}
