using System.Globalization;

namespace System
{
	public static class ParseExtensions
	{
		/// <summary>
		///  Converts the specified string representation of a logical value to its System.Boolean
		///  equivalent.
		/// </summary>
		/// <param name="s">A string containing the value to convert.</param>
		/// <returns>true if value is equivalent to System.Boolean.TrueString; otherwise, false.</returns>
		/// <exception cref="System.ArgumentNullException">value is null.</exception>
		/// <exception cref="System.FormatException">value is not equivalent to System.Boolean.TrueString or System.Boolean.FalseString.</exception>
		public static bool ParseBool(this string s)
		{
			return bool.Parse(s);
		}

		/// <summary>
		/// Converts the specified string representation of a logical value to its System.Boolean
		/// equivalent. A return value indicates whether the conversion succeeded or failed.
		/// </summary>
		/// <param name="s">A string containing the value to convert.</param>
		/// <returns>if the conversion succeeded, contains true if value is equivalent to System.Boolean.TrueString 
		/// or false if value is equivalent to System.Boolean.FalseString. If the conversion failed, returns null.</returns>
		public static bool? TryParseBool(this string s)
		{
			bool x = false;
			if (bool.TryParse(s, out x))
				return x;
			else
				return null;
		}

		public static char ParseChar(this string s)
		{
			return char.Parse(s);
		}

		public static char? TryParseChar(this string s)
		{
			char x = ' ';
			if (char.TryParse(s, out x))
				return x;
			else
				return null;
		}

		public static byte ParseByte(this string s)
		{
			return byte.Parse(s);
		}

		public static byte? TryParseByte(this string s)
		{
			byte x = 0;
			if (byte.TryParse(s, out x))
				return x;
			else
				return null;
		}

		public static sbyte ParseSByte(this string s)
		{
			return sbyte.Parse(s);
		}

		public static sbyte? TryParseSByte(this string s)
		{
			sbyte x = 0;
			if (sbyte.TryParse(s, out x))
				return x;
			else
				return null;
		}

		public static short ParseShort(this string s)
		{
			return short.Parse(s);
		}

		public static short? TryParseShort(this string s)
		{
			short x = 0;
			if (short.TryParse(s, out x))
				return x;
			else
				return null;
		}

		public static ushort ParseUShort(this string s)
		{
			return ushort.Parse(s);
		}

		public static ushort? TryParseUShort(this string s)
		{
			ushort x = 0;
			if (ushort.TryParse(s, out x))
				return x;
			else
				return null;
		}

		public static int ParseInt(this string s)
		{
			return int.Parse(s);
		}

		public static int? TryParseInt(this string s)
		{
			int x = 0;
			if (int.TryParse(s, out x))
				return x;
			else
				return null;
		}

		public static uint ParseUInt(this string s)
		{
			return uint.Parse(s);
		}

		public static uint? TryParseUInt(this string s)
		{
			uint x = 0;
			if (uint.TryParse(s, out x))
				return x;
			else
				return null;
		}

		public static long ParseLong(this string s)
		{
			return long.Parse(s);
		}

		public static long? TryParseLong(this string s)
		{
			long x = 0;
			if (long.TryParse(s, out x))
				return x;
			else
				return null;
		}

		public static ulong ParseULong(this string s)
		{
			return ulong.Parse(s);
		}

		public static ulong? TryParseULong(this string s)
		{
			ulong x = 0;
			if (ulong.TryParse(s, out x))
				return x;
			else
				return null;
		}

		public static float ParseFloat(this string s)
		{
			return float.Parse(s);
		}

		public static float? TryParseFloat(this string s)
		{
			float x = 0;
			if (float.TryParse(s, out x))
				return x;
			else
				return null;
		}

		public static float ParseFloat(this string s, CultureInfo culture)
		{
			return float.Parse(s, culture.NumberFormat);
		}

		public static float? TryParseFloat(this string s, CultureInfo culture)
		{
			float x = 0;
			if (float.TryParse(s, NumberStyles.Any, culture.NumberFormat, out x))
				return x;
			else
				return null;
		}

		public static float ParseFloatInvariant(this string s)
		{
			return float.Parse(s.Replace(",", "."), CultureInfo.InvariantCulture.NumberFormat);
		}

		public static float? TryParseFloatInvariant(this string s)
		{
			float x = 0;
			if (float.TryParse(s.Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture.NumberFormat, out x))
				return x;
			else
				return null;
		}

		public static float? TryParseFloat(this string s, NumberStyles numberstyle, CultureInfo culture)
		{
			float x = 0;
			if (float.TryParse(s, numberstyle, culture.NumberFormat, out x))
				return x;
			else
				return null;
		}

