namespace _20240805
{
    internal class Program
    {
        /// <summary>
        /// name : 푸드 파이트 대회
        /// link : https://school.programmers.co.kr/learn/courses/30/lessons/134240
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] food = { 1, 3, 4, 6 };
            Console.WriteLine(solution(food));
        }

        public static string solution(int[] food)
        {
            string answer = "";
            for (int i = 1; i < food.Length; i++)
            {
                for (int j = 0; j < food[i] / 2; j++)
                {
                    answer += i;
                }
            }
            char[] chars = answer.ToCharArray();
            Array.Reverse(chars);
            answer += '0' + new string(chars);
            return answer;
        }
    }
}
