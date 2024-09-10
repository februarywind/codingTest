using System.Collections.Generic;
using System.Text;

namespace _20240910_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int answer = 0;
            int n = int.Parse(Console.ReadLine());
            int[] s = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
            int[] tp = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

            for (int i = 0; i < s.Length; i++)
            {
                int temp = s[i] / tp[0];
                answer += s[i] % tp[0] == 0 ? temp : temp + 1;
            }
            Console.WriteLine(answer);
            Console.WriteLine(n / tp[1] + " " + n % tp[1]);

        }
    }
}
