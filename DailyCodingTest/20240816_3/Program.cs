namespace _20240816_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution("aukks", "wbqd", 5));
        }
        public static string solution(string s, string skip, int index)
        {
            char[] skipChar = skip.ToCharArray();
            char[] chars = s.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                for (int j = 0; j < index; j++)
                {
                    chars[i]++;
                    if (chars[i] > 'z')
                    {
                        chars[i] = 'a';
                    }
                    if (Array.IndexOf(skipChar, chars[i]) != -1)
                    {
                        j--;
                    }
                }
            }
            return new string(chars);
        }
    }
}
