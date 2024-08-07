namespace _20240807_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = { { 60, 50 }, { 30, 70 }, { 60, 30 }, {80, 40} };
            solution(a);
        }
        public static int solution(int[,] sizes)
        {
            int[] garo = new int[sizes.GetLength(0)];
            int[] sero = new int[sizes.GetLength(0)];
            for (int i = 0; i < sizes.GetLength(0); i++)
            {
                garo[i] = sizes[i, 0];
                sero[i] = sizes[i, 1];
            }
            while (true)
            {
                int maxGaro = garo.Max();
                int maxGaroIndex = Array.IndexOf(garo, maxGaro);
                int maxSero = sero.Max();
                int maxSeroIndex = Array.IndexOf(sero, maxSero);
                if (maxGaro <= maxSero && maxGaro > sero[maxGaroIndex])
                {
                    int temp = garo[maxGaroIndex];
                    garo[maxGaroIndex] = sero[maxGaroIndex];
                    sero[maxGaroIndex] = temp;
                }
                else if (maxSero <= maxGaro && maxSero > garo[maxSeroIndex])
                {
                    int temp = sero[maxSeroIndex];
                    sero[maxSeroIndex] = garo[maxSeroIndex];
                    garo[maxSeroIndex] = temp;
                }
                else
                {
                    return garo.Max() * sero.Max();
                }
            }
        }
    }
}
