using System.Diagnostics;
using System.Drawing;

namespace programmersCodingTest
{
    internal class ProgrammersDay5
    {
        //프로그래머스 입문 Day5
        public int solution1(int price) // 옷가게 할인 받기
        {
            if (price >= 500000)
            {
                price = (int)(price * 0.8);
            }
            else if (price >= 300000)
            {
                price = (int)(price * 0.9);
            }
            else if (price >= 100000)
            {
                price = (int)(price * 0.95);
            }

            return price;
        }
        public int[] solution2(int money) // 아이스 아메리카노
        {
            int[] answer = new int[2];
            answer[0] = money / 5500;
            answer[1] = money % 5500;
            return answer;
        }
        public int solution3(int age) // 나이 출력
        {
            int answer = 2023 - age;
            return answer;
        }
        public int[] solution4(int[] num_list) // 배열 뒤집기
        {
            Array.Reverse(num_list);
            return num_list;
        }
    }
}
