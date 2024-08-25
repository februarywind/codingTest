namespace _20240825_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            solution(10, 2);
        }
        public static int[] solution(int brown, int yellow)
        {
            int[] answer = { 1, yellow };
            for (int i = 1; i <= yellow; i++)
            {
                if (yellow % i == 0)
                {
                    answer[0] = 1 * i;
                    answer[1] = yellow / i;
                }
                if ((answer[0] * 2) + (answer[1] * 2) + 4 == brown)
                {
                    answer[0] += 2;
                    answer[1] += 2;
                    break;
                }
            }
            Array.Sort(answer);
            Array.Reverse(answer);
            return answer;
        }
    }
}
