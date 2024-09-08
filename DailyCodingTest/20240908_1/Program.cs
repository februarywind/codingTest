namespace _20240908_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            int[] ints = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
            Array.Sort(ints);
            Console.WriteLine(ints[0] * ints.Last());
        }
    }
}
