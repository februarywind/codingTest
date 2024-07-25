namespace programmersCodingTest
{
    internal class ProgrammersDayy11
    {
        //프로그래머스 입문 Day11
        public int solution1(int[] box, int n) // 주사위의 개수
        {
            int answer = (box[0] / n) * (box[1] / n) * (box[2] / n);
            return answer;
        }
        public int solution2(int n) // 합성수 찾기
        {
            int answer = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        answer++;
                        break;
                    }
                }
            }
            return answer;
        }
        public int solution3(int[] numbers) // 최댓값 만들기
        {
            Array.Sort(numbers);
            return numbers[numbers.Length - 2] * numbers[numbers.Length - 1];
        }
        public int solution4(int n) // 팩토리얼
        {
            int answer = 1;
            for (int i = 1; i <= 10; i++)
            {
                answer *= i;
                if (answer > n)
                    return i - 1;
                if (answer == n)
                    return i;
            }
            return answer;
        }
    }
}