		public static float ParseFloat(this string s, IFormatProvider format)
		{
			return float.Parse(s, format);
		}

		public static float? TryParseFloat(this string s, IFormatProvider format)
		{
			float x = 0;
			if (float.TryParse(s, NumberStyles.Any, format, out x))
				return x;
			else
				return null;
		}

		public static float? TryParseFloat(this string s, NumberStyles numberstyle, IFormatProvider format)
		{
			float x = 0;
			if (float.TryParse(s, numberstyle, format, out x))
				return x;
			else
				return null;
		}

		public static double ParseDouble(this string s)
		{
			return double.Parse(s);
		}

		public static double? TryParseDouble(this string s)
		{
			double x = 0;
			if (double.TryParse(s, out x))
				return x;
			else
				return null;
		}

		public static double ParseDouble(this string s, CultureInfo culture)
		{
			return double.Parse(s, culture.NumberFormat);
		}

		public static double? TryParseDouble(this string s, CultureInfo culture)
		{
			double x = 0;
			if (double.TryParse(s, NumberStyles.Any, culture.NumberFormat, out x))
				return x;
			else
				return null;
		}

		public static double ParseDoubleInvariant(this string s)
		{
			return double.Parse(s.Replace(",", "."), CultureInfo.InvariantCulture.NumberFormat);
		}

		public static double? TryParseDoubleInvariant(this string s)
		{
			double x = 0;
			if (double.TryParse(s.Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture.NumberFormat, out x))
				return x;
			else
				return null;
		}

		public static double? TryParseDouble(this string s, NumberStyles numberstyle, CultureInfo culture)
		{
			double x = 0;
			if (double.TryParse(s, numberstyle, culture.NumberFormat, out x))
				return x;
			else
				return null;
		}

		public static double ParseDouble(this string s, IFormatProvider format)
		{
			return double.Parse(s, format);
		}

		public static double? TryParseDouble(this string s, IFormatProvider format)
		{
			double x = 0;
			if (double.TryParse(s, NumberStyles.Any, format, out x))
				return x;
			else
				return null;
		}

		public static double? TryParseDouble(this string s, NumberStyles numberstyle, IFormatProvider format)
		{
			double x = 0;
			if (double.TryParse(s, numberstyle, format, out x))
				return x;
			else
				return null;
		}

		public static decimal ParseDecimal(this string s)
		{
			return decimal.Parse(s);
		}

		public static decimal? TryParseDecimal(this string s)
		{
			decimal x = 0;
			if (decimal.TryParse(s, out x))
				return x;
			else
				return null;
		}

		public static decimal ParseDecimal(this string s, CultureInfo culture)
		{
			return decimal.Parse(s, culture.NumberFormat);
		}

		public static decimal? TryParseDecimal(this string s, CultureInfo culture)
		{
			decimal x = 0;
			if (decimal.TryParse(s, NumberStyles.Any, culture.NumberFormat, out x))
				return x;
			else
				return null;
		}

		public static decimal ParseDecimalInvariant(this string s)
		{
			return decimal.Parse(s.Replace(",", "."), CultureInfo.InvariantCulture.NumberFormat);
		}

		public static decimal? TryParseDecimalInvariant(this string s)
		{
			decimal x = 0;
			if (decimal.TryParse(s.Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture.NumberFormat, out x))
				return x;
			else
				return null;
		}

		public static decimal? TryParseDecimal(this string s, NumberStyles numberstyle, CultureInfo culture)
		{
			decimal x = 0;
			if (decimal.TryParse(s, numberstyle, culture.NumberFormat, out x))
				return x;
			else
				return null;
		}

		public static decimal ParseDecimal(this string s, IFormatProvider format)
		{
			return decimal.Parse(s, format);
		}

		public static decimal? TryParseDecimal(this string s, IFormatProvider format)
		{
			decimal x = 0;
			if (decimal.TryParse(s, NumberStyles.Any, format, out x))
				return x;
			else
				return null;
		}

		public static decimal? TryParseDecimal(this string s, NumberStyles numberstyle, IFormatProvider format)
		{
			decimal x = 0;
			if (decimal.TryParse(s, numberstyle, format, out x))
				return x;
			else
				return null;
		}




        public static Guid ParseGuid(this string s)
        {
            return Guid.Parse(s);
        }

        public static Guid? TryParseGuid(this string s)
        {
            Guid x = Guid.Empty;
            if (Guid.TryParse(s, out x))
                return x;
            else
                return null;
        }
    }
}
