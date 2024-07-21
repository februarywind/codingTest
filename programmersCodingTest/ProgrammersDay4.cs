using System.Drawing;

namespace programmersCodingTest
{
    internal class ProgrammersDay4
    {
        //프로그래머스 입문 Day4
        public int solution1(int n) // 피자 나눠 먹기 (1)
        {
            int answer = n / 7;
            if (n % 7 != 0)
            {
                answer++;
            }
            return answer;
        }
        public int solution2(int n) // 피자 나눠 먹기 (2)
        {
            int answer = 6;
            while (answer % n != 0)
            {
                answer += 6;
            }
            return answer / 6;
        }
        public int solution3(int slice, int n) // 피자 나눠 먹기 (3)
        {
            int answer = 1;
            if (n - slice > 0)
            {
                answer += (n - slice) / slice;
                if ((n - slice) % slice != 0)
                {
                    answer++;
                }
            }
            return answer;
        }
        public double solution4(int[] numbers) // 배열의 평균값
        {
            double answer = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                answer += numbers[i];
            }
            answer /= numbers.Length;
            return answer;
        }
    }
}
