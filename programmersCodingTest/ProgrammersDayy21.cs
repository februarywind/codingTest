namespace programmersCodingTest
{
    internal class ProgrammersDayy21
    {
        //프로그래머스 입문 Day21
        public int solution1(string my_string) // 숨어있는 숫자의 덧셈 (2)
        {
            int answer = 0;
            int a = 0;
            foreach (var item in my_string)
            {
                if (item - '0' > -1 && item - '0' < 10)
                {
                    a *= 10;
                    a += item - '0';
                }
                else
                {
                    answer += a;
                    a = 0;
                }
            }
            answer += a;
            return answer;
        }
        public int solution2(int[,] board) // 안전지대
        {
            int answer = 0;
            int n = board.GetLength(0);
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (board[i, j] == 1)
                    {
                        list.Add(i);
                        list.Add(j);
                    }
                }
            }

            for (int i = 0; i < list.Count; i += 2)
            {
                int y = list[i];
                int x = list[i + 1];
                if (y != 0 && x % n != 0 && board[y - 1, x - 1] == 0)
                    board[y - 1, x - 1] = 2;

                if (y != 0 && board[y - 1, x] == 0)
                    board[y - 1, x] = 2;

                if (y != 0 && x % n != n - 1 && board[y - 1, x + 1] == 0)
                    board[y - 1, x + 1] = 2;

                if (x % n != 0 && board[y, x - 1] == 0)
                    board[y, x - 1] = 2;

                if (x % n != n - 1 && board[y, x + 1] == 0)
                    board[y, x + 1] = 2;

                if (y != n - 1 && x % n != 0 && board[y + 1, x - 1] == 0)
                    board[y + 1, x - 1] = 2;

                if (y != n - 1 && board[y + 1, x] == 0)
                    board[y + 1, x] = 2;

                if (y != n - 1 && x % n != n - 1 && board[y + 1, x + 1] == 0)
                    board[y + 1, x + 1] = 2;
            }
            foreach (var item in board)
                if (item == 0)
                    answer++;
            return answer;
        }
        public int solution3(int[] sides) // 삼각형의 완성조건 (2)
        {
            int max = sides.Max(x => x);
            int min = sides.Min(x => x);
            return (max + min - 1) - (max - min + 1) + 1;
        }
        public int solution4(string[] spell, string[] dic) // 외계어 사전
        {
            int answer = 0;
            foreach (var item in spell)
                answer += item[0];

            for (int i = 0; i < dic.Length; i++)
            {
                int b = 0;
                foreach (var item in dic[i])
                    b += item;
                if (b == answer)
                    return 1;
            }
            return 2;
        }
    }
}
