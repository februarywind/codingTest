using System.Drawing;

namespace programmersCodingTest
{
    internal class ProgrammersDay7
    {
        //프로그래머스 입문 Day7
        public string solution1(string my_string, string letter) // 특정 문자 제거하기
        {
            string answer = "";
            char _letter = char.Parse(letter); // 제거할 문자를 char으로 변경
            foreach (var item in my_string)
            {
                if (item != _letter)
                {
                    answer += item;
                }
            }
            return answer;
        }
        public int solution2(int angle) // 각도기
        {
            if (angle == 90)
                return 2;
            else if (angle == 180)
                return 4;
            else if (angle < 90)
                return 1;
            else
                return 3;
        }
        public int solution3(int n, int k) // 양꼬치 
        {
            int answer = (12000 * n) + (2000 * k) - ((n / 10) * 2000);
            return answer;
        }
        public int solution4(int n) // 짝수의 합
        {
            int answer = 0;
            for (int i = 0; i <= n; i += 2)
            {
                answer += i;
            }
            return answer;
        }
    }
}
