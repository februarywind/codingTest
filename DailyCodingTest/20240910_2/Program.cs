namespace _20240910_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int answer = 0;
            int[] nm = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
            int[] card = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();

            for (int i = 0; i < card.Length - 2; i++)
                for (int j = i + 1; j < card.Length - 1; j++)
                    for (int k = j + 1; k < card.Length; k++)
                    {
                        int temp = card[i] + card[j] + card[k];
                        if (temp > nm[1])
                            continue;
                        answer = Math.Max(answer, temp);
                        if (answer == nm[1])
                            card = new int[0] { };
                    }
            Console.WriteLine(answer);
        }
    }
}
