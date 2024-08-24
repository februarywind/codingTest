using System.Text;

namespace _20240824_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution("hello, world! "));
        }
        public static string solution(string s)
        {
            s = s.ToLower();
            StringBuilder sb = new StringBuilder(s);
            sb[0] = char.ToUpper(sb[0]);
            for (int i = 0; i < sb.Length - 1; i++)
            {
                if (sb[i] == ' ')
                {
                    sb[i + 1] = char.ToUpper(sb[i + 1]);
                }
            }
            return sb.ToString();
        }
    }
}
