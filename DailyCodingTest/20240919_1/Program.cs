namespace _20240919_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] zero = new int[41];
            zero[0] = 1; zero[1] = 0;
            int[] one = new int[41];
            one[0] = 0; one[1] = 1;
            for (int i = 2; i < 41; i++)
            {
                zero[i] = zero[i - 1] + zero[i - 2];
                one[i] = one[i - 1] + one[i - 2];
            }
            for (int i = 0; i < n; i++)
            {
                int temp = int.Parse(Console.ReadLine());
                Console.WriteLine($"{zero[temp]} {one[temp]}");
            }
        }
    }
}
