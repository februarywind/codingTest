namespace _20240915_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set1 = new HashSet<string>();
            HashSet<string> set2 = new HashSet<string>();
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            for (int i = 0; i < n[0]; i++)
                set1.Add(Console.ReadLine());
            for (int i = 0; i < n[1]; i++)
                set2.Add(Console.ReadLine());
            set1.IntersectWith(set2);
            set1 = set1.OrderBy(x => x).ToHashSet();
            Console.WriteLine(set1.Count);
            Console.WriteLine(string.Join('\n', set1));
        }
    }
}
