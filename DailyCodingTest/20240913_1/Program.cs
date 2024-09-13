namespace _20240913_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            HashSet<long> N = Array.ConvertAll(Console.ReadLine().Split(), long.Parse).ToHashSet();
            Console.ReadLine();
            long[] Q = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);

            char[] answer = new char[Q.Length];
            for (int i = 0; i < Q.Length; i++)
            {
                if (N.Contains(Q[i]))
                {
                    answer[i] = '1';
                }
                else
                {
                    answer[i] = '0';
                }
            }
            Console.WriteLine(string.Join('\n', answer));
        }
    }
}
