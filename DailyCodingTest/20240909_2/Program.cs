namespace _20240909_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int[] ints = new int[n];
            for (int i = 0; i < n; i++)
            {
                ints[i] = int.Parse(Console.ReadLine());
                if (!dic.TryAdd(ints[i], 1))
                {
                    dic[ints[i]]++;
                }
            }
            Array.Sort(ints);
            double temp = Math.Round((double)ints.Sum() / ints.Length);
            Console.WriteLine(temp == 0 ? 0 : temp);
            Console.WriteLine(ints[ints.Length / 2]);
            List<int> list = new List<int>();
            int m = dic.Values.Max();
            foreach (var item in dic)
            {
                if (item.Value == m)
                {
                    list.Add(item.Key);
                }
            }
            list.Sort();
            Console.WriteLine(list.Count > 1 ? list[1] : list[0]);
            Console.WriteLine(ints.Max() - ints.Min());
        }
    }
}
