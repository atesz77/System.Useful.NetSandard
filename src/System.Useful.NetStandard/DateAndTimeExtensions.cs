namespace System
{
    public static class DateAndTimeExtensions
    {
        public static bool IsBetween(this DateTime d, DateTime start, DateTime end)
        {
            return start <= d && d <= end;
        }

        public static bool IsBetweenDate(this DateTime d, DateTime start, DateTime end)
        {
            return start.Date <= d.Date && d.Date <= end.Date;
        }
    }
}