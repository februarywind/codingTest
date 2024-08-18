namespace _20240818_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(["TR", "RT", "TR"], [7, 1, 3]));
        }
        public static string solution(string[] survey, int[] choices)
        {
            string answer = "";
            int[] score = { -1, 3, 2, 1, 0, 1, 2, 3 };
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>() { { 'R', 0 }, { 'T', 0 }, { 'C', 0 }, { 'F', 0 }, { 'J', 0 }, { 'M', 0 }, { 'A', 0 }, { 'N', 0 }, };

            for (int i = 0; i < survey.Length; i++)
            {
                char temp = (choices[i] < 4) ? survey[i][0] : survey[i][1];
                keyValuePairs[temp]+= score[choices[i]];
            }
            answer += (keyValuePairs['R'] >= keyValuePairs['T']) ? 'R' : 'T';
            answer += (keyValuePairs['C'] >= keyValuePairs['F']) ? 'C' : 'F';
            answer += (keyValuePairs['J'] >= keyValuePairs['M']) ? 'J' : 'M';
            answer += (keyValuePairs['A'] >= keyValuePairs['N']) ? 'A' : 'N';
            return answer;
        }
    }
}
