using System.Text;

namespace _20240814_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution("5525", "1255"));
        }
        public static string solution(string X, string Y)
        {
            int[] xCount = new int[10];
            int[] yCount = new int[10];
            int[] xyCount = new int[10];

            foreach (var item in X)
            {
                xCount[item - '0']++;
            }

            foreach (var item in Y)
            {
                yCount[item - '0']++;
            }

            int temp = 0;
            for (int i = 0; i < 10; i++)
            {
                xyCount[i] = Math.Min(xCount[i], yCount[i]);
                temp += xyCount[i];
            }
            if (temp == 0)
            {
                return "-1";
            }
            if (temp == xyCount[0])
            {
                return "0";
            }
            StringBuilder answer = new StringBuilder();

            for (int i = 9; i >= 0; i--)
            {
                for (int j = 0; j < xyCount[i]; j++)
                {
                    answer.Append(i);
                }
            }
            return answer.ToString();
        }
    }
}
