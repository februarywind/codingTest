namespace _20240917_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] T() => Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] n = T();
            int[] ints = T();
            int[] answer = new int[n[1]];
            int t = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                t += ints[i];
                ints[i] = t;
            }
            for (int i = 0; i < n[1]; i++)
            {
                int[] temp = T();
                answer[i] = ints[temp[1] - 1] - ((temp[0] - 2) < 0 ? 0 : ints[temp[0] - 2]);
            }
            Console.WriteLine(string.Join('\n', answer));
        }
    }
}
