﻿using System.Text;

namespace _20240901_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution("(){{"));
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
                answer++;
                for (int j = 0; j < len; j++)
                {
                    int n = (j + i) % len;
                    if (Array.IndexOf(open, sb[n]) != -1)
                    {
                        temp.Push(sb[n]);
                    }
                    else if (temp.Count == 0 || Array.IndexOf(open, temp.Peek()) != Array.IndexOf(close, sb[n]))
                    {
                        answer--;
                        break;
                    }
                    else
                    {
                        temp.Pop();
                    }
                    if (j == len - 1 && temp.Count != 0)
                    {
                        answer--;
                    }
                }

            }
            return answer;
        }
    }
}
