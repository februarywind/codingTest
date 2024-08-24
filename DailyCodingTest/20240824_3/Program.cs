namespace _20240824_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution([1,2,3,4], [5,6,7,8]));
        }
        public static int solution(int[] A, int[] B)
        {
            int answer = 0;
            Array.Sort(A);
            Array.Sort(B);
            B = B.Reverse().ToArray();
            for (int i = 0; i < A.Length; i++)
            {
                answer += A[i] * B[i];
            }
            return answer;
        }
    }
}
