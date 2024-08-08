namespace _20240808_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(5, 24));
        }
        public static string solution(int a, int b)
        {
            DateTime day = new DateTime(2016, a, b);
            return day.DayOfWeek.ToString().ToUpper().Substring(0, 3);
        }
    }
}
