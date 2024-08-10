namespace _20240810_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            solution(72, 126);
        }
        public static int[] solution(int n, int m)
        {
            int[] answer = new int[2];
            for (int i = n; i > 0; i--)
            {
                if (m % i == 0 && n % i == 0)
                {
                    answer[0] = i;
                    break;
                }
            }
            int a = n;
            int b = m;
            while (a != b)
            {
                if (a < b)
                {
                    a += n;
                }
                else
                {
                    b += m;
                }
            }

            answer[1] = a;
            //answer[1] = n * m / answer[0];
            return answer;
        }
    }
}
