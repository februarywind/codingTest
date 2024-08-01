namespace programmersCodingTest
{
    internal class ProgrammersDayy22
    {
        //프로그래머스 입문 Day22
        public int solution1(int n) // 저주의 숫자 3
        {
            int answer = 0;
            for (int i = 0; i < n; i++)
            {
                do
                {
                    answer++;
                } while (answer % 3 == 0 || Array.IndexOf(answer.ToString().ToCharArray(), '3') != -1);
            }
            return answer;
        }
        public int solution2(int[,] dots) // 평행
        {
            float giul = 0;
            int[,] check = { { 2, 3 }, { 1, 3 }, { 1, 2 } };
            for (int i = 1; i < dots.GetLength(0); i++)
            {
                giul = (float)(dots[0, 1] - dots[i, 1]) / (float)(dots[0, 0] - dots[i, 0]);

                if (giul == (float)(dots[check[i - 1, 0], 1] - dots[check[i - 1, 1], 1]) / (float)(dots[check[i - 1, 0], 0] - dots[check[i - 1, 1], 0]))
                {
                    return 1;
                }
            }
            return 0;
        }
        public int solution3(int[,] lines) // 겹치는 선분의 길이
        {
            int max = 0;
            int min = 0;
            List<int> list = new List<int>();
            if (lines[0, 1] > lines[1, 0])
            {
                max = Math.Max(lines[0, 0], lines[1, 0]);
                min = Math.Min(lines[0, 1], lines[1, 1]);

                for (int i = max; i < min; i++)
                {
                    list.Add(i);
                }
            }
            if (lines[0, 1] > lines[2, 0])
            {
                max = Math.Max(lines[0, 0], lines[2, 0]);
                min = Math.Min(lines[0, 1], lines[2, 1]);

                for (int i = max; i < min; i++)
                {
                    list.Add(i);
                }
            }
            if (lines[1, 1] > lines[2, 0])
            {
                max = Math.Max(lines[1, 0], lines[2, 0]);
                min = Math.Min(lines[1, 1], lines[2, 1]);

                for (int i = max; i < min; i++)
                {
                    list.Add(i);
                }
            }
            return list.Distinct().ToArray().Length;
        }

        public int solution4(int a, int b) // 유한소수 판별하기
        {
            double A = a;
            double B = b;
            return ((A / B).ToString().Length > 11 ? 2 : 1);
        }
    }
}
