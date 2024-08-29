namespace _20240829_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(32, 1, 17));
        }
        public static int solution(int n, int a, int b)
        {
            int answer = 1;
            while (n > 2)
            {
                if (Math.Min(a, b) > n / 2)
                {
                    n /= 2;
                    a -= n;
                    b -= n;
                    continue;
                }
                else if (Math.Max(a, b) <= n / 2)
                {
                    n /= 2;
                    continue;
                }
                else
                {
                    int temp = 2;
                    while (temp != n)
                    {
                        temp *= 2;
                        answer++;
                    }
                    break;
                }
            }
            return answer;
        }
    }
}
