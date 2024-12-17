using System;

namespace LevenshteinLibrary
{
    public class LD
    {
        public static int Calc(string s, string t)
        {
            int sl = s.Length;
            int tl = t.Length;
            int[,] d = new int[sl + 1, tl + 1];

            for (int i = 0; i <= sl; i++)
                d[i, 0] = i;

            for (int j = 0; j <= tl; j++)
                d[0, j] = j;

            for (int i = 1; i <= sl; i++)
            {
                for (int j = 1; j <= tl; j++)
                {
                    int c = (s[i - 1] == t[j - 1]) ? 0 : 1;
                    d[i, j] = Math.Min(Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1), d[i - 1, j - 1] + c);
                }
            }

            return d[sl, tl];
        }

        public static int Damerau(string s, string t)
        {
            int sl = s.Length;
            int tl = t.Length;
            int[,] d = new int[sl + 1, tl + 1];

            for (int i = 0; i <= sl; i++)
                d[i, 0] = i;

            for (int j = 0; j <= tl; j++)
                d[0, j] = j;

            for (int i = 1; i <= sl; i++)
            {
                for (int j = 1; j <= tl; j++)
                {
                    int c = (s[i - 1] == t[j - 1]) ? 0 : 1;

                    d[i, j] = Math.Min(Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1), d[i - 1, j - 1] + c);

                    if (i > 1 && j > 1 && s[i - 1] == t[j - 2] && s[i - 2] == t[j - 1])
                    {
                        d[i, j] = Math.Min(d[i, j], d[i - 2, j - 2] + c);
                    }
                }
            }

            return d[sl, tl];
        }
    }

    public class Matcher
    {
        private int th;

        public Matcher(int th)
        {
            this.th = th;
        }

        public bool Match(string a, string b)
        {
            return LD.Calc(a, b) <= th;
        }

        public bool MatchDamerau(string a, string b)
        {
            return LD.Damerau(a, b) <= th;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Максимальное расстояние: ");
            int th = int.Parse(Console.ReadLine());
            var matcher = new Matcher(th);

            Console.Write("1 слово: ");
            string a = Console.ReadLine();

            Console.Write("2 слово: ");
            string b = Console.ReadLine();

            int levDist = LD.Calc(a, b);
            bool matchLev = matcher.Match(a, b);

            Console.WriteLine($"Левенштейн: {levDist}");
            Console.WriteLine($"Совпадают? {matchLev}");

            int damLevDist = LD.Damerau(a, b);
            bool matchDamLev = matcher.MatchDamerau(a, b);

            Console.WriteLine($"Дамерау-Левенштейн: {damLevDist}");
            Console.WriteLine($"Совпадают? {matchDamLev}");
        }
    }
}
