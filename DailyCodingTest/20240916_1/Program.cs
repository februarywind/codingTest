namespace _20240916_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int answer = 0;
            int temp = 0;
            Console.ReadLine();
            int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(ints);
            foreach (var item in ints)
            {
                temp += item;
                answer += temp;
            }
            Console.WriteLine(answer);
        }
    }
}
