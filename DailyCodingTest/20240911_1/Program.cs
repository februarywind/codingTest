namespace _20240911_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] strings = new string[n];
            for (int i = 0; i < n; i++)
                strings[i] = Console.ReadLine();

            var answer = strings.Distinct().OrderBy(x => x.Length).ThenBy(x => x);
            foreach (var item in answer)
                Console.WriteLine(item);

            //Console.WriteLine(string.Join("\n",
            //    strings.Distinct()
            //    .OrderBy(x => x.Length)
            //    .ThenBy(x => x)));
        }
    }
}
