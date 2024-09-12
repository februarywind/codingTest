namespace _20240912_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> answer = new List<int>();
            int[] nq = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
            int[] n = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

            int LR = 0;
            for (int i = 0; i < nq[1]; i++)
            {
                int[] temp = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
                
                switch (temp[0])
                {
                    case 1:
                        LR -= temp[1];
                        if (LR <= -nq[0])
                            LR %= nq[0];
                        break;
                    case 2:
                        LR += temp[1];
                        if (LR >= nq[0])
                            LR %= nq[0];
                        break;
                    case 3:
                        int start = temp[1] + LR - 1;
                        int sum = 0;
                        int now = 0;
                        for (int j = 0; j < temp[2] - temp[1] + 1; j++)
                        {
                            now = start + j;
                            if (now >= nq[0])
                            {
                                now %= nq[0];
                            }
                            if (now < 0)
                            {
                                sum += n[(nq[0] + now)];
                            }
                            else
                            {
                                sum += n[now];
                            }
                        }
                        answer.Add(sum);
                        break;
                }
            }
            Console.WriteLine(string.Join("\n", answer));
        }
    }
}
