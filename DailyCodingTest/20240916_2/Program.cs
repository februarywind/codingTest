namespace _20240916_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            string[] answer = new string[n[1]];
            for (int i = 0; i < n[0]; i++)
            {
                string[] strings = Console.ReadLine().Split();
                dic.Add(strings[0], strings[1]);
            }
            for (int i = 0; i < n[1]; i++)
            {
                answer[i] = dic[Console.ReadLine()];
            }
            Console.WriteLine(string.Join('\n', answer));
        }
    }
}
