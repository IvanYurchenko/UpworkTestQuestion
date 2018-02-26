using System;

namespace UpworkTestQuestion
{
    static class Operation
    {

        public static Func<int, bool> IsOdd()
        {
            return x => x % 2 != 0;
        }

        public static Func<int, bool> IsPrime()
        {
            return x =>
            {
                if (x == 1) return false;
                if (x == 2) return true;
                if (x % 2 == 0) return false;

                var boundary = (int)Math.Floor(Math.Sqrt(x));

                for (int i = 3; i <= boundary; i += 2)
                {
                    if (x % i == 0) return false;
                }

                return true;
            };
        }

        public static Func<int, bool> IsPalindrome()
        {
            return x =>
            {
                var s = x.ToString();
                for (int i = 0; i < s.Length / 2; i++)
                {
                    if (s[i] != s[s.Length - i - 1]) return false;
                }

                return true;
            };
        }
    }
}
