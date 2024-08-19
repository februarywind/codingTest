namespace _20240819_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            solution([".#...", "..#..", "...#."]);
        }
        public static int[] solution(string[] wallpaper)
        {
            int[] answer = new int[] {-1,50,0,-1 };
            for (int i = 0; i < wallpaper.Length; i++)
            {
                for (int j = 0; j < wallpaper[i].Length; j++)
                {
                    if (wallpaper[i][j] == '#')
                    {
                        if (answer[0] == -1)
                        {
                            answer[0] = i;
                        }
                        if (answer[1] > j)
                        {
                            answer[1] = j;
                        }
                        if (answer[3] < j)
                        {
                            answer[3] = j;
                        }
                        answer[2] = i;
                    }
                }
            }
            answer[2]++;
            answer[3]++;
            return answer;
        }
    }
}
