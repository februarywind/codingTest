namespace _20240915_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] coins = new int[n[0]];
            for (int i = 0; i < n[0]; i++)
            {
                coins[i] = int.Parse(Console.ReadLine());
            }
            n[0] = 0;
            Array.Reverse(coins);
            foreach (var item in coins)
            {
                if (n[1] / item >= 1)
                {
                    n[0] += n[1] / item;
                    n[1] %= item;
                    if (n[1] == 0)
                        break;
                }
            }
            Console.WriteLine(n[0]);
        }
    }
}
