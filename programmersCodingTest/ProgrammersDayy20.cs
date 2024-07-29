namespace programmersCodingTest
{
    internal class ProgrammersDayy20
    {
        //프로그래머스 입문 Day20
        public int solution1(int[,] dots) // 직사각형 넓이 구하기
        {
            int answer = 0;
            for (int i = 3; i >= 0; i--)
            {
                dots[i, 0] -= dots[0, 0];
                dots[i, 1] -= dots[0, 1];
                if (dots[i, 0] * dots[i, 1] != 0)
                {
                    answer = dots[i, 0] * dots[i, 1];
                    return (answer < 0) ? answer * -1 : answer;
                }
            }

            return 1;
        }
        public int[] solution2(string[] keyinput, int[] board) // 캐릭터의 좌표
        {
            int[] answer = new int[2];
            foreach (var item in keyinput)
            {
                if (item == "up" && answer[1] < board[1] / 2)
                    answer[1]++;
                if (item == "down" && answer[1] > -board[1] / 2)
                    answer[1]--;
                if (item == "right" && answer[0] < board[0] / 2)
                    answer[0]++;
                if (item == "left" && answer[0] > -board[0] / 2)
                    answer[0]--;
            }
            return answer;
        }
        public int solution3(int[] numbers) // 최댓값 만들기 (2)
        {
            Array.Sort(numbers);
            return (numbers[0] * numbers[1] > numbers[numbers.Length - 1] * numbers[numbers.Length - 2]) ? numbers[0] * numbers[1] : numbers[numbers.Length - 1] * numbers[numbers.Length - 2];
        }
        public string solution4(string polynomial) // 다항식 더하기
        {
            string[] answer = polynomial.Split(' ');
            int x = 0;
            int s = 0;
            string temp = "";

            foreach (var item in answer)
            {
                if (int.TryParse(item, out int a))
                {
                    s += a;
                }
                else if (item == "x")
                    x++;
                else
                {
                    for (int i = 0; i < item.Length - 1; i++)
                    {
                        temp += item[i];
                    }
                    int.TryParse(temp, out a);
                    x += a;
                    temp = "";
                }
            }
            if (x == 1 && s == 0)
                return "x";
            if (x == 0)
                return $"{s}";
            if (s == 0)
                return $"{x}x";
            if (x == 1)
                return $"x + {s}";
            return $"{x}x + {s}";
        }
    }
}
