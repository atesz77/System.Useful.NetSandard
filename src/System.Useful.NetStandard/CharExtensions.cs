namespace System
{
    public static class CharExtensions2
    {
        public static int GetNumber(this char c, int offset = 0)
        {
            return (int)c.ToString().ToUpper()[0] - 64 + offset;
        }

        public static int GetNumberOffset(this char c, int offset = 9)
        {
            return c.GetNumber(offset);
        }
    }
}