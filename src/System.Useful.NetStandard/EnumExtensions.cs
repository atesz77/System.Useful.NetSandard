namespace System
{
    public static class EnumExt
    {
        public static T ToEnum<T>(this string value)
        {
            return (T)Enum.Parse(typeof(T), value);
        }
    }
}