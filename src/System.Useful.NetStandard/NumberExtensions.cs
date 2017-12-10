namespace System
{
    public static class NumberExtensions
    {
        public static int Random(this int i)
        {
            Random r = new System.Random();
            return r.Next(i);
        }

        public static int Random(this int i, int seed)
        {
            Random r = new System.Random(seed);
            return r.Next(i);
        }

        public static void Random(this byte[] array)
        {
            Random r = new System.Random();
            r.NextBytes(array);
        }

        public static void Random(this byte[] array, int seed)
        {
            Random r = new System.Random(seed);
            r.NextBytes(array);
        }

        public static char GetChar(this int i, int offset = 0)
        {
            return (char)(i - offset + 64);
        }

        public static char GetCharOffset(this int i, int offset = 9)
        {
            return i.GetChar(offset);
        }

        public static string GetCharAsString(this int i, int offset = 0)
        {
            return i.GetChar(offset).ToString();
        }

        public static string GetCharOffsetAsString(this int i, int offset = 9)
        {
            return i.GetChar(offset).ToString();
        }
    }
}
