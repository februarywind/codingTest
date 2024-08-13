namespace _20240813_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            solution(10, 3, 2);
        }
        public static int solution(int number, int limit, int power)
        {
            int[] answer = new int[number];
            answer[0] = 1;
            for (int i = 2; i <= number; i++)
            {
                int num = 0;
                for (int j = 1; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        num++;
                    }
                }
                if (Math.Sqrt(i) % 1 == 0)
                {
                    num += num - 1;
                }
                else
                {
                    num += num;
                }
                answer[i - 1] = num;
            }
            int b = answer.Count(x => x > limit);
            answer = answer.Where(x => x <= limit).ToArray();
            return answer.Sum() + b * power;
        }
    }
}
