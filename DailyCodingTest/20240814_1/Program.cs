namespace _20240814_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution([1, 2, 7, 6, 4]));
        }
        public static int solution(int[] nums)
        {
            int answer = 0;
            for (int i = 0; i < nums.Length - 2; i++)
            {
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        int temp = nums[i] + nums[j] + nums[k];
                        answer++;
                        for (int i1 = 2; i1 < temp; i1++)
                        {
                            if (temp % i1 == 0)
                            {
                                answer--;
                                break;
                            }
                        }
                    }
                }
            }

            return answer;
        }
    }
}
