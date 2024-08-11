namespace _20240811_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            solution(100, 4, 101);
        }
        public static int solution(int a, int b, int n)
        {
            int answer = 0;
            while (n >= a)
            {
                n -= (a - b);
                answer += b;
            }
            return answer;
        }
    }
}
