namespace _20240909_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> list = new List<string>() { "ChongChong" };
            for (int i = 0; i < n; i++)
            {
                string[] strings = Console.ReadLine().Split(" ");
                if (list.Contains(strings[0]))
                {
                    list.Add(strings[1]);
                }
                else if (list.Contains(strings[1]))
                {
                    list.Add(strings[0]);
                }
            }
            Console.WriteLine(list.Distinct().ToList().Count);
        }
    }
}
