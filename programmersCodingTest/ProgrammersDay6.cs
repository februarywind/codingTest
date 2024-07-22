using System.Drawing;

namespace programmersCodingTest
{
    internal class ProgrammersDay6
    {
        //프로그래머스 입문 Day6
        public string solution1(string my_string) // 문자열 뒤집기
        {
            string answer = "";
            for (int i = 0; i < my_string.Length; i++)
            {
                answer += my_string[my_string.Length - 1 - i];
            }
            return answer;
        }
        public void solution2(int n) // 직각삼각형 출력하기
        {
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public int[] solution3(int[] num_list) // 짝수 홀수 개수
        {
            int[] answer = new int[2];
            foreach (var item in num_list)
            {
                if (item % 2 == 0)
                {
                    answer[0]++;
                }
                else
                {
                    answer[1]++;
                }
            }
            return answer;
        }
        public string solution4(string my_string, int n) // 문자 반복 출력하기
        {
            string answer = "";
            foreach (var item in my_string)
            {
                for (int i = 0; i < n; i++)
                    answer += item;
            }
            return answer;
        }
    }
}
