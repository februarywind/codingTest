namespace _20240821_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(["mumu", "soe", "poe", "kai", "mine"], ["kai", "kai", "mine", "mine"]));
        }
        public static string[] solution(string[] players, string[] callings)
        {
            string[] answer = new string[players.Length];
            Dictionary<string, int> runner = new Dictionary<string, int>();
            Dictionary<int, string> rank = new Dictionary<int, string>();
            for (int i = 0; i < players.Length; i++)
            {
                runner.Add(players[i], i);
                rank.Add(i, players[i]);
            }
            foreach (var item in callings)
            {
                rank[runner[item]] = rank[runner[item] - 1];
                rank[runner[item] - 1] = item;

                runner[rank[runner[item]]]++;
                runner[item]--;
            }

            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] = rank[i];
            }

            return answer;
        }
    }
}
