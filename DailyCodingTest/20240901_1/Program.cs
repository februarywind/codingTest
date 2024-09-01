using System.Text;

namespace _20240901_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution("[](){}"));
        }
        public static int solution(string s)
        {
            char[] open = { '(', '{', '[' };
            char[] close = { ')', '}', ']' };
            int len = s.Length;
            StringBuilder sb = new StringBuilder(s);
            int answer = 0;
            for (int i = 0; i < len; i++)
            {
                Stack<char> temp = new Stack<char>(len);
                temp.Push(s[i]);
                answer++;
                for (int j = 1; j < len; j++)
                {
                    if (Array.IndexOf(open, temp.Peek()) != Array.IndexOf(close, s[(j + i) % len]))
                    {
                        answer--;
                        break;
                    }
                    temp.Push(s[(j+i) % len]);
                }


            }
            return answer;
        }
    }
}
