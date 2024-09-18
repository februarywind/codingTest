using System.Text;

namespace _20240918_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<int> set = new HashSet<int>();
            HashSet<int> all = new HashSet<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            List<char> answer = new List<char>();

            StringBuilder sb = new StringBuilder(10);
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            for (int i = 0; i < n; i++)
            {
                sb.Append(Console.ReadLine());
                int a = sb[sb.Length - 2] != ' ' ? (sb[sb.Length - 2] - '0') * 10 : 0;
                int temp = a + sb[sb.Length - 1] - '0';
                switch (sb[0])
                {
                    case 'a':
                        if (sb.Length == 3)
                            set = new HashSet<int>(all);
                        else
                            set.Add(temp);
                        break;
                    case 'r':
                        set.Remove(temp);
                        break;
                    case 't':
                        if (set.Contains(temp))
                            set.Remove(temp);
                        else
                            set.Add(temp);
                        break;
                    case 'e':
                        set.Clear();
                        break;
                    case 'c':
                        answer.Add(set.Contains(temp) ? '1' : '0');
                        break;
                }
                sb.Clear();
            }
            foreach (var item in answer)
            {
                sw.WriteLine(item);
            }
            sw.Close();
        }
    }
}
