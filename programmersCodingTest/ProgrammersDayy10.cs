namespace programmersCodingTest
{
    internal class ProgrammersDayy10
    {
        //프로그래머스 입문 Day10
        public int solution1(int[] dot) // 점의 위치 구하기
        {
            bool xp = dot[0] > 0;
            bool yp = dot[1] > 0;
            int answer = (!xp && yp) ? 2 : (xp && yp) ? 1 : (!xp && !yp) ? 3 : 4;
            return answer;
        }
        public int[,] solution2(int[] num_list, int n) // 2차원으로 만들기
        {
            int[,] answer = new int[num_list.Length / n, n];
            for (int i = 0; i < num_list.Length / n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    answer[i, j] = num_list[j + i * n];
                }
            }
            return answer;
        }
        public int solution3(int[] numbers, int k) // 공 던지기
        {
            return numbers[((2 * (k - 1))) % numbers.Length];
        }
        public int[] solution4(int[] numbers, string direction) // 배열 회전시키기
        {
            int[] answer = new int[numbers.Length];
            if (direction == "right")
            {
                answer[0] = numbers[numbers.Length - 1];
                Array.Copy(numbers, 0, answer, 1, numbers.Length - 1);
            }
            else
            {
                answer[answer.Length - 1] = numbers[0];
                Array.Copy(numbers, 1, answer, 0, numbers.Length - 1);
            }
            return answer;
        }
    }
}
