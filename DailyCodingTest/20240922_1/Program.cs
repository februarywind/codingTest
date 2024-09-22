namespace _20240922_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer;
            int t = 0;
            int q = 0;
            bool c = true;
            for (int i = 0; i < 3; i++)
            {
                if (int.TryParse(Console.ReadLine(), out t) && c)
                {
                    q = t + 3 - i;
                    c = false;
                }
            }
            if (q % 3 == 0 && q % 5 == 0)
                answer = "FizzBuzz";
            else if (q % 3 == 0)
                answer = "Fizz";
            else if (q % 5 == 0)
                answer = "Buzz";
            else
                answer = q.ToString();
            Console.WriteLine(answer);
        }
    }
}
