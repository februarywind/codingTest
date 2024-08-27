namespace _20240827_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution([2, 6, 8, 14]));
        }
        public static int solution(int[] arr)
        {
            int[] temp = (int[])arr.Clone();
            while (true)
            {
                int min = Array.IndexOf(arr, arr.Min());
                arr[min] += temp[min];
                if (arr.Count(x => x == arr[0]) == arr.Length)
                {
                    break;
                }
            }
            return arr[0];
        }
    }
}
