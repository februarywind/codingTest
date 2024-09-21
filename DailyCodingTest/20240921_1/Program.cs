namespace _20240921_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()) * 2;
            List<int> list = Enumerable.Range(1, 14).ToList();
            for (int i = 0; i < 14; i++)
            {
                list.Add(1);
                for (int j = 0; j < 13; j++)
                {
                    list.Add(list.Last() + list[list.Count - 14]);
                }
            }
            List<int> temp = new List<int>();
            for (int i = 0; i < n; i++)
            {
                temp.Add(int.Parse(Console.ReadLine()));
                if (temp.Count == 2)
                {
                    Console.WriteLine(list[temp[0] * 14 + temp[1] - 1]);
                    temp.Clear();
                }
            }
        }
    }
}
