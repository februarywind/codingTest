namespace _20240920_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<long> answer = new List<long>(100) { 1, 1, 1, 2, 2, 3, 4, 5, 7, 9 };
            for (int i = 10; i < 100; i++)
            {
                answer.Add(answer.Last() + answer[i - 5]);
            }
            for (int i = 0; i < n; i++)
            {
                int temp = int.Parse(Console.ReadLine()) - 1;
                Console.WriteLine(answer[temp]);
            }
        }
    }
}
