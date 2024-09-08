namespace _20240908_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int answer = 0;
            int n = int.Parse(Console.ReadLine());
            string[] strings = new string[n+1];
            List<string> list = new List<string>();
            for (int i = 0; i < n; i++)
            {
                strings[i] = Console.ReadLine();
            }
            strings[n] = "ENTER";
            foreach (var item in strings)
            {
                if (item == "ENTER")
                {
                    answer += list.Distinct().Count();
                    list.Clear();
                }
                else
                {
                    list.Add(item);
                }
            }
            Console.WriteLine(answer);
        }
    }
}
