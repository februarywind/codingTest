namespace _20240825_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(10));
        }
        public static int solution(int n)
        {
            int answer = 0;
            int[] temp = { 0, 1 };
            for (int i = 1; i < n; i++)
            {
                answer = temp[1];
                temp[1] = (temp[0] + temp[1]) % 1234567;
                temp[0] = (answer % 1234567);
            }
            return temp[1];
        }
    }
}
