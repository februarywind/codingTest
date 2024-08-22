namespace _20240822_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            solution(["0OO", "OSO", "OOO"], ["E 2", "S 2", "W 1"]);
        }
        public static int[] solution(string[] park, string[] routes)
        {
            int[] answer = { park.Length - 1, park[0].Length - 1 };
            int[] s = { -1, -1 };
            for (int i = 0; i < park.Length; i++)
            {
                for (int j = 0; j < park[i].Length; j++)
                {
                    if (park[i][j] == 'S')
                    {
                        s[0] = i;
                        s[1] = j;
                        break;
                    }
                }
                if (s[0] != -1)
                    break;
            }
            foreach (var item in routes)
            {
                int[] temp = (int[])s.Clone();
                int p = (item[0] == 'E' || item[0] == 'S') ? 1 : -1;
                int f = int.Parse(item.Substring(1));
                for (int i = 0; i < f; i++)
                {
                    if (item[0] == 'E' || item[0] == 'W')
                    {
                        temp[1] += 1 * p;
                        if (temp[1] > answer[1] || temp[1] < 0)
                        {
                            temp = (int[])s.Clone();
                            break;
                        }
                    }
                    else
                    {
                        temp[0] += 1 * p;
                        if (temp[0] > answer[0] || temp[0] < 0)
                        {
                            temp = (int[])s.Clone();
                            break;
                        }
                    }
                    if (park[temp[0]][temp[1]] == 'X')
                    {
                        temp = (int[])s.Clone();
                        break;
                    }
                }
                s = (int[])temp.Clone();
            }
            return s;
        }
    }
}
