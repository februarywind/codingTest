namespace _20240824_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution("())(()"));
        }
        public static bool solution(string s)
        {
            int open = 0;
            int close = 0;
            foreach (var item in s)
            {
                if (item == '(')
                    open++;
                else
                    close++;
                if (close > open)
                {
                    return false;
                }
            }
            return open == close ? true : false;
        }
    }
}
