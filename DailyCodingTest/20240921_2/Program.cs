using System.Collections.Generic;

namespace _20240921_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            Queue<int> q = new Queue<int>();

            int n = int.Parse(sr.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string s = sr.ReadLine();
                switch (s[0]) 
                {
                    case 'p':
                        if (s[1] == 'o')
                            sw.WriteLine(q.Count > 0 ? q.Dequeue() : -1);
                        else
                            q.Enqueue(int.Parse(s.Split()[1]));
                        break;
                    case 's':
                        sw.WriteLine(q.Count);
                        break;
                    case 'e':
                        sw.WriteLine(q.Count == 0 ? 1 : 0);
                        break;
                    case 'f':
                        sw.WriteLine(q.Count != 0 ? q.Peek() : -1);
                        break;
                    case 'b':
                        sw.WriteLine(q.Count != 0 ? q.Last() : -1);
                        break;
                }
            }
            sw.Close();
            sr.Close();
        }
    }
}
