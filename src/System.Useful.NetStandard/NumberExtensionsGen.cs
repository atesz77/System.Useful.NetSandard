
namespace System
{
	public static class NumberExtensionsGen
    {

		public static bool Between(this byte num, byte start, byte end)
        {
            return start <= num && num <= end;
        }
	

		public static bool Between(this sbyte num, sbyte start, sbyte end)
        {
            return start <= num && num <= end;
        }
	

		public static bool Between(this short num, short start, short end)
        {
            return start <= num && num <= end;
        }
	

		public static bool Between(this ushort num, ushort start, ushort end)
        {
            return start <= num && num <= end;
        }
	

		public static bool Between(this int num, int start, int end)
        {
            return start <= num && num <= end;
        }
	

		public static bool Between(this uint num, uint start, uint end)
        {
            return start <= num && num <= end;
        }
	

		public static bool Between(this long num, long start, long end)
        {
            return start <= num && num <= end;
        }
	

		public static bool Between(this ulong num, ulong start, ulong end)
        {
            return start <= num && num <= end;
        }
	

		public static bool Between(this float num, float start, float end)
        {
            return start <= num && num <= end;
        }
	

		public static bool Between(this double num, double start, double end)
        {
            return start <= num && num <= end;
        }
	

		public static bool Between(this decimal num, decimal start, decimal end)
        {
            return start <= num && num <= end;
        }
	

		public static void Times(this byte count, Action act)
        {
            for (byte i = 0; i < count; i++)
            {
                act();
            }
        }

        public static void Times(this byte count, Action<byte> act)
        {
            for (byte i = 0; i < count; i++)
            {
            	var locali = i;
                act(locali);
            }
        }
	

		public static void Times(this sbyte count, Action act)
        {
            for (sbyte i = 0; i < count; i++)
            {
                act();
            }
        }

        public static void Times(this sbyte count, Action<sbyte> act)
        {
            for (sbyte i = 0; i < count; i++)
            {
            	var locali = i;
                act(locali);
            }
        }
	

		public static void Times(this short count, Action act)
        {
            for (short i = 0; i < count; i++)
            {
                act();
            }
        }

        public static void Times(this short count, Action<short> act)
        {
            for (short i = 0; i < count; i++)
            {
            	var locali = i;
                act(locali);
            }
        }
	

		public static void Times(this ushort count, Action act)
        {
            for (ushort i = 0; i < count; i++)
            {
                act();
            }
        }

        public static void Times(this ushort count, Action<ushort> act)
        {
            for (ushort i = 0; i < count; i++)
            {
            	var locali = i;
                act(locali);
            }
        }
	

		public static void Times(this int count, Action act)
        {
            for (int i = 0; i < count; i++)
            {
                act();
            }
        }

        public static void Times(this int count, Action<int> act)
        {
            for (int i = 0; i < count; i++)
            {
            	var locali = i;
                act(locali);
            }
        }
	

		public static void Times(this uint count, Action act)
        {
            for (uint i = 0; i < count; i++)
            {
                act();
            }
        }

        public static void Times(this uint count, Action<uint> act)
        {
            for (uint i = 0; i < count; i++)
            {
            	var locali = i;
                act(locali);
            }
        }
	

		public static void Times(this long count, Action act)
        {
            for (long i = 0; i < count; i++)
            {
                act();
            }
        }

        public static void Times(this long count, Action<long> act)
        {
            for (long i = 0; i < count; i++)
            {
            	var locali = i;
                act(locali);
            }
        }
	

		public static void Times(this ulong count, Action act)
        {
            for (ulong i = 0; i < count; i++)
            {
                act();
            }
        }

        public static void Times(this ulong count, Action<ulong> act)
        {
            for (ulong i = 0; i < count; i++)
            {
            	var locali = i;
                act(locali);
            }
        }
	
    }
}
