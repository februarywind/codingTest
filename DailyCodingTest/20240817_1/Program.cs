namespace _20240817_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(5, [4, 2], [3, 5]));
        }
        public static int solution(int n, int[] lost, int[] reserve)
        {
            Array.Sort(lost);
            Array.Sort(reserve);

            List<int> _lost = new List<int>(lost.Where(x => Array.IndexOf(reserve, x) == -1));
            Queue<int> _reserve = new Queue<int>(reserve.Where(x => Array.IndexOf(lost, x) == -1));

            int answer = n - _lost.Count;

            while (_reserve.Count > 0)
            {
                int temp = _reserve.Dequeue();
                for (int i = 0; i < _lost.Count; i++)
                {

                    if (temp == _lost[i] - 1 || temp == _lost[i] + 1)
                    {
                        _lost.RemoveAt(i);
                        answer++;
                    }
                    if (_lost.Count == 0)
                        break;
                }

            }


            return answer;
        }
    }
}
