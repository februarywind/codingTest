namespace _20240816_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution([44, 1, 0, 0, 31, 25], [31, 10, 45, 1, 6, 19]));
        }
        public static int[] solution(int[] lottos, int[] win_nums)
        {
            int[] answer = new int[2];
            int[] win = new int[] { 6, 6, 5, 4, 3, 2, 1 };

            int a = 0;

            foreach (var item in lottos)
            {
                for (int i = 0; i < 6; i++)
                {
                    if (win_nums[i] == item)
                    {
                        a++;
                    }
                }
            }
            answer[1] = win[a];
            a += lottos.Count(x => x == 0);
            answer[0] = win[a];
            return answer;
        }
    }
}
