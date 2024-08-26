namespace _20240826_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            solution(5000);
        }
        public static int solution(int n)
        {
            int answer = 1;

            while (n != 1)
            {
                if (n % 2 == 0)
                {
                    n /= 2;
                }
                else
                {
                    n--;
                    answer++;
                }
            }

            return answer;
        }
    }
}
