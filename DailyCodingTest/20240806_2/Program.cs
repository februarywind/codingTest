namespace _20240806_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { -3, -2, -1, 0, 1, 2, 3 };
            solution(ints);
        }

        public static int solution(int[] number)
        {
            int answer = 0;
            for (int i = 0; i < number.Length - 2; i++)
            {
                for (int j = i + 1; j < number.Length - 1; j++)
                {
                    for (int k = j + 1; k < number.Length; k++)
                    {
                        if (number[i] + number[j] + number[k] == 0)
                        {
                            answer++;
                        }
                    }
                }
            }
            Console.WriteLine(answer);
            return answer;
        }
    }
}
