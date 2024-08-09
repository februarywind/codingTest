namespace _20240809_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(["sun", "bed", "car"], 1));
        }
        public static string[] solution(string[] strings, int n)
        {
            List<string> list = new List<string>(strings.Length) { };
            bool check = false;
            Array.Sort(strings);
            Array.Reverse(strings);

            for (int i = 0; i < strings.Length; i++)
            {
                check = false;
                for (int j = 0; j < list.Count; j++)
                {
                    if (strings[i][n] <= list[j][n])
                    {
                        list.Insert(j, strings[i]);
                        check = true;
                        break;
                    }
                }
                if (!check)
                {
                    list.Add(strings[i]);
                }
            }

            return list.ToArray();
        }
    }
}
