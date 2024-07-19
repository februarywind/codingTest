namespace programmersCodingTest
{
    internal class ProgrammersDay2
    {
        //프로그래머스 입문 Day2
        public int solution1(float num1, float num2)
        {
            int answer = (int)((num1 / num2) * 1000);
            return answer;
        }
        public int solution2(int num1, int num2)
        {
            int answer = 0;
            if (num1 == num2)
                answer = 1;
            else
                answer = -1;
            return answer;
        }
        public int[] solution3(int numer1, int denom1, int numer2, int denom2)
        {
            int[] answer = new int[2];
            answer[1] = denom1 * denom2;
            answer[0] = ((answer[1] / denom1) * numer1) + ((answer[1] / denom2) * numer2);
            

            for (int i = 2; i < 1000; i++)
            {
                if (answer[0] % i == 0 && answer[1] % i == 0)
                {
                    answer[0] = answer[0] / i;
                    answer[1] = answer[1] / i;
                    i = 1;
                }
            }

            return answer;
        }
        public int[] solution4(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= 2;
            }
            return numbers;
        }
    }
}
