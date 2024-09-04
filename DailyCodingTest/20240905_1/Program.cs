namespace _20240905_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(30) % 1234567);
            Console.WriteLine(solution2(30));
        }
        public static long solution(int n)
        {
            long answer = 0;
            long[] p = { 1, 2 };
            for (int i = 2; i < n; i++)
            {
                //p[0] %= 1234567;
                //p[1] %= 1234567;
                answer = p[0];
                p[0] = p[1];
                answer += p[0];
                p[1] = answer;
            }
            return answer == 0 ? n : answer;
        }
        public static long solution2(int n)
        {
            long answer = 0;
            long[] p = { 1, 2 };
            for (int i = 2; i < n; i++)
            {
                answer = p[0];
                p[0] = p[1];
                answer += p[0];
                answer %= 1234567;
                p[1] = answer;
            }
            return answer == 0 ? n : answer;
        }
    }
}
