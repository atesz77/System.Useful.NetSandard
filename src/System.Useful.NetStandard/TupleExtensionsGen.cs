
namespace System
{
	public class tuple<T1, T2>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
		}

		public static implicit operator (T1, T2)(tuple<T1, T2> original)
		{
			return (original.Item1, original.Item2);
		}

		public static implicit operator tuple<T1, T2>((T1, T2) original)
		{
			return new tuple<T1, T2>(original.Item1, original.Item2);
		}

	}

	public class tuple<T1, T2, T3>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2), T3 item3 = default(T3))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
		}

		public static implicit operator (T1, T2, T3)(tuple<T1, T2, T3> original)
		{
			return (original.Item1, original.Item2, original.Item3);
		}

		public static implicit operator tuple<T1, T2, T3>((T1, T2, T3) original)
		{
			return new tuple<T1, T2, T3>(original.Item1, original.Item2, original.Item3);
		}

	}

	public class tuple<T1, T2, T3, T4>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2), T3 item3 = default(T3), T4 item4 = default(T4))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
		}

		public static implicit operator (T1, T2, T3, T4)(tuple<T1, T2, T3, T4> original)
		{
			return (original.Item1, original.Item2, original.Item3, original.Item4);
		}

		public static implicit operator tuple<T1, T2, T3, T4>((T1, T2, T3, T4) original)
		{
			return new tuple<T1, T2, T3, T4>(original.Item1, original.Item2, original.Item3, original.Item4);
		}

	}

	public class tuple<T1, T2, T3, T4, T5>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2), T3 item3 = default(T3), T4 item4 = default(T4), T5 item5 = default(T5))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
		}

		public static implicit operator (T1, T2, T3, T4, T5)(tuple<T1, T2, T3, T4, T5> original)
		{
			return (original.Item1, original.Item2, original.Item3, original.Item4, original.Item5);
		}

		public static implicit operator tuple<T1, T2, T3, T4, T5>((T1, T2, T3, T4, T5) original)
		{
			return new tuple<T1, T2, T3, T4, T5>(original.Item1, original.Item2, original.Item3, original.Item4, original.Item5);
		}

	}

	public class tuple<T1, T2, T3, T4, T5, T6>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2), T3 item3 = default(T3), T4 item4 = default(T4), T5 item5 = default(T5), T6 item6 = default(T6))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
			this.Item6 = item6;
		}

		public static implicit operator (T1, T2, T3, T4, T5, T6)(tuple<T1, T2, T3, T4, T5, T6> original)
		{
			return (original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6);
		}

		public static implicit operator tuple<T1, T2, T3, T4, T5, T6>((T1, T2, T3, T4, T5, T6) original)
		{
			return new tuple<T1, T2, T3, T4, T5, T6>(original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6);
		}

	}

	public class tuple<T1, T2, T3, T4, T5, T6, T7>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2), T3 item3 = default(T3), T4 item4 = default(T4), T5 item5 = default(T5), T6 item6 = default(T6), T7 item7 = default(T7))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
			this.Item6 = item6;
			this.Item7 = item7;
		}

		public static implicit operator (T1, T2, T3, T4, T5, T6, T7)(tuple<T1, T2, T3, T4, T5, T6, T7> original)
		{
			return (original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7);
		}

		public static implicit operator tuple<T1, T2, T3, T4, T5, T6, T7>((T1, T2, T3, T4, T5, T6, T7) original)
		{
			return new tuple<T1, T2, T3, T4, T5, T6, T7>(original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7);
		}

	}

	public class tuple<T1, T2, T3, T4, T5, T6, T7, T8>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2), T3 item3 = default(T3), T4 item4 = default(T4), T5 item5 = default(T5), T6 item6 = default(T6), T7 item7 = default(T7), T8 item8 = default(T8))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
			this.Item6 = item6;
			this.Item7 = item7;
			this.Item8 = item8;
		}

		public static implicit operator (T1, T2, T3, T4, T5, T6, T7, T8)(tuple<T1, T2, T3, T4, T5, T6, T7, T8> original)
		{
			return (original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8);
		}

		public static implicit operator tuple<T1, T2, T3, T4, T5, T6, T7, T8>((T1, T2, T3, T4, T5, T6, T7, T8) original)
		{
			return new tuple<T1, T2, T3, T4, T5, T6, T7, T8>(original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8);
		}

	}

	public class tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2), T3 item3 = default(T3), T4 item4 = default(T4), T5 item5 = default(T5), T6 item6 = default(T6), T7 item7 = default(T7), T8 item8 = default(T8), T9 item9 = default(T9))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
			this.Item6 = item6;
			this.Item7 = item7;
			this.Item8 = item8;
			this.Item9 = item9;
		}

		public static implicit operator (T1, T2, T3, T4, T5, T6, T7, T8, T9)(tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9> original)
		{
			return (original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9);
		}

		public static implicit operator tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9>((T1, T2, T3, T4, T5, T6, T7, T8, T9) original)
		{
			return new tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9>(original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9);
		}

	}

	public class tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2), T3 item3 = default(T3), T4 item4 = default(T4), T5 item5 = default(T5), T6 item6 = default(T6), T7 item7 = default(T7), T8 item8 = default(T8), T9 item9 = default(T9), T10 item10 = default(T10))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
			this.Item6 = item6;
			this.Item7 = item7;
			this.Item8 = item8;
			this.Item9 = item9;
			this.Item10 = item10;
		}

		public static implicit operator (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)(tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> original)
		{
			return (original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10);
		}

		public static implicit operator tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>((T1, T2, T3, T4, T5, T6, T7, T8, T9, T10) original)
		{
			return new tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10);
		}

	}

	public class tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2), T3 item3 = default(T3), T4 item4 = default(T4), T5 item5 = default(T5), T6 item6 = default(T6), T7 item7 = default(T7), T8 item8 = default(T8), T9 item9 = default(T9), T10 item10 = default(T10), T11 item11 = default(T11))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
			this.Item6 = item6;
			this.Item7 = item7;
			this.Item8 = item8;
			this.Item9 = item9;
			this.Item10 = item10;
			this.Item11 = item11;
		}

		public static implicit operator (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)(tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> original)
		{
			return (original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11);
		}

		public static implicit operator tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>((T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11) original)
		{
			return new tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11);
		}

	}

	public class tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2), T3 item3 = default(T3), T4 item4 = default(T4), T5 item5 = default(T5), T6 item6 = default(T6), T7 item7 = default(T7), T8 item8 = default(T8), T9 item9 = default(T9), T10 item10 = default(T10), T11 item11 = default(T11), T12 item12 = default(T12))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
			this.Item6 = item6;
			this.Item7 = item7;
			this.Item8 = item8;
			this.Item9 = item9;
			this.Item10 = item10;
			this.Item11 = item11;
			this.Item12 = item12;
		}

		public static implicit operator (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)(tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> original)
		{
			return (original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12);
		}

		public static implicit operator tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>((T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12) original)
		{
			return new tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12);
		}

	}

	public class tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2), T3 item3 = default(T3), T4 item4 = default(T4), T5 item5 = default(T5), T6 item6 = default(T6), T7 item7 = default(T7), T8 item8 = default(T8), T9 item9 = default(T9), T10 item10 = default(T10), T11 item11 = default(T11), T12 item12 = default(T12), T13 item13 = default(T13))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
			this.Item6 = item6;
			this.Item7 = item7;
			this.Item8 = item8;
			this.Item9 = item9;
			this.Item10 = item10;
			this.Item11 = item11;
			this.Item12 = item12;
			this.Item13 = item13;
		}

		public static implicit operator (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)(tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> original)
		{
			return (original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13);
		}

		public static implicit operator tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>((T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13) original)
		{
			return new tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13);
		}

	}

	public class tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2), T3 item3 = default(T3), T4 item4 = default(T4), T5 item5 = default(T5), T6 item6 = default(T6), T7 item7 = default(T7), T8 item8 = default(T8), T9 item9 = default(T9), T10 item10 = default(T10), T11 item11 = default(T11), T12 item12 = default(T12), T13 item13 = default(T13), T14 item14 = default(T14))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
			this.Item6 = item6;
			this.Item7 = item7;
			this.Item8 = item8;
			this.Item9 = item9;
			this.Item10 = item10;
			this.Item11 = item11;
			this.Item12 = item12;
			this.Item13 = item13;
			this.Item14 = item14;
		}

		public static implicit operator (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)(tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> original)
		{
			return (original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14);
		}

		public static implicit operator tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>((T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14) original)
		{
			return new tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14);
		}

	}

	public class tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2), T3 item3 = default(T3), T4 item4 = default(T4), T5 item5 = default(T5), T6 item6 = default(T6), T7 item7 = default(T7), T8 item8 = default(T8), T9 item9 = default(T9), T10 item10 = default(T10), T11 item11 = default(T11), T12 item12 = default(T12), T13 item13 = default(T13), T14 item14 = default(T14), T15 item15 = default(T15))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
			this.Item6 = item6;
			this.Item7 = item7;
			this.Item8 = item8;
			this.Item9 = item9;
			this.Item10 = item10;
			this.Item11 = item11;
			this.Item12 = item12;
			this.Item13 = item13;
			this.Item14 = item14;
			this.Item15 = item15;
		}

		public static implicit operator (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15)(tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> original)
		{
			return (original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15);
		}

		public static implicit operator tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>((T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) original)
		{
			return new tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15);
		}

	}

	public class tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2), T3 item3 = default(T3), T4 item4 = default(T4), T5 item5 = default(T5), T6 item6 = default(T6), T7 item7 = default(T7), T8 item8 = default(T8), T9 item9 = default(T9), T10 item10 = default(T10), T11 item11 = default(T11), T12 item12 = default(T12), T13 item13 = default(T13), T14 item14 = default(T14), T15 item15 = default(T15), T16 item16 = default(T16))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
			this.Item6 = item6;
			this.Item7 = item7;
			this.Item8 = item8;
			this.Item9 = item9;
			this.Item10 = item10;
			this.Item11 = item11;
			this.Item12 = item12;
			this.Item13 = item13;
			this.Item14 = item14;
			this.Item15 = item15;
			this.Item16 = item16;
		}

		public static implicit operator (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16)(tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> original)
		{
			return (original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16);
		}

		public static implicit operator tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>((T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) original)
		{
			return new tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16);
		}

	}

	public class tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2), T3 item3 = default(T3), T4 item4 = default(T4), T5 item5 = default(T5), T6 item6 = default(T6), T7 item7 = default(T7), T8 item8 = default(T8), T9 item9 = default(T9), T10 item10 = default(T10), T11 item11 = default(T11), T12 item12 = default(T12), T13 item13 = default(T13), T14 item14 = default(T14), T15 item15 = default(T15), T16 item16 = default(T16), T17 item17 = default(T17))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
			this.Item6 = item6;
			this.Item7 = item7;
			this.Item8 = item8;
			this.Item9 = item9;
			this.Item10 = item10;
			this.Item11 = item11;
			this.Item12 = item12;
			this.Item13 = item13;
			this.Item14 = item14;
			this.Item15 = item15;
			this.Item16 = item16;
			this.Item17 = item17;
		}

		public static implicit operator (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17)(tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> original)
		{
			return (original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17);
		}

		public static implicit operator tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>((T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17) original)
		{
			return new tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17);
		}

	}

	public class tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }
		public T18 Item18 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2), T3 item3 = default(T3), T4 item4 = default(T4), T5 item5 = default(T5), T6 item6 = default(T6), T7 item7 = default(T7), T8 item8 = default(T8), T9 item9 = default(T9), T10 item10 = default(T10), T11 item11 = default(T11), T12 item12 = default(T12), T13 item13 = default(T13), T14 item14 = default(T14), T15 item15 = default(T15), T16 item16 = default(T16), T17 item17 = default(T17), T18 item18 = default(T18))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
			this.Item6 = item6;
			this.Item7 = item7;
			this.Item8 = item8;
			this.Item9 = item9;
			this.Item10 = item10;
			this.Item11 = item11;
			this.Item12 = item12;
			this.Item13 = item13;
			this.Item14 = item14;
			this.Item15 = item15;
			this.Item16 = item16;
			this.Item17 = item17;
			this.Item18 = item18;
		}

		public static implicit operator (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18)(tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> original)
		{
			return (original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18);
		}

		public static implicit operator tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>((T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18) original)
		{
			return new tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18);
		}

	}

	public class tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }
		public T18 Item18 { get; set; }
		public T19 Item19 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2), T3 item3 = default(T3), T4 item4 = default(T4), T5 item5 = default(T5), T6 item6 = default(T6), T7 item7 = default(T7), T8 item8 = default(T8), T9 item9 = default(T9), T10 item10 = default(T10), T11 item11 = default(T11), T12 item12 = default(T12), T13 item13 = default(T13), T14 item14 = default(T14), T15 item15 = default(T15), T16 item16 = default(T16), T17 item17 = default(T17), T18 item18 = default(T18), T19 item19 = default(T19))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
			this.Item6 = item6;
			this.Item7 = item7;
			this.Item8 = item8;
			this.Item9 = item9;
			this.Item10 = item10;
			this.Item11 = item11;
			this.Item12 = item12;
			this.Item13 = item13;
			this.Item14 = item14;
			this.Item15 = item15;
			this.Item16 = item16;
			this.Item17 = item17;
			this.Item18 = item18;
			this.Item19 = item19;
		}

		public static implicit operator (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19)(tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> original)
		{
			return (original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19);
		}

		public static implicit operator tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>((T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19) original)
		{
			return new tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19);
		}

	}

	public class tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }
		public T18 Item18 { get; set; }
		public T19 Item19 { get; set; }
		public T20 Item20 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2), T3 item3 = default(T3), T4 item4 = default(T4), T5 item5 = default(T5), T6 item6 = default(T6), T7 item7 = default(T7), T8 item8 = default(T8), T9 item9 = default(T9), T10 item10 = default(T10), T11 item11 = default(T11), T12 item12 = default(T12), T13 item13 = default(T13), T14 item14 = default(T14), T15 item15 = default(T15), T16 item16 = default(T16), T17 item17 = default(T17), T18 item18 = default(T18), T19 item19 = default(T19), T20 item20 = default(T20))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
			this.Item6 = item6;
			this.Item7 = item7;
			this.Item8 = item8;
			this.Item9 = item9;
			this.Item10 = item10;
			this.Item11 = item11;
			this.Item12 = item12;
			this.Item13 = item13;
			this.Item14 = item14;
			this.Item15 = item15;
			this.Item16 = item16;
			this.Item17 = item17;
			this.Item18 = item18;
			this.Item19 = item19;
			this.Item20 = item20;
		}

		public static implicit operator (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20)(tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> original)
		{
			return (original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20);
		}

		public static implicit operator tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>((T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20) original)
		{
			return new tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20);
		}

	}

	public class tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }
		public T18 Item18 { get; set; }
		public T19 Item19 { get; set; }
		public T20 Item20 { get; set; }
		public T21 Item21 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2), T3 item3 = default(T3), T4 item4 = default(T4), T5 item5 = default(T5), T6 item6 = default(T6), T7 item7 = default(T7), T8 item8 = default(T8), T9 item9 = default(T9), T10 item10 = default(T10), T11 item11 = default(T11), T12 item12 = default(T12), T13 item13 = default(T13), T14 item14 = default(T14), T15 item15 = default(T15), T16 item16 = default(T16), T17 item17 = default(T17), T18 item18 = default(T18), T19 item19 = default(T19), T20 item20 = default(T20), T21 item21 = default(T21))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
			this.Item6 = item6;
			this.Item7 = item7;
			this.Item8 = item8;
			this.Item9 = item9;
			this.Item10 = item10;
			this.Item11 = item11;
			this.Item12 = item12;
			this.Item13 = item13;
			this.Item14 = item14;
			this.Item15 = item15;
			this.Item16 = item16;
			this.Item17 = item17;
			this.Item18 = item18;
			this.Item19 = item19;
			this.Item20 = item20;
			this.Item21 = item21;
		}

		public static implicit operator (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21)(tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21> original)
		{
			return (original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21);
		}

		public static implicit operator tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>((T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21) original)
		{
			return new tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21);
		}

	}

	public class tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }
		public T18 Item18 { get; set; }
		public T19 Item19 { get; set; }
		public T20 Item20 { get; set; }
		public T21 Item21 { get; set; }
		public T22 Item22 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2), T3 item3 = default(T3), T4 item4 = default(T4), T5 item5 = default(T5), T6 item6 = default(T6), T7 item7 = default(T7), T8 item8 = default(T8), T9 item9 = default(T9), T10 item10 = default(T10), T11 item11 = default(T11), T12 item12 = default(T12), T13 item13 = default(T13), T14 item14 = default(T14), T15 item15 = default(T15), T16 item16 = default(T16), T17 item17 = default(T17), T18 item18 = default(T18), T19 item19 = default(T19), T20 item20 = default(T20), T21 item21 = default(T21), T22 item22 = default(T22))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
			this.Item6 = item6;
			this.Item7 = item7;
			this.Item8 = item8;
			this.Item9 = item9;
			this.Item10 = item10;
			this.Item11 = item11;
			this.Item12 = item12;
			this.Item13 = item13;
			this.Item14 = item14;
			this.Item15 = item15;
			this.Item16 = item16;
			this.Item17 = item17;
			this.Item18 = item18;
			this.Item19 = item19;
			this.Item20 = item20;
			this.Item21 = item21;
			this.Item22 = item22;
		}

		public static implicit operator (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22)(tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> original)
		{
			return (original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22);
		}

		public static implicit operator tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>((T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22) original)
		{
			return new tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22);
		}

	}

	public class tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }
		public T18 Item18 { get; set; }
		public T19 Item19 { get; set; }
		public T20 Item20 { get; set; }
		public T21 Item21 { get; set; }
		public T22 Item22 { get; set; }
		public T23 Item23 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2), T3 item3 = default(T3), T4 item4 = default(T4), T5 item5 = default(T5), T6 item6 = default(T6), T7 item7 = default(T7), T8 item8 = default(T8), T9 item9 = default(T9), T10 item10 = default(T10), T11 item11 = default(T11), T12 item12 = default(T12), T13 item13 = default(T13), T14 item14 = default(T14), T15 item15 = default(T15), T16 item16 = default(T16), T17 item17 = default(T17), T18 item18 = default(T18), T19 item19 = default(T19), T20 item20 = default(T20), T21 item21 = default(T21), T22 item22 = default(T22), T23 item23 = default(T23))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
			this.Item6 = item6;
			this.Item7 = item7;
			this.Item8 = item8;
			this.Item9 = item9;
			this.Item10 = item10;
			this.Item11 = item11;
			this.Item12 = item12;
			this.Item13 = item13;
			this.Item14 = item14;
			this.Item15 = item15;
			this.Item16 = item16;
			this.Item17 = item17;
			this.Item18 = item18;
			this.Item19 = item19;
			this.Item20 = item20;
			this.Item21 = item21;
			this.Item22 = item22;
			this.Item23 = item23;
		}

		public static implicit operator (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23)(tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> original)
		{
			return (original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23);
		}

		public static implicit operator tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>((T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23) original)
		{
			return new tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23);
		}

	}

	public class tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }
		public T18 Item18 { get; set; }
		public T19 Item19 { get; set; }
		public T20 Item20 { get; set; }
		public T21 Item21 { get; set; }
		public T22 Item22 { get; set; }
		public T23 Item23 { get; set; }
		public T24 Item24 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2), T3 item3 = default(T3), T4 item4 = default(T4), T5 item5 = default(T5), T6 item6 = default(T6), T7 item7 = default(T7), T8 item8 = default(T8), T9 item9 = default(T9), T10 item10 = default(T10), T11 item11 = default(T11), T12 item12 = default(T12), T13 item13 = default(T13), T14 item14 = default(T14), T15 item15 = default(T15), T16 item16 = default(T16), T17 item17 = default(T17), T18 item18 = default(T18), T19 item19 = default(T19), T20 item20 = default(T20), T21 item21 = default(T21), T22 item22 = default(T22), T23 item23 = default(T23), T24 item24 = default(T24))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
			this.Item6 = item6;
			this.Item7 = item7;
			this.Item8 = item8;
			this.Item9 = item9;
			this.Item10 = item10;
			this.Item11 = item11;
			this.Item12 = item12;
			this.Item13 = item13;
			this.Item14 = item14;
			this.Item15 = item15;
			this.Item16 = item16;
			this.Item17 = item17;
			this.Item18 = item18;
			this.Item19 = item19;
			this.Item20 = item20;
			this.Item21 = item21;
			this.Item22 = item22;
			this.Item23 = item23;
			this.Item24 = item24;
		}

		public static implicit operator (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24)(tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24> original)
		{
			return (original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24);
		}

		public static implicit operator tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>((T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24) original)
		{
			return new tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24);
		}

	}

	public class tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }
		public T18 Item18 { get; set; }
		public T19 Item19 { get; set; }
		public T20 Item20 { get; set; }
		public T21 Item21 { get; set; }
		public T22 Item22 { get; set; }
		public T23 Item23 { get; set; }
		public T24 Item24 { get; set; }
		public T25 Item25 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2), T3 item3 = default(T3), T4 item4 = default(T4), T5 item5 = default(T5), T6 item6 = default(T6), T7 item7 = default(T7), T8 item8 = default(T8), T9 item9 = default(T9), T10 item10 = default(T10), T11 item11 = default(T11), T12 item12 = default(T12), T13 item13 = default(T13), T14 item14 = default(T14), T15 item15 = default(T15), T16 item16 = default(T16), T17 item17 = default(T17), T18 item18 = default(T18), T19 item19 = default(T19), T20 item20 = default(T20), T21 item21 = default(T21), T22 item22 = default(T22), T23 item23 = default(T23), T24 item24 = default(T24), T25 item25 = default(T25))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
			this.Item6 = item6;
			this.Item7 = item7;
			this.Item8 = item8;
			this.Item9 = item9;
			this.Item10 = item10;
			this.Item11 = item11;
			this.Item12 = item12;
			this.Item13 = item13;
			this.Item14 = item14;
			this.Item15 = item15;
			this.Item16 = item16;
			this.Item17 = item17;
			this.Item18 = item18;
			this.Item19 = item19;
			this.Item20 = item20;
			this.Item21 = item21;
			this.Item22 = item22;
			this.Item23 = item23;
			this.Item24 = item24;
			this.Item25 = item25;
		}

		public static implicit operator (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25)(tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25> original)
		{
			return (original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25);
		}

		public static implicit operator tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>((T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25) original)
		{
			return new tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25);
		}

	}

	public class tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }
		public T18 Item18 { get; set; }
		public T19 Item19 { get; set; }
		public T20 Item20 { get; set; }
		public T21 Item21 { get; set; }
		public T22 Item22 { get; set; }
		public T23 Item23 { get; set; }
		public T24 Item24 { get; set; }
		public T25 Item25 { get; set; }
		public T26 Item26 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2), T3 item3 = default(T3), T4 item4 = default(T4), T5 item5 = default(T5), T6 item6 = default(T6), T7 item7 = default(T7), T8 item8 = default(T8), T9 item9 = default(T9), T10 item10 = default(T10), T11 item11 = default(T11), T12 item12 = default(T12), T13 item13 = default(T13), T14 item14 = default(T14), T15 item15 = default(T15), T16 item16 = default(T16), T17 item17 = default(T17), T18 item18 = default(T18), T19 item19 = default(T19), T20 item20 = default(T20), T21 item21 = default(T21), T22 item22 = default(T22), T23 item23 = default(T23), T24 item24 = default(T24), T25 item25 = default(T25), T26 item26 = default(T26))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
			this.Item6 = item6;
			this.Item7 = item7;
			this.Item8 = item8;
			this.Item9 = item9;
			this.Item10 = item10;
			this.Item11 = item11;
			this.Item12 = item12;
			this.Item13 = item13;
			this.Item14 = item14;
			this.Item15 = item15;
			this.Item16 = item16;
			this.Item17 = item17;
			this.Item18 = item18;
			this.Item19 = item19;
			this.Item20 = item20;
			this.Item21 = item21;
			this.Item22 = item22;
			this.Item23 = item23;
			this.Item24 = item24;
			this.Item25 = item25;
			this.Item26 = item26;
		}

		public static implicit operator (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26)(tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26> original)
		{
			return (original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26);
		}

		public static implicit operator tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>((T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26) original)
		{
			return new tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26);
		}

	}

	public class tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }
		public T18 Item18 { get; set; }
		public T19 Item19 { get; set; }
		public T20 Item20 { get; set; }
		public T21 Item21 { get; set; }
		public T22 Item22 { get; set; }
		public T23 Item23 { get; set; }
		public T24 Item24 { get; set; }
		public T25 Item25 { get; set; }
		public T26 Item26 { get; set; }
		public T27 Item27 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2), T3 item3 = default(T3), T4 item4 = default(T4), T5 item5 = default(T5), T6 item6 = default(T6), T7 item7 = default(T7), T8 item8 = default(T8), T9 item9 = default(T9), T10 item10 = default(T10), T11 item11 = default(T11), T12 item12 = default(T12), T13 item13 = default(T13), T14 item14 = default(T14), T15 item15 = default(T15), T16 item16 = default(T16), T17 item17 = default(T17), T18 item18 = default(T18), T19 item19 = default(T19), T20 item20 = default(T20), T21 item21 = default(T21), T22 item22 = default(T22), T23 item23 = default(T23), T24 item24 = default(T24), T25 item25 = default(T25), T26 item26 = default(T26), T27 item27 = default(T27))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
			this.Item6 = item6;
			this.Item7 = item7;
			this.Item8 = item8;
			this.Item9 = item9;
			this.Item10 = item10;
			this.Item11 = item11;
			this.Item12 = item12;
			this.Item13 = item13;
			this.Item14 = item14;
			this.Item15 = item15;
			this.Item16 = item16;
			this.Item17 = item17;
			this.Item18 = item18;
			this.Item19 = item19;
			this.Item20 = item20;
			this.Item21 = item21;
			this.Item22 = item22;
			this.Item23 = item23;
			this.Item24 = item24;
			this.Item25 = item25;
			this.Item26 = item26;
			this.Item27 = item27;
		}

		public static implicit operator (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27)(tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27> original)
		{
			return (original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26, original.Item27);
		}

		public static implicit operator tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>((T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27) original)
		{
			return new tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26, original.Item27);
		}

	}

	public class tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }
		public T18 Item18 { get; set; }
		public T19 Item19 { get; set; }
		public T20 Item20 { get; set; }
		public T21 Item21 { get; set; }
		public T22 Item22 { get; set; }
		public T23 Item23 { get; set; }
		public T24 Item24 { get; set; }
		public T25 Item25 { get; set; }
		public T26 Item26 { get; set; }
		public T27 Item27 { get; set; }
		public T28 Item28 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2), T3 item3 = default(T3), T4 item4 = default(T4), T5 item5 = default(T5), T6 item6 = default(T6), T7 item7 = default(T7), T8 item8 = default(T8), T9 item9 = default(T9), T10 item10 = default(T10), T11 item11 = default(T11), T12 item12 = default(T12), T13 item13 = default(T13), T14 item14 = default(T14), T15 item15 = default(T15), T16 item16 = default(T16), T17 item17 = default(T17), T18 item18 = default(T18), T19 item19 = default(T19), T20 item20 = default(T20), T21 item21 = default(T21), T22 item22 = default(T22), T23 item23 = default(T23), T24 item24 = default(T24), T25 item25 = default(T25), T26 item26 = default(T26), T27 item27 = default(T27), T28 item28 = default(T28))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
			this.Item6 = item6;
			this.Item7 = item7;
			this.Item8 = item8;
			this.Item9 = item9;
			this.Item10 = item10;
			this.Item11 = item11;
			this.Item12 = item12;
			this.Item13 = item13;
			this.Item14 = item14;
			this.Item15 = item15;
			this.Item16 = item16;
			this.Item17 = item17;
			this.Item18 = item18;
			this.Item19 = item19;
			this.Item20 = item20;
			this.Item21 = item21;
			this.Item22 = item22;
			this.Item23 = item23;
			this.Item24 = item24;
			this.Item25 = item25;
			this.Item26 = item26;
			this.Item27 = item27;
			this.Item28 = item28;
		}

		public static implicit operator (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28)(tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> original)
		{
			return (original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26, original.Item27, original.Item28);
		}

		public static implicit operator tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>((T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28) original)
		{
			return new tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26, original.Item27, original.Item28);
		}

	}

	public class tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }
		public T18 Item18 { get; set; }
		public T19 Item19 { get; set; }
		public T20 Item20 { get; set; }
		public T21 Item21 { get; set; }
		public T22 Item22 { get; set; }
		public T23 Item23 { get; set; }
		public T24 Item24 { get; set; }
		public T25 Item25 { get; set; }
		public T26 Item26 { get; set; }
		public T27 Item27 { get; set; }
		public T28 Item28 { get; set; }
		public T29 Item29 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2), T3 item3 = default(T3), T4 item4 = default(T4), T5 item5 = default(T5), T6 item6 = default(T6), T7 item7 = default(T7), T8 item8 = default(T8), T9 item9 = default(T9), T10 item10 = default(T10), T11 item11 = default(T11), T12 item12 = default(T12), T13 item13 = default(T13), T14 item14 = default(T14), T15 item15 = default(T15), T16 item16 = default(T16), T17 item17 = default(T17), T18 item18 = default(T18), T19 item19 = default(T19), T20 item20 = default(T20), T21 item21 = default(T21), T22 item22 = default(T22), T23 item23 = default(T23), T24 item24 = default(T24), T25 item25 = default(T25), T26 item26 = default(T26), T27 item27 = default(T27), T28 item28 = default(T28), T29 item29 = default(T29))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
			this.Item6 = item6;
			this.Item7 = item7;
			this.Item8 = item8;
			this.Item9 = item9;
			this.Item10 = item10;
			this.Item11 = item11;
			this.Item12 = item12;
			this.Item13 = item13;
			this.Item14 = item14;
			this.Item15 = item15;
			this.Item16 = item16;
			this.Item17 = item17;
			this.Item18 = item18;
			this.Item19 = item19;
			this.Item20 = item20;
			this.Item21 = item21;
			this.Item22 = item22;
			this.Item23 = item23;
			this.Item24 = item24;
			this.Item25 = item25;
			this.Item26 = item26;
			this.Item27 = item27;
			this.Item28 = item28;
			this.Item29 = item29;
		}

		public static implicit operator (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29)(tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29> original)
		{
			return (original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26, original.Item27, original.Item28, original.Item29);
		}

		public static implicit operator tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>((T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29) original)
		{
			return new tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26, original.Item27, original.Item28, original.Item29);
		}

	}

	public class tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }
		public T18 Item18 { get; set; }
		public T19 Item19 { get; set; }
		public T20 Item20 { get; set; }
		public T21 Item21 { get; set; }
		public T22 Item22 { get; set; }
		public T23 Item23 { get; set; }
		public T24 Item24 { get; set; }
		public T25 Item25 { get; set; }
		public T26 Item26 { get; set; }
		public T27 Item27 { get; set; }
		public T28 Item28 { get; set; }
		public T29 Item29 { get; set; }
		public T30 Item30 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2), T3 item3 = default(T3), T4 item4 = default(T4), T5 item5 = default(T5), T6 item6 = default(T6), T7 item7 = default(T7), T8 item8 = default(T8), T9 item9 = default(T9), T10 item10 = default(T10), T11 item11 = default(T11), T12 item12 = default(T12), T13 item13 = default(T13), T14 item14 = default(T14), T15 item15 = default(T15), T16 item16 = default(T16), T17 item17 = default(T17), T18 item18 = default(T18), T19 item19 = default(T19), T20 item20 = default(T20), T21 item21 = default(T21), T22 item22 = default(T22), T23 item23 = default(T23), T24 item24 = default(T24), T25 item25 = default(T25), T26 item26 = default(T26), T27 item27 = default(T27), T28 item28 = default(T28), T29 item29 = default(T29), T30 item30 = default(T30))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
			this.Item6 = item6;
			this.Item7 = item7;
			this.Item8 = item8;
			this.Item9 = item9;
			this.Item10 = item10;
			this.Item11 = item11;
			this.Item12 = item12;
			this.Item13 = item13;
			this.Item14 = item14;
			this.Item15 = item15;
			this.Item16 = item16;
			this.Item17 = item17;
			this.Item18 = item18;
			this.Item19 = item19;
			this.Item20 = item20;
			this.Item21 = item21;
			this.Item22 = item22;
			this.Item23 = item23;
			this.Item24 = item24;
			this.Item25 = item25;
			this.Item26 = item26;
			this.Item27 = item27;
			this.Item28 = item28;
			this.Item29 = item29;
			this.Item30 = item30;
		}

		public static implicit operator (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30)(tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30> original)
		{
			return (original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26, original.Item27, original.Item28, original.Item29, original.Item30);
		}

		public static implicit operator tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>((T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30) original)
		{
			return new tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26, original.Item27, original.Item28, original.Item29, original.Item30);
		}

	}

	public class tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }
		public T18 Item18 { get; set; }
		public T19 Item19 { get; set; }
		public T20 Item20 { get; set; }
		public T21 Item21 { get; set; }
		public T22 Item22 { get; set; }
		public T23 Item23 { get; set; }
		public T24 Item24 { get; set; }
		public T25 Item25 { get; set; }
		public T26 Item26 { get; set; }
		public T27 Item27 { get; set; }
		public T28 Item28 { get; set; }
		public T29 Item29 { get; set; }
		public T30 Item30 { get; set; }
		public T31 Item31 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2), T3 item3 = default(T3), T4 item4 = default(T4), T5 item5 = default(T5), T6 item6 = default(T6), T7 item7 = default(T7), T8 item8 = default(T8), T9 item9 = default(T9), T10 item10 = default(T10), T11 item11 = default(T11), T12 item12 = default(T12), T13 item13 = default(T13), T14 item14 = default(T14), T15 item15 = default(T15), T16 item16 = default(T16), T17 item17 = default(T17), T18 item18 = default(T18), T19 item19 = default(T19), T20 item20 = default(T20), T21 item21 = default(T21), T22 item22 = default(T22), T23 item23 = default(T23), T24 item24 = default(T24), T25 item25 = default(T25), T26 item26 = default(T26), T27 item27 = default(T27), T28 item28 = default(T28), T29 item29 = default(T29), T30 item30 = default(T30), T31 item31 = default(T31))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
			this.Item6 = item6;
			this.Item7 = item7;
			this.Item8 = item8;
			this.Item9 = item9;
			this.Item10 = item10;
			this.Item11 = item11;
			this.Item12 = item12;
			this.Item13 = item13;
			this.Item14 = item14;
			this.Item15 = item15;
			this.Item16 = item16;
			this.Item17 = item17;
			this.Item18 = item18;
			this.Item19 = item19;
			this.Item20 = item20;
			this.Item21 = item21;
			this.Item22 = item22;
			this.Item23 = item23;
			this.Item24 = item24;
			this.Item25 = item25;
			this.Item26 = item26;
			this.Item27 = item27;
			this.Item28 = item28;
			this.Item29 = item29;
			this.Item30 = item30;
			this.Item31 = item31;
		}

		public static implicit operator (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31)(tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> original)
		{
			return (original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26, original.Item27, original.Item28, original.Item29, original.Item30, original.Item31);
		}

		public static implicit operator tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>((T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31) original)
		{
			return new tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26, original.Item27, original.Item28, original.Item29, original.Item30, original.Item31);
		}

	}

	public class tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }
		public T18 Item18 { get; set; }
		public T19 Item19 { get; set; }
		public T20 Item20 { get; set; }
		public T21 Item21 { get; set; }
		public T22 Item22 { get; set; }
		public T23 Item23 { get; set; }
		public T24 Item24 { get; set; }
		public T25 Item25 { get; set; }
		public T26 Item26 { get; set; }
		public T27 Item27 { get; set; }
		public T28 Item28 { get; set; }
		public T29 Item29 { get; set; }
		public T30 Item30 { get; set; }
		public T31 Item31 { get; set; }
		public T32 Item32 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2), T3 item3 = default(T3), T4 item4 = default(T4), T5 item5 = default(T5), T6 item6 = default(T6), T7 item7 = default(T7), T8 item8 = default(T8), T9 item9 = default(T9), T10 item10 = default(T10), T11 item11 = default(T11), T12 item12 = default(T12), T13 item13 = default(T13), T14 item14 = default(T14), T15 item15 = default(T15), T16 item16 = default(T16), T17 item17 = default(T17), T18 item18 = default(T18), T19 item19 = default(T19), T20 item20 = default(T20), T21 item21 = default(T21), T22 item22 = default(T22), T23 item23 = default(T23), T24 item24 = default(T24), T25 item25 = default(T25), T26 item26 = default(T26), T27 item27 = default(T27), T28 item28 = default(T28), T29 item29 = default(T29), T30 item30 = default(T30), T31 item31 = default(T31), T32 item32 = default(T32))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
			this.Item6 = item6;
			this.Item7 = item7;
			this.Item8 = item8;
			this.Item9 = item9;
			this.Item10 = item10;
			this.Item11 = item11;
			this.Item12 = item12;
			this.Item13 = item13;
			this.Item14 = item14;
			this.Item15 = item15;
			this.Item16 = item16;
			this.Item17 = item17;
			this.Item18 = item18;
			this.Item19 = item19;
			this.Item20 = item20;
			this.Item21 = item21;
			this.Item22 = item22;
			this.Item23 = item23;
			this.Item24 = item24;
			this.Item25 = item25;
			this.Item26 = item26;
			this.Item27 = item27;
			this.Item28 = item28;
			this.Item29 = item29;
			this.Item30 = item30;
			this.Item31 = item31;
			this.Item32 = item32;
		}

		public static implicit operator (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32)(tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32> original)
		{
			return (original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26, original.Item27, original.Item28, original.Item29, original.Item30, original.Item31, original.Item32);
		}

		public static implicit operator tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>((T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32) original)
		{
			return new tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26, original.Item27, original.Item28, original.Item29, original.Item30, original.Item31, original.Item32);
		}

	}

	public class tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }
		public T18 Item18 { get; set; }
		public T19 Item19 { get; set; }
		public T20 Item20 { get; set; }
		public T21 Item21 { get; set; }
		public T22 Item22 { get; set; }
		public T23 Item23 { get; set; }
		public T24 Item24 { get; set; }
		public T25 Item25 { get; set; }
		public T26 Item26 { get; set; }
		public T27 Item27 { get; set; }
		public T28 Item28 { get; set; }
		public T29 Item29 { get; set; }
		public T30 Item30 { get; set; }
		public T31 Item31 { get; set; }
		public T32 Item32 { get; set; }
		public T33 Item33 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2), T3 item3 = default(T3), T4 item4 = default(T4), T5 item5 = default(T5), T6 item6 = default(T6), T7 item7 = default(T7), T8 item8 = default(T8), T9 item9 = default(T9), T10 item10 = default(T10), T11 item11 = default(T11), T12 item12 = default(T12), T13 item13 = default(T13), T14 item14 = default(T14), T15 item15 = default(T15), T16 item16 = default(T16), T17 item17 = default(T17), T18 item18 = default(T18), T19 item19 = default(T19), T20 item20 = default(T20), T21 item21 = default(T21), T22 item22 = default(T22), T23 item23 = default(T23), T24 item24 = default(T24), T25 item25 = default(T25), T26 item26 = default(T26), T27 item27 = default(T27), T28 item28 = default(T28), T29 item29 = default(T29), T30 item30 = default(T30), T31 item31 = default(T31), T32 item32 = default(T32), T33 item33 = default(T33))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
			this.Item6 = item6;
			this.Item7 = item7;
			this.Item8 = item8;
			this.Item9 = item9;
			this.Item10 = item10;
			this.Item11 = item11;
			this.Item12 = item12;
			this.Item13 = item13;
			this.Item14 = item14;
			this.Item15 = item15;
			this.Item16 = item16;
			this.Item17 = item17;
			this.Item18 = item18;
			this.Item19 = item19;
			this.Item20 = item20;
			this.Item21 = item21;
			this.Item22 = item22;
			this.Item23 = item23;
			this.Item24 = item24;
			this.Item25 = item25;
			this.Item26 = item26;
			this.Item27 = item27;
			this.Item28 = item28;
			this.Item29 = item29;
			this.Item30 = item30;
			this.Item31 = item31;
			this.Item32 = item32;
			this.Item33 = item33;
		}

		public static implicit operator (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33)(tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33> original)
		{
			return (original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26, original.Item27, original.Item28, original.Item29, original.Item30, original.Item31, original.Item32, original.Item33);
		}

		public static implicit operator tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>((T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33) original)
		{
			return new tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26, original.Item27, original.Item28, original.Item29, original.Item30, original.Item31, original.Item32, original.Item33);
		}

	}

	public class tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }
		public T18 Item18 { get; set; }
		public T19 Item19 { get; set; }
		public T20 Item20 { get; set; }
		public T21 Item21 { get; set; }
		public T22 Item22 { get; set; }
		public T23 Item23 { get; set; }
		public T24 Item24 { get; set; }
		public T25 Item25 { get; set; }
		public T26 Item26 { get; set; }
		public T27 Item27 { get; set; }
		public T28 Item28 { get; set; }
		public T29 Item29 { get; set; }
		public T30 Item30 { get; set; }
		public T31 Item31 { get; set; }
		public T32 Item32 { get; set; }
		public T33 Item33 { get; set; }
		public T34 Item34 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2), T3 item3 = default(T3), T4 item4 = default(T4), T5 item5 = default(T5), T6 item6 = default(T6), T7 item7 = default(T7), T8 item8 = default(T8), T9 item9 = default(T9), T10 item10 = default(T10), T11 item11 = default(T11), T12 item12 = default(T12), T13 item13 = default(T13), T14 item14 = default(T14), T15 item15 = default(T15), T16 item16 = default(T16), T17 item17 = default(T17), T18 item18 = default(T18), T19 item19 = default(T19), T20 item20 = default(T20), T21 item21 = default(T21), T22 item22 = default(T22), T23 item23 = default(T23), T24 item24 = default(T24), T25 item25 = default(T25), T26 item26 = default(T26), T27 item27 = default(T27), T28 item28 = default(T28), T29 item29 = default(T29), T30 item30 = default(T30), T31 item31 = default(T31), T32 item32 = default(T32), T33 item33 = default(T33), T34 item34 = default(T34))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
			this.Item6 = item6;
			this.Item7 = item7;
			this.Item8 = item8;
			this.Item9 = item9;
			this.Item10 = item10;
			this.Item11 = item11;
			this.Item12 = item12;
			this.Item13 = item13;
			this.Item14 = item14;
			this.Item15 = item15;
			this.Item16 = item16;
			this.Item17 = item17;
			this.Item18 = item18;
			this.Item19 = item19;
			this.Item20 = item20;
			this.Item21 = item21;
			this.Item22 = item22;
			this.Item23 = item23;
			this.Item24 = item24;
			this.Item25 = item25;
			this.Item26 = item26;
			this.Item27 = item27;
			this.Item28 = item28;
			this.Item29 = item29;
			this.Item30 = item30;
			this.Item31 = item31;
			this.Item32 = item32;
			this.Item33 = item33;
			this.Item34 = item34;
		}

		public static implicit operator (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34)(tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34> original)
		{
			return (original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26, original.Item27, original.Item28, original.Item29, original.Item30, original.Item31, original.Item32, original.Item33, original.Item34);
		}

		public static implicit operator tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>((T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34) original)
		{
			return new tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26, original.Item27, original.Item28, original.Item29, original.Item30, original.Item31, original.Item32, original.Item33, original.Item34);
		}

	}

	public class tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }
		public T18 Item18 { get; set; }
		public T19 Item19 { get; set; }
		public T20 Item20 { get; set; }
		public T21 Item21 { get; set; }
		public T22 Item22 { get; set; }
		public T23 Item23 { get; set; }
		public T24 Item24 { get; set; }
		public T25 Item25 { get; set; }
		public T26 Item26 { get; set; }
		public T27 Item27 { get; set; }
		public T28 Item28 { get; set; }
		public T29 Item29 { get; set; }
		public T30 Item30 { get; set; }
		public T31 Item31 { get; set; }
		public T32 Item32 { get; set; }
		public T33 Item33 { get; set; }
		public T34 Item34 { get; set; }
		public T35 Item35 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2), T3 item3 = default(T3), T4 item4 = default(T4), T5 item5 = default(T5), T6 item6 = default(T6), T7 item7 = default(T7), T8 item8 = default(T8), T9 item9 = default(T9), T10 item10 = default(T10), T11 item11 = default(T11), T12 item12 = default(T12), T13 item13 = default(T13), T14 item14 = default(T14), T15 item15 = default(T15), T16 item16 = default(T16), T17 item17 = default(T17), T18 item18 = default(T18), T19 item19 = default(T19), T20 item20 = default(T20), T21 item21 = default(T21), T22 item22 = default(T22), T23 item23 = default(T23), T24 item24 = default(T24), T25 item25 = default(T25), T26 item26 = default(T26), T27 item27 = default(T27), T28 item28 = default(T28), T29 item29 = default(T29), T30 item30 = default(T30), T31 item31 = default(T31), T32 item32 = default(T32), T33 item33 = default(T33), T34 item34 = default(T34), T35 item35 = default(T35))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
			this.Item6 = item6;
			this.Item7 = item7;
			this.Item8 = item8;
			this.Item9 = item9;
			this.Item10 = item10;
			this.Item11 = item11;
			this.Item12 = item12;
			this.Item13 = item13;
			this.Item14 = item14;
			this.Item15 = item15;
			this.Item16 = item16;
			this.Item17 = item17;
			this.Item18 = item18;
			this.Item19 = item19;
			this.Item20 = item20;
			this.Item21 = item21;
			this.Item22 = item22;
			this.Item23 = item23;
			this.Item24 = item24;
			this.Item25 = item25;
			this.Item26 = item26;
			this.Item27 = item27;
			this.Item28 = item28;
			this.Item29 = item29;
			this.Item30 = item30;
			this.Item31 = item31;
			this.Item32 = item32;
			this.Item33 = item33;
			this.Item34 = item34;
			this.Item35 = item35;
		}

		public static implicit operator (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35)(tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35> original)
		{
			return (original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26, original.Item27, original.Item28, original.Item29, original.Item30, original.Item31, original.Item32, original.Item33, original.Item34, original.Item35);
		}

		public static implicit operator tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>((T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35) original)
		{
			return new tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26, original.Item27, original.Item28, original.Item29, original.Item30, original.Item31, original.Item32, original.Item33, original.Item34, original.Item35);
		}

	}

	public class tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }
		public T18 Item18 { get; set; }
		public T19 Item19 { get; set; }
		public T20 Item20 { get; set; }
		public T21 Item21 { get; set; }
		public T22 Item22 { get; set; }
		public T23 Item23 { get; set; }
		public T24 Item24 { get; set; }
		public T25 Item25 { get; set; }
		public T26 Item26 { get; set; }
		public T27 Item27 { get; set; }
		public T28 Item28 { get; set; }
		public T29 Item29 { get; set; }
		public T30 Item30 { get; set; }
		public T31 Item31 { get; set; }
		public T32 Item32 { get; set; }
		public T33 Item33 { get; set; }
		public T34 Item34 { get; set; }
		public T35 Item35 { get; set; }
		public T36 Item36 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2), T3 item3 = default(T3), T4 item4 = default(T4), T5 item5 = default(T5), T6 item6 = default(T6), T7 item7 = default(T7), T8 item8 = default(T8), T9 item9 = default(T9), T10 item10 = default(T10), T11 item11 = default(T11), T12 item12 = default(T12), T13 item13 = default(T13), T14 item14 = default(T14), T15 item15 = default(T15), T16 item16 = default(T16), T17 item17 = default(T17), T18 item18 = default(T18), T19 item19 = default(T19), T20 item20 = default(T20), T21 item21 = default(T21), T22 item22 = default(T22), T23 item23 = default(T23), T24 item24 = default(T24), T25 item25 = default(T25), T26 item26 = default(T26), T27 item27 = default(T27), T28 item28 = default(T28), T29 item29 = default(T29), T30 item30 = default(T30), T31 item31 = default(T31), T32 item32 = default(T32), T33 item33 = default(T33), T34 item34 = default(T34), T35 item35 = default(T35), T36 item36 = default(T36))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
			this.Item6 = item6;
			this.Item7 = item7;
			this.Item8 = item8;
			this.Item9 = item9;
			this.Item10 = item10;
			this.Item11 = item11;
			this.Item12 = item12;
			this.Item13 = item13;
			this.Item14 = item14;
			this.Item15 = item15;
			this.Item16 = item16;
			this.Item17 = item17;
			this.Item18 = item18;
			this.Item19 = item19;
			this.Item20 = item20;
			this.Item21 = item21;
			this.Item22 = item22;
			this.Item23 = item23;
			this.Item24 = item24;
			this.Item25 = item25;
			this.Item26 = item26;
			this.Item27 = item27;
			this.Item28 = item28;
			this.Item29 = item29;
			this.Item30 = item30;
			this.Item31 = item31;
			this.Item32 = item32;
			this.Item33 = item33;
			this.Item34 = item34;
			this.Item35 = item35;
			this.Item36 = item36;
		}

		public static implicit operator (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36)(tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36> original)
		{
			return (original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26, original.Item27, original.Item28, original.Item29, original.Item30, original.Item31, original.Item32, original.Item33, original.Item34, original.Item35, original.Item36);
		}

		public static implicit operator tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>((T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36) original)
		{
			return new tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26, original.Item27, original.Item28, original.Item29, original.Item30, original.Item31, original.Item32, original.Item33, original.Item34, original.Item35, original.Item36);
		}

	}

	public class tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }
		public T18 Item18 { get; set; }
		public T19 Item19 { get; set; }
		public T20 Item20 { get; set; }
		public T21 Item21 { get; set; }
		public T22 Item22 { get; set; }
		public T23 Item23 { get; set; }
		public T24 Item24 { get; set; }
		public T25 Item25 { get; set; }
		public T26 Item26 { get; set; }
		public T27 Item27 { get; set; }
		public T28 Item28 { get; set; }
		public T29 Item29 { get; set; }
		public T30 Item30 { get; set; }
		public T31 Item31 { get; set; }
		public T32 Item32 { get; set; }
		public T33 Item33 { get; set; }
		public T34 Item34 { get; set; }
		public T35 Item35 { get; set; }
		public T36 Item36 { get; set; }
		public T37 Item37 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2), T3 item3 = default(T3), T4 item4 = default(T4), T5 item5 = default(T5), T6 item6 = default(T6), T7 item7 = default(T7), T8 item8 = default(T8), T9 item9 = default(T9), T10 item10 = default(T10), T11 item11 = default(T11), T12 item12 = default(T12), T13 item13 = default(T13), T14 item14 = default(T14), T15 item15 = default(T15), T16 item16 = default(T16), T17 item17 = default(T17), T18 item18 = default(T18), T19 item19 = default(T19), T20 item20 = default(T20), T21 item21 = default(T21), T22 item22 = default(T22), T23 item23 = default(T23), T24 item24 = default(T24), T25 item25 = default(T25), T26 item26 = default(T26), T27 item27 = default(T27), T28 item28 = default(T28), T29 item29 = default(T29), T30 item30 = default(T30), T31 item31 = default(T31), T32 item32 = default(T32), T33 item33 = default(T33), T34 item34 = default(T34), T35 item35 = default(T35), T36 item36 = default(T36), T37 item37 = default(T37))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
			this.Item6 = item6;
			this.Item7 = item7;
			this.Item8 = item8;
			this.Item9 = item9;
			this.Item10 = item10;
			this.Item11 = item11;
			this.Item12 = item12;
			this.Item13 = item13;
			this.Item14 = item14;
			this.Item15 = item15;
			this.Item16 = item16;
			this.Item17 = item17;
			this.Item18 = item18;
			this.Item19 = item19;
			this.Item20 = item20;
			this.Item21 = item21;
			this.Item22 = item22;
			this.Item23 = item23;
			this.Item24 = item24;
			this.Item25 = item25;
			this.Item26 = item26;
			this.Item27 = item27;
			this.Item28 = item28;
			this.Item29 = item29;
			this.Item30 = item30;
			this.Item31 = item31;
			this.Item32 = item32;
			this.Item33 = item33;
			this.Item34 = item34;
			this.Item35 = item35;
			this.Item36 = item36;
			this.Item37 = item37;
		}

		public static implicit operator (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37)(tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37> original)
		{
			return (original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26, original.Item27, original.Item28, original.Item29, original.Item30, original.Item31, original.Item32, original.Item33, original.Item34, original.Item35, original.Item36, original.Item37);
		}

		public static implicit operator tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>((T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37) original)
		{
			return new tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26, original.Item27, original.Item28, original.Item29, original.Item30, original.Item31, original.Item32, original.Item33, original.Item34, original.Item35, original.Item36, original.Item37);
		}

	}

	public class tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }
		public T18 Item18 { get; set; }
		public T19 Item19 { get; set; }
		public T20 Item20 { get; set; }
		public T21 Item21 { get; set; }
		public T22 Item22 { get; set; }
		public T23 Item23 { get; set; }
		public T24 Item24 { get; set; }
		public T25 Item25 { get; set; }
		public T26 Item26 { get; set; }
		public T27 Item27 { get; set; }
		public T28 Item28 { get; set; }
		public T29 Item29 { get; set; }
		public T30 Item30 { get; set; }
		public T31 Item31 { get; set; }
		public T32 Item32 { get; set; }
		public T33 Item33 { get; set; }
		public T34 Item34 { get; set; }
		public T35 Item35 { get; set; }
		public T36 Item36 { get; set; }
		public T37 Item37 { get; set; }
		public T38 Item38 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2), T3 item3 = default(T3), T4 item4 = default(T4), T5 item5 = default(T5), T6 item6 = default(T6), T7 item7 = default(T7), T8 item8 = default(T8), T9 item9 = default(T9), T10 item10 = default(T10), T11 item11 = default(T11), T12 item12 = default(T12), T13 item13 = default(T13), T14 item14 = default(T14), T15 item15 = default(T15), T16 item16 = default(T16), T17 item17 = default(T17), T18 item18 = default(T18), T19 item19 = default(T19), T20 item20 = default(T20), T21 item21 = default(T21), T22 item22 = default(T22), T23 item23 = default(T23), T24 item24 = default(T24), T25 item25 = default(T25), T26 item26 = default(T26), T27 item27 = default(T27), T28 item28 = default(T28), T29 item29 = default(T29), T30 item30 = default(T30), T31 item31 = default(T31), T32 item32 = default(T32), T33 item33 = default(T33), T34 item34 = default(T34), T35 item35 = default(T35), T36 item36 = default(T36), T37 item37 = default(T37), T38 item38 = default(T38))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
			this.Item6 = item6;
			this.Item7 = item7;
			this.Item8 = item8;
			this.Item9 = item9;
			this.Item10 = item10;
			this.Item11 = item11;
			this.Item12 = item12;
			this.Item13 = item13;
			this.Item14 = item14;
			this.Item15 = item15;
			this.Item16 = item16;
			this.Item17 = item17;
			this.Item18 = item18;
			this.Item19 = item19;
			this.Item20 = item20;
			this.Item21 = item21;
			this.Item22 = item22;
			this.Item23 = item23;
			this.Item24 = item24;
			this.Item25 = item25;
			this.Item26 = item26;
			this.Item27 = item27;
			this.Item28 = item28;
			this.Item29 = item29;
			this.Item30 = item30;
			this.Item31 = item31;
			this.Item32 = item32;
			this.Item33 = item33;
			this.Item34 = item34;
			this.Item35 = item35;
			this.Item36 = item36;
			this.Item37 = item37;
			this.Item38 = item38;
		}

		public static implicit operator (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38)(tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38> original)
		{
			return (original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26, original.Item27, original.Item28, original.Item29, original.Item30, original.Item31, original.Item32, original.Item33, original.Item34, original.Item35, original.Item36, original.Item37, original.Item38);
		}

		public static implicit operator tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>((T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38) original)
		{
			return new tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26, original.Item27, original.Item28, original.Item29, original.Item30, original.Item31, original.Item32, original.Item33, original.Item34, original.Item35, original.Item36, original.Item37, original.Item38);
		}

	}

	public class tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }
		public T18 Item18 { get; set; }
		public T19 Item19 { get; set; }
		public T20 Item20 { get; set; }
		public T21 Item21 { get; set; }
		public T22 Item22 { get; set; }
		public T23 Item23 { get; set; }
		public T24 Item24 { get; set; }
		public T25 Item25 { get; set; }
		public T26 Item26 { get; set; }
		public T27 Item27 { get; set; }
		public T28 Item28 { get; set; }
		public T29 Item29 { get; set; }
		public T30 Item30 { get; set; }
		public T31 Item31 { get; set; }
		public T32 Item32 { get; set; }
		public T33 Item33 { get; set; }
		public T34 Item34 { get; set; }
		public T35 Item35 { get; set; }
		public T36 Item36 { get; set; }
		public T37 Item37 { get; set; }
		public T38 Item38 { get; set; }
		public T39 Item39 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2), T3 item3 = default(T3), T4 item4 = default(T4), T5 item5 = default(T5), T6 item6 = default(T6), T7 item7 = default(T7), T8 item8 = default(T8), T9 item9 = default(T9), T10 item10 = default(T10), T11 item11 = default(T11), T12 item12 = default(T12), T13 item13 = default(T13), T14 item14 = default(T14), T15 item15 = default(T15), T16 item16 = default(T16), T17 item17 = default(T17), T18 item18 = default(T18), T19 item19 = default(T19), T20 item20 = default(T20), T21 item21 = default(T21), T22 item22 = default(T22), T23 item23 = default(T23), T24 item24 = default(T24), T25 item25 = default(T25), T26 item26 = default(T26), T27 item27 = default(T27), T28 item28 = default(T28), T29 item29 = default(T29), T30 item30 = default(T30), T31 item31 = default(T31), T32 item32 = default(T32), T33 item33 = default(T33), T34 item34 = default(T34), T35 item35 = default(T35), T36 item36 = default(T36), T37 item37 = default(T37), T38 item38 = default(T38), T39 item39 = default(T39))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
			this.Item6 = item6;
			this.Item7 = item7;
			this.Item8 = item8;
			this.Item9 = item9;
			this.Item10 = item10;
			this.Item11 = item11;
			this.Item12 = item12;
			this.Item13 = item13;
			this.Item14 = item14;
			this.Item15 = item15;
			this.Item16 = item16;
			this.Item17 = item17;
			this.Item18 = item18;
			this.Item19 = item19;
			this.Item20 = item20;
			this.Item21 = item21;
			this.Item22 = item22;
			this.Item23 = item23;
			this.Item24 = item24;
			this.Item25 = item25;
			this.Item26 = item26;
			this.Item27 = item27;
			this.Item28 = item28;
			this.Item29 = item29;
			this.Item30 = item30;
			this.Item31 = item31;
			this.Item32 = item32;
			this.Item33 = item33;
			this.Item34 = item34;
			this.Item35 = item35;
			this.Item36 = item36;
			this.Item37 = item37;
			this.Item38 = item38;
			this.Item39 = item39;
		}

		public static implicit operator (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39)(tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39> original)
		{
			return (original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26, original.Item27, original.Item28, original.Item29, original.Item30, original.Item31, original.Item32, original.Item33, original.Item34, original.Item35, original.Item36, original.Item37, original.Item38, original.Item39);
		}

		public static implicit operator tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>((T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39) original)
		{
			return new tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26, original.Item27, original.Item28, original.Item29, original.Item30, original.Item31, original.Item32, original.Item33, original.Item34, original.Item35, original.Item36, original.Item37, original.Item38, original.Item39);
		}

	}

	public class tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }
		public T18 Item18 { get; set; }
		public T19 Item19 { get; set; }
		public T20 Item20 { get; set; }
		public T21 Item21 { get; set; }
		public T22 Item22 { get; set; }
		public T23 Item23 { get; set; }
		public T24 Item24 { get; set; }
		public T25 Item25 { get; set; }
		public T26 Item26 { get; set; }
		public T27 Item27 { get; set; }
		public T28 Item28 { get; set; }
		public T29 Item29 { get; set; }
		public T30 Item30 { get; set; }
		public T31 Item31 { get; set; }
		public T32 Item32 { get; set; }
		public T33 Item33 { get; set; }
		public T34 Item34 { get; set; }
		public T35 Item35 { get; set; }
		public T36 Item36 { get; set; }
		public T37 Item37 { get; set; }
		public T38 Item38 { get; set; }
		public T39 Item39 { get; set; }
		public T40 Item40 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2), T3 item3 = default(T3), T4 item4 = default(T4), T5 item5 = default(T5), T6 item6 = default(T6), T7 item7 = default(T7), T8 item8 = default(T8), T9 item9 = default(T9), T10 item10 = default(T10), T11 item11 = default(T11), T12 item12 = default(T12), T13 item13 = default(T13), T14 item14 = default(T14), T15 item15 = default(T15), T16 item16 = default(T16), T17 item17 = default(T17), T18 item18 = default(T18), T19 item19 = default(T19), T20 item20 = default(T20), T21 item21 = default(T21), T22 item22 = default(T22), T23 item23 = default(T23), T24 item24 = default(T24), T25 item25 = default(T25), T26 item26 = default(T26), T27 item27 = default(T27), T28 item28 = default(T28), T29 item29 = default(T29), T30 item30 = default(T30), T31 item31 = default(T31), T32 item32 = default(T32), T33 item33 = default(T33), T34 item34 = default(T34), T35 item35 = default(T35), T36 item36 = default(T36), T37 item37 = default(T37), T38 item38 = default(T38), T39 item39 = default(T39), T40 item40 = default(T40))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
			this.Item6 = item6;
			this.Item7 = item7;
			this.Item8 = item8;
			this.Item9 = item9;
			this.Item10 = item10;
			this.Item11 = item11;
			this.Item12 = item12;
			this.Item13 = item13;
			this.Item14 = item14;
			this.Item15 = item15;
			this.Item16 = item16;
			this.Item17 = item17;
			this.Item18 = item18;
			this.Item19 = item19;
			this.Item20 = item20;
			this.Item21 = item21;
			this.Item22 = item22;
			this.Item23 = item23;
			this.Item24 = item24;
			this.Item25 = item25;
			this.Item26 = item26;
			this.Item27 = item27;
			this.Item28 = item28;
			this.Item29 = item29;
			this.Item30 = item30;
			this.Item31 = item31;
			this.Item32 = item32;
			this.Item33 = item33;
			this.Item34 = item34;
			this.Item35 = item35;
			this.Item36 = item36;
			this.Item37 = item37;
			this.Item38 = item38;
			this.Item39 = item39;
			this.Item40 = item40;
		}

		public static implicit operator (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40)(tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40> original)
		{
			return (original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26, original.Item27, original.Item28, original.Item29, original.Item30, original.Item31, original.Item32, original.Item33, original.Item34, original.Item35, original.Item36, original.Item37, original.Item38, original.Item39, original.Item40);
		}

		public static implicit operator tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>((T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40) original)
		{
			return new tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26, original.Item27, original.Item28, original.Item29, original.Item30, original.Item31, original.Item32, original.Item33, original.Item34, original.Item35, original.Item36, original.Item37, original.Item38, original.Item39, original.Item40);
		}

	}

	public class tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }
		public T18 Item18 { get; set; }
		public T19 Item19 { get; set; }
		public T20 Item20 { get; set; }
		public T21 Item21 { get; set; }
		public T22 Item22 { get; set; }
		public T23 Item23 { get; set; }
		public T24 Item24 { get; set; }
		public T25 Item25 { get; set; }
		public T26 Item26 { get; set; }
		public T27 Item27 { get; set; }
		public T28 Item28 { get; set; }
		public T29 Item29 { get; set; }
		public T30 Item30 { get; set; }
		public T31 Item31 { get; set; }
		public T32 Item32 { get; set; }
		public T33 Item33 { get; set; }
		public T34 Item34 { get; set; }
		public T35 Item35 { get; set; }
		public T36 Item36 { get; set; }
		public T37 Item37 { get; set; }
		public T38 Item38 { get; set; }
		public T39 Item39 { get; set; }
		public T40 Item40 { get; set; }
		public T41 Item41 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2), T3 item3 = default(T3), T4 item4 = default(T4), T5 item5 = default(T5), T6 item6 = default(T6), T7 item7 = default(T7), T8 item8 = default(T8), T9 item9 = default(T9), T10 item10 = default(T10), T11 item11 = default(T11), T12 item12 = default(T12), T13 item13 = default(T13), T14 item14 = default(T14), T15 item15 = default(T15), T16 item16 = default(T16), T17 item17 = default(T17), T18 item18 = default(T18), T19 item19 = default(T19), T20 item20 = default(T20), T21 item21 = default(T21), T22 item22 = default(T22), T23 item23 = default(T23), T24 item24 = default(T24), T25 item25 = default(T25), T26 item26 = default(T26), T27 item27 = default(T27), T28 item28 = default(T28), T29 item29 = default(T29), T30 item30 = default(T30), T31 item31 = default(T31), T32 item32 = default(T32), T33 item33 = default(T33), T34 item34 = default(T34), T35 item35 = default(T35), T36 item36 = default(T36), T37 item37 = default(T37), T38 item38 = default(T38), T39 item39 = default(T39), T40 item40 = default(T40), T41 item41 = default(T41))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
			this.Item6 = item6;
			this.Item7 = item7;
			this.Item8 = item8;
			this.Item9 = item9;
			this.Item10 = item10;
			this.Item11 = item11;
			this.Item12 = item12;
			this.Item13 = item13;
			this.Item14 = item14;
			this.Item15 = item15;
			this.Item16 = item16;
			this.Item17 = item17;
			this.Item18 = item18;
			this.Item19 = item19;
			this.Item20 = item20;
			this.Item21 = item21;
			this.Item22 = item22;
			this.Item23 = item23;
			this.Item24 = item24;
			this.Item25 = item25;
			this.Item26 = item26;
			this.Item27 = item27;
			this.Item28 = item28;
			this.Item29 = item29;
			this.Item30 = item30;
			this.Item31 = item31;
			this.Item32 = item32;
			this.Item33 = item33;
			this.Item34 = item34;
			this.Item35 = item35;
			this.Item36 = item36;
			this.Item37 = item37;
			this.Item38 = item38;
			this.Item39 = item39;
			this.Item40 = item40;
			this.Item41 = item41;
		}

		public static implicit operator (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41)(tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41> original)
		{
			return (original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26, original.Item27, original.Item28, original.Item29, original.Item30, original.Item31, original.Item32, original.Item33, original.Item34, original.Item35, original.Item36, original.Item37, original.Item38, original.Item39, original.Item40, original.Item41);
		}

		public static implicit operator tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>((T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41) original)
		{
			return new tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26, original.Item27, original.Item28, original.Item29, original.Item30, original.Item31, original.Item32, original.Item33, original.Item34, original.Item35, original.Item36, original.Item37, original.Item38, original.Item39, original.Item40, original.Item41);
		}

	}

	public class tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }
		public T18 Item18 { get; set; }
		public T19 Item19 { get; set; }
		public T20 Item20 { get; set; }
		public T21 Item21 { get; set; }
		public T22 Item22 { get; set; }
		public T23 Item23 { get; set; }
		public T24 Item24 { get; set; }
		public T25 Item25 { get; set; }
		public T26 Item26 { get; set; }
		public T27 Item27 { get; set; }
		public T28 Item28 { get; set; }
		public T29 Item29 { get; set; }
		public T30 Item30 { get; set; }
		public T31 Item31 { get; set; }
		public T32 Item32 { get; set; }
		public T33 Item33 { get; set; }
		public T34 Item34 { get; set; }
		public T35 Item35 { get; set; }
		public T36 Item36 { get; set; }
		public T37 Item37 { get; set; }
		public T38 Item38 { get; set; }
		public T39 Item39 { get; set; }
		public T40 Item40 { get; set; }
		public T41 Item41 { get; set; }
		public T42 Item42 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2), T3 item3 = default(T3), T4 item4 = default(T4), T5 item5 = default(T5), T6 item6 = default(T6), T7 item7 = default(T7), T8 item8 = default(T8), T9 item9 = default(T9), T10 item10 = default(T10), T11 item11 = default(T11), T12 item12 = default(T12), T13 item13 = default(T13), T14 item14 = default(T14), T15 item15 = default(T15), T16 item16 = default(T16), T17 item17 = default(T17), T18 item18 = default(T18), T19 item19 = default(T19), T20 item20 = default(T20), T21 item21 = default(T21), T22 item22 = default(T22), T23 item23 = default(T23), T24 item24 = default(T24), T25 item25 = default(T25), T26 item26 = default(T26), T27 item27 = default(T27), T28 item28 = default(T28), T29 item29 = default(T29), T30 item30 = default(T30), T31 item31 = default(T31), T32 item32 = default(T32), T33 item33 = default(T33), T34 item34 = default(T34), T35 item35 = default(T35), T36 item36 = default(T36), T37 item37 = default(T37), T38 item38 = default(T38), T39 item39 = default(T39), T40 item40 = default(T40), T41 item41 = default(T41), T42 item42 = default(T42))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
			this.Item6 = item6;
			this.Item7 = item7;
			this.Item8 = item8;
			this.Item9 = item9;
			this.Item10 = item10;
			this.Item11 = item11;
			this.Item12 = item12;
			this.Item13 = item13;
			this.Item14 = item14;
			this.Item15 = item15;
			this.Item16 = item16;
			this.Item17 = item17;
			this.Item18 = item18;
			this.Item19 = item19;
			this.Item20 = item20;
			this.Item21 = item21;
			this.Item22 = item22;
			this.Item23 = item23;
			this.Item24 = item24;
			this.Item25 = item25;
			this.Item26 = item26;
			this.Item27 = item27;
			this.Item28 = item28;
			this.Item29 = item29;
			this.Item30 = item30;
			this.Item31 = item31;
			this.Item32 = item32;
			this.Item33 = item33;
			this.Item34 = item34;
			this.Item35 = item35;
			this.Item36 = item36;
			this.Item37 = item37;
			this.Item38 = item38;
			this.Item39 = item39;
			this.Item40 = item40;
			this.Item41 = item41;
			this.Item42 = item42;
		}

		public static implicit operator (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42)(tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42> original)
		{
			return (original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26, original.Item27, original.Item28, original.Item29, original.Item30, original.Item31, original.Item32, original.Item33, original.Item34, original.Item35, original.Item36, original.Item37, original.Item38, original.Item39, original.Item40, original.Item41, original.Item42);
		}

		public static implicit operator tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>((T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42) original)
		{
			return new tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26, original.Item27, original.Item28, original.Item29, original.Item30, original.Item31, original.Item32, original.Item33, original.Item34, original.Item35, original.Item36, original.Item37, original.Item38, original.Item39, original.Item40, original.Item41, original.Item42);
		}

	}

	public class tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }
		public T18 Item18 { get; set; }
		public T19 Item19 { get; set; }
		public T20 Item20 { get; set; }
		public T21 Item21 { get; set; }
		public T22 Item22 { get; set; }
		public T23 Item23 { get; set; }
		public T24 Item24 { get; set; }
		public T25 Item25 { get; set; }
		public T26 Item26 { get; set; }
		public T27 Item27 { get; set; }
		public T28 Item28 { get; set; }
		public T29 Item29 { get; set; }
		public T30 Item30 { get; set; }
		public T31 Item31 { get; set; }
		public T32 Item32 { get; set; }
		public T33 Item33 { get; set; }
		public T34 Item34 { get; set; }
		public T35 Item35 { get; set; }
		public T36 Item36 { get; set; }
		public T37 Item37 { get; set; }
		public T38 Item38 { get; set; }
		public T39 Item39 { get; set; }
		public T40 Item40 { get; set; }
		public T41 Item41 { get; set; }
		public T42 Item42 { get; set; }
		public T43 Item43 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2), T3 item3 = default(T3), T4 item4 = default(T4), T5 item5 = default(T5), T6 item6 = default(T6), T7 item7 = default(T7), T8 item8 = default(T8), T9 item9 = default(T9), T10 item10 = default(T10), T11 item11 = default(T11), T12 item12 = default(T12), T13 item13 = default(T13), T14 item14 = default(T14), T15 item15 = default(T15), T16 item16 = default(T16), T17 item17 = default(T17), T18 item18 = default(T18), T19 item19 = default(T19), T20 item20 = default(T20), T21 item21 = default(T21), T22 item22 = default(T22), T23 item23 = default(T23), T24 item24 = default(T24), T25 item25 = default(T25), T26 item26 = default(T26), T27 item27 = default(T27), T28 item28 = default(T28), T29 item29 = default(T29), T30 item30 = default(T30), T31 item31 = default(T31), T32 item32 = default(T32), T33 item33 = default(T33), T34 item34 = default(T34), T35 item35 = default(T35), T36 item36 = default(T36), T37 item37 = default(T37), T38 item38 = default(T38), T39 item39 = default(T39), T40 item40 = default(T40), T41 item41 = default(T41), T42 item42 = default(T42), T43 item43 = default(T43))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
			this.Item6 = item6;
			this.Item7 = item7;
			this.Item8 = item8;
			this.Item9 = item9;
			this.Item10 = item10;
			this.Item11 = item11;
			this.Item12 = item12;
			this.Item13 = item13;
			this.Item14 = item14;
			this.Item15 = item15;
			this.Item16 = item16;
			this.Item17 = item17;
			this.Item18 = item18;
			this.Item19 = item19;
			this.Item20 = item20;
			this.Item21 = item21;
			this.Item22 = item22;
			this.Item23 = item23;
			this.Item24 = item24;
			this.Item25 = item25;
			this.Item26 = item26;
			this.Item27 = item27;
			this.Item28 = item28;
			this.Item29 = item29;
			this.Item30 = item30;
			this.Item31 = item31;
			this.Item32 = item32;
			this.Item33 = item33;
			this.Item34 = item34;
			this.Item35 = item35;
			this.Item36 = item36;
			this.Item37 = item37;
			this.Item38 = item38;
			this.Item39 = item39;
			this.Item40 = item40;
			this.Item41 = item41;
			this.Item42 = item42;
			this.Item43 = item43;
		}

		public static implicit operator (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43)(tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43> original)
		{
			return (original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26, original.Item27, original.Item28, original.Item29, original.Item30, original.Item31, original.Item32, original.Item33, original.Item34, original.Item35, original.Item36, original.Item37, original.Item38, original.Item39, original.Item40, original.Item41, original.Item42, original.Item43);
		}

		public static implicit operator tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>((T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43) original)
		{
			return new tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26, original.Item27, original.Item28, original.Item29, original.Item30, original.Item31, original.Item32, original.Item33, original.Item34, original.Item35, original.Item36, original.Item37, original.Item38, original.Item39, original.Item40, original.Item41, original.Item42, original.Item43);
		}

	}

	public class tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }
		public T18 Item18 { get; set; }
		public T19 Item19 { get; set; }
		public T20 Item20 { get; set; }
		public T21 Item21 { get; set; }
		public T22 Item22 { get; set; }
		public T23 Item23 { get; set; }
		public T24 Item24 { get; set; }
		public T25 Item25 { get; set; }
		public T26 Item26 { get; set; }
		public T27 Item27 { get; set; }
		public T28 Item28 { get; set; }
		public T29 Item29 { get; set; }
		public T30 Item30 { get; set; }
		public T31 Item31 { get; set; }
		public T32 Item32 { get; set; }
		public T33 Item33 { get; set; }
		public T34 Item34 { get; set; }
		public T35 Item35 { get; set; }
		public T36 Item36 { get; set; }
		public T37 Item37 { get; set; }
		public T38 Item38 { get; set; }
		public T39 Item39 { get; set; }
		public T40 Item40 { get; set; }
		public T41 Item41 { get; set; }
		public T42 Item42 { get; set; }
		public T43 Item43 { get; set; }
		public T44 Item44 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2), T3 item3 = default(T3), T4 item4 = default(T4), T5 item5 = default(T5), T6 item6 = default(T6), T7 item7 = default(T7), T8 item8 = default(T8), T9 item9 = default(T9), T10 item10 = default(T10), T11 item11 = default(T11), T12 item12 = default(T12), T13 item13 = default(T13), T14 item14 = default(T14), T15 item15 = default(T15), T16 item16 = default(T16), T17 item17 = default(T17), T18 item18 = default(T18), T19 item19 = default(T19), T20 item20 = default(T20), T21 item21 = default(T21), T22 item22 = default(T22), T23 item23 = default(T23), T24 item24 = default(T24), T25 item25 = default(T25), T26 item26 = default(T26), T27 item27 = default(T27), T28 item28 = default(T28), T29 item29 = default(T29), T30 item30 = default(T30), T31 item31 = default(T31), T32 item32 = default(T32), T33 item33 = default(T33), T34 item34 = default(T34), T35 item35 = default(T35), T36 item36 = default(T36), T37 item37 = default(T37), T38 item38 = default(T38), T39 item39 = default(T39), T40 item40 = default(T40), T41 item41 = default(T41), T42 item42 = default(T42), T43 item43 = default(T43), T44 item44 = default(T44))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
			this.Item6 = item6;
			this.Item7 = item7;
			this.Item8 = item8;
			this.Item9 = item9;
			this.Item10 = item10;
			this.Item11 = item11;
			this.Item12 = item12;
			this.Item13 = item13;
			this.Item14 = item14;
			this.Item15 = item15;
			this.Item16 = item16;
			this.Item17 = item17;
			this.Item18 = item18;
			this.Item19 = item19;
			this.Item20 = item20;
			this.Item21 = item21;
			this.Item22 = item22;
			this.Item23 = item23;
			this.Item24 = item24;
			this.Item25 = item25;
			this.Item26 = item26;
			this.Item27 = item27;
			this.Item28 = item28;
			this.Item29 = item29;
			this.Item30 = item30;
			this.Item31 = item31;
			this.Item32 = item32;
			this.Item33 = item33;
			this.Item34 = item34;
			this.Item35 = item35;
			this.Item36 = item36;
			this.Item37 = item37;
			this.Item38 = item38;
			this.Item39 = item39;
			this.Item40 = item40;
			this.Item41 = item41;
			this.Item42 = item42;
			this.Item43 = item43;
			this.Item44 = item44;
		}

		public static implicit operator (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44)(tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44> original)
		{
			return (original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26, original.Item27, original.Item28, original.Item29, original.Item30, original.Item31, original.Item32, original.Item33, original.Item34, original.Item35, original.Item36, original.Item37, original.Item38, original.Item39, original.Item40, original.Item41, original.Item42, original.Item43, original.Item44);
		}

		public static implicit operator tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>((T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44) original)
		{
			return new tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26, original.Item27, original.Item28, original.Item29, original.Item30, original.Item31, original.Item32, original.Item33, original.Item34, original.Item35, original.Item36, original.Item37, original.Item38, original.Item39, original.Item40, original.Item41, original.Item42, original.Item43, original.Item44);
		}

	}

	public class tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }
		public T18 Item18 { get; set; }
		public T19 Item19 { get; set; }
		public T20 Item20 { get; set; }
		public T21 Item21 { get; set; }
		public T22 Item22 { get; set; }
		public T23 Item23 { get; set; }
		public T24 Item24 { get; set; }
		public T25 Item25 { get; set; }
		public T26 Item26 { get; set; }
		public T27 Item27 { get; set; }
		public T28 Item28 { get; set; }
		public T29 Item29 { get; set; }
		public T30 Item30 { get; set; }
		public T31 Item31 { get; set; }
		public T32 Item32 { get; set; }
		public T33 Item33 { get; set; }
		public T34 Item34 { get; set; }
		public T35 Item35 { get; set; }
		public T36 Item36 { get; set; }
		public T37 Item37 { get; set; }
		public T38 Item38 { get; set; }
		public T39 Item39 { get; set; }
		public T40 Item40 { get; set; }
		public T41 Item41 { get; set; }
		public T42 Item42 { get; set; }
		public T43 Item43 { get; set; }
		public T44 Item44 { get; set; }
		public T45 Item45 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2), T3 item3 = default(T3), T4 item4 = default(T4), T5 item5 = default(T5), T6 item6 = default(T6), T7 item7 = default(T7), T8 item8 = default(T8), T9 item9 = default(T9), T10 item10 = default(T10), T11 item11 = default(T11), T12 item12 = default(T12), T13 item13 = default(T13), T14 item14 = default(T14), T15 item15 = default(T15), T16 item16 = default(T16), T17 item17 = default(T17), T18 item18 = default(T18), T19 item19 = default(T19), T20 item20 = default(T20), T21 item21 = default(T21), T22 item22 = default(T22), T23 item23 = default(T23), T24 item24 = default(T24), T25 item25 = default(T25), T26 item26 = default(T26), T27 item27 = default(T27), T28 item28 = default(T28), T29 item29 = default(T29), T30 item30 = default(T30), T31 item31 = default(T31), T32 item32 = default(T32), T33 item33 = default(T33), T34 item34 = default(T34), T35 item35 = default(T35), T36 item36 = default(T36), T37 item37 = default(T37), T38 item38 = default(T38), T39 item39 = default(T39), T40 item40 = default(T40), T41 item41 = default(T41), T42 item42 = default(T42), T43 item43 = default(T43), T44 item44 = default(T44), T45 item45 = default(T45))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
			this.Item6 = item6;
			this.Item7 = item7;
			this.Item8 = item8;
			this.Item9 = item9;
			this.Item10 = item10;
			this.Item11 = item11;
			this.Item12 = item12;
			this.Item13 = item13;
			this.Item14 = item14;
			this.Item15 = item15;
			this.Item16 = item16;
			this.Item17 = item17;
			this.Item18 = item18;
			this.Item19 = item19;
			this.Item20 = item20;
			this.Item21 = item21;
			this.Item22 = item22;
			this.Item23 = item23;
			this.Item24 = item24;
			this.Item25 = item25;
			this.Item26 = item26;
			this.Item27 = item27;
			this.Item28 = item28;
			this.Item29 = item29;
			this.Item30 = item30;
			this.Item31 = item31;
			this.Item32 = item32;
			this.Item33 = item33;
			this.Item34 = item34;
			this.Item35 = item35;
			this.Item36 = item36;
			this.Item37 = item37;
			this.Item38 = item38;
			this.Item39 = item39;
			this.Item40 = item40;
			this.Item41 = item41;
			this.Item42 = item42;
			this.Item43 = item43;
			this.Item44 = item44;
			this.Item45 = item45;
		}

		public static implicit operator (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45)(tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45> original)
		{
			return (original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26, original.Item27, original.Item28, original.Item29, original.Item30, original.Item31, original.Item32, original.Item33, original.Item34, original.Item35, original.Item36, original.Item37, original.Item38, original.Item39, original.Item40, original.Item41, original.Item42, original.Item43, original.Item44, original.Item45);
		}

		public static implicit operator tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>((T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45) original)
		{
			return new tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26, original.Item27, original.Item28, original.Item29, original.Item30, original.Item31, original.Item32, original.Item33, original.Item34, original.Item35, original.Item36, original.Item37, original.Item38, original.Item39, original.Item40, original.Item41, original.Item42, original.Item43, original.Item44, original.Item45);
		}

	}

	public class tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }
		public T18 Item18 { get; set; }
		public T19 Item19 { get; set; }
		public T20 Item20 { get; set; }
		public T21 Item21 { get; set; }
		public T22 Item22 { get; set; }
		public T23 Item23 { get; set; }
		public T24 Item24 { get; set; }
		public T25 Item25 { get; set; }
		public T26 Item26 { get; set; }
		public T27 Item27 { get; set; }
		public T28 Item28 { get; set; }
		public T29 Item29 { get; set; }
		public T30 Item30 { get; set; }
		public T31 Item31 { get; set; }
		public T32 Item32 { get; set; }
		public T33 Item33 { get; set; }
		public T34 Item34 { get; set; }
		public T35 Item35 { get; set; }
		public T36 Item36 { get; set; }
		public T37 Item37 { get; set; }
		public T38 Item38 { get; set; }
		public T39 Item39 { get; set; }
		public T40 Item40 { get; set; }
		public T41 Item41 { get; set; }
		public T42 Item42 { get; set; }
		public T43 Item43 { get; set; }
		public T44 Item44 { get; set; }
		public T45 Item45 { get; set; }
		public T46 Item46 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2), T3 item3 = default(T3), T4 item4 = default(T4), T5 item5 = default(T5), T6 item6 = default(T6), T7 item7 = default(T7), T8 item8 = default(T8), T9 item9 = default(T9), T10 item10 = default(T10), T11 item11 = default(T11), T12 item12 = default(T12), T13 item13 = default(T13), T14 item14 = default(T14), T15 item15 = default(T15), T16 item16 = default(T16), T17 item17 = default(T17), T18 item18 = default(T18), T19 item19 = default(T19), T20 item20 = default(T20), T21 item21 = default(T21), T22 item22 = default(T22), T23 item23 = default(T23), T24 item24 = default(T24), T25 item25 = default(T25), T26 item26 = default(T26), T27 item27 = default(T27), T28 item28 = default(T28), T29 item29 = default(T29), T30 item30 = default(T30), T31 item31 = default(T31), T32 item32 = default(T32), T33 item33 = default(T33), T34 item34 = default(T34), T35 item35 = default(T35), T36 item36 = default(T36), T37 item37 = default(T37), T38 item38 = default(T38), T39 item39 = default(T39), T40 item40 = default(T40), T41 item41 = default(T41), T42 item42 = default(T42), T43 item43 = default(T43), T44 item44 = default(T44), T45 item45 = default(T45), T46 item46 = default(T46))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
			this.Item6 = item6;
			this.Item7 = item7;
			this.Item8 = item8;
			this.Item9 = item9;
			this.Item10 = item10;
			this.Item11 = item11;
			this.Item12 = item12;
			this.Item13 = item13;
			this.Item14 = item14;
			this.Item15 = item15;
			this.Item16 = item16;
			this.Item17 = item17;
			this.Item18 = item18;
			this.Item19 = item19;
			this.Item20 = item20;
			this.Item21 = item21;
			this.Item22 = item22;
			this.Item23 = item23;
			this.Item24 = item24;
			this.Item25 = item25;
			this.Item26 = item26;
			this.Item27 = item27;
			this.Item28 = item28;
			this.Item29 = item29;
			this.Item30 = item30;
			this.Item31 = item31;
			this.Item32 = item32;
			this.Item33 = item33;
			this.Item34 = item34;
			this.Item35 = item35;
			this.Item36 = item36;
			this.Item37 = item37;
			this.Item38 = item38;
			this.Item39 = item39;
			this.Item40 = item40;
			this.Item41 = item41;
			this.Item42 = item42;
			this.Item43 = item43;
			this.Item44 = item44;
			this.Item45 = item45;
			this.Item46 = item46;
		}

		public static implicit operator (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46)(tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46> original)
		{
			return (original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26, original.Item27, original.Item28, original.Item29, original.Item30, original.Item31, original.Item32, original.Item33, original.Item34, original.Item35, original.Item36, original.Item37, original.Item38, original.Item39, original.Item40, original.Item41, original.Item42, original.Item43, original.Item44, original.Item45, original.Item46);
		}

		public static implicit operator tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>((T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46) original)
		{
			return new tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26, original.Item27, original.Item28, original.Item29, original.Item30, original.Item31, original.Item32, original.Item33, original.Item34, original.Item35, original.Item36, original.Item37, original.Item38, original.Item39, original.Item40, original.Item41, original.Item42, original.Item43, original.Item44, original.Item45, original.Item46);
		}

	}

	public class tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }
		public T18 Item18 { get; set; }
		public T19 Item19 { get; set; }
		public T20 Item20 { get; set; }
		public T21 Item21 { get; set; }
		public T22 Item22 { get; set; }
		public T23 Item23 { get; set; }
		public T24 Item24 { get; set; }
		public T25 Item25 { get; set; }
		public T26 Item26 { get; set; }
		public T27 Item27 { get; set; }
		public T28 Item28 { get; set; }
		public T29 Item29 { get; set; }
		public T30 Item30 { get; set; }
		public T31 Item31 { get; set; }
		public T32 Item32 { get; set; }
		public T33 Item33 { get; set; }
		public T34 Item34 { get; set; }
		public T35 Item35 { get; set; }
		public T36 Item36 { get; set; }
		public T37 Item37 { get; set; }
		public T38 Item38 { get; set; }
		public T39 Item39 { get; set; }
		public T40 Item40 { get; set; }
		public T41 Item41 { get; set; }
		public T42 Item42 { get; set; }
		public T43 Item43 { get; set; }
		public T44 Item44 { get; set; }
		public T45 Item45 { get; set; }
		public T46 Item46 { get; set; }
		public T47 Item47 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2), T3 item3 = default(T3), T4 item4 = default(T4), T5 item5 = default(T5), T6 item6 = default(T6), T7 item7 = default(T7), T8 item8 = default(T8), T9 item9 = default(T9), T10 item10 = default(T10), T11 item11 = default(T11), T12 item12 = default(T12), T13 item13 = default(T13), T14 item14 = default(T14), T15 item15 = default(T15), T16 item16 = default(T16), T17 item17 = default(T17), T18 item18 = default(T18), T19 item19 = default(T19), T20 item20 = default(T20), T21 item21 = default(T21), T22 item22 = default(T22), T23 item23 = default(T23), T24 item24 = default(T24), T25 item25 = default(T25), T26 item26 = default(T26), T27 item27 = default(T27), T28 item28 = default(T28), T29 item29 = default(T29), T30 item30 = default(T30), T31 item31 = default(T31), T32 item32 = default(T32), T33 item33 = default(T33), T34 item34 = default(T34), T35 item35 = default(T35), T36 item36 = default(T36), T37 item37 = default(T37), T38 item38 = default(T38), T39 item39 = default(T39), T40 item40 = default(T40), T41 item41 = default(T41), T42 item42 = default(T42), T43 item43 = default(T43), T44 item44 = default(T44), T45 item45 = default(T45), T46 item46 = default(T46), T47 item47 = default(T47))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
			this.Item6 = item6;
			this.Item7 = item7;
			this.Item8 = item8;
			this.Item9 = item9;
			this.Item10 = item10;
			this.Item11 = item11;
			this.Item12 = item12;
			this.Item13 = item13;
			this.Item14 = item14;
			this.Item15 = item15;
			this.Item16 = item16;
			this.Item17 = item17;
			this.Item18 = item18;
			this.Item19 = item19;
			this.Item20 = item20;
			this.Item21 = item21;
			this.Item22 = item22;
			this.Item23 = item23;
			this.Item24 = item24;
			this.Item25 = item25;
			this.Item26 = item26;
			this.Item27 = item27;
			this.Item28 = item28;
			this.Item29 = item29;
			this.Item30 = item30;
			this.Item31 = item31;
			this.Item32 = item32;
			this.Item33 = item33;
			this.Item34 = item34;
			this.Item35 = item35;
			this.Item36 = item36;
			this.Item37 = item37;
			this.Item38 = item38;
			this.Item39 = item39;
			this.Item40 = item40;
			this.Item41 = item41;
			this.Item42 = item42;
			this.Item43 = item43;
			this.Item44 = item44;
			this.Item45 = item45;
			this.Item46 = item46;
			this.Item47 = item47;
		}

		public static implicit operator (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47)(tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47> original)
		{
			return (original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26, original.Item27, original.Item28, original.Item29, original.Item30, original.Item31, original.Item32, original.Item33, original.Item34, original.Item35, original.Item36, original.Item37, original.Item38, original.Item39, original.Item40, original.Item41, original.Item42, original.Item43, original.Item44, original.Item45, original.Item46, original.Item47);
		}

		public static implicit operator tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>((T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47) original)
		{
			return new tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26, original.Item27, original.Item28, original.Item29, original.Item30, original.Item31, original.Item32, original.Item33, original.Item34, original.Item35, original.Item36, original.Item37, original.Item38, original.Item39, original.Item40, original.Item41, original.Item42, original.Item43, original.Item44, original.Item45, original.Item46, original.Item47);
		}

	}

	public class tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }
		public T18 Item18 { get; set; }
		public T19 Item19 { get; set; }
		public T20 Item20 { get; set; }
		public T21 Item21 { get; set; }
		public T22 Item22 { get; set; }
		public T23 Item23 { get; set; }
		public T24 Item24 { get; set; }
		public T25 Item25 { get; set; }
		public T26 Item26 { get; set; }
		public T27 Item27 { get; set; }
		public T28 Item28 { get; set; }
		public T29 Item29 { get; set; }
		public T30 Item30 { get; set; }
		public T31 Item31 { get; set; }
		public T32 Item32 { get; set; }
		public T33 Item33 { get; set; }
		public T34 Item34 { get; set; }
		public T35 Item35 { get; set; }
		public T36 Item36 { get; set; }
		public T37 Item37 { get; set; }
		public T38 Item38 { get; set; }
		public T39 Item39 { get; set; }
		public T40 Item40 { get; set; }
		public T41 Item41 { get; set; }
		public T42 Item42 { get; set; }
		public T43 Item43 { get; set; }
		public T44 Item44 { get; set; }
		public T45 Item45 { get; set; }
		public T46 Item46 { get; set; }
		public T47 Item47 { get; set; }
		public T48 Item48 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2), T3 item3 = default(T3), T4 item4 = default(T4), T5 item5 = default(T5), T6 item6 = default(T6), T7 item7 = default(T7), T8 item8 = default(T8), T9 item9 = default(T9), T10 item10 = default(T10), T11 item11 = default(T11), T12 item12 = default(T12), T13 item13 = default(T13), T14 item14 = default(T14), T15 item15 = default(T15), T16 item16 = default(T16), T17 item17 = default(T17), T18 item18 = default(T18), T19 item19 = default(T19), T20 item20 = default(T20), T21 item21 = default(T21), T22 item22 = default(T22), T23 item23 = default(T23), T24 item24 = default(T24), T25 item25 = default(T25), T26 item26 = default(T26), T27 item27 = default(T27), T28 item28 = default(T28), T29 item29 = default(T29), T30 item30 = default(T30), T31 item31 = default(T31), T32 item32 = default(T32), T33 item33 = default(T33), T34 item34 = default(T34), T35 item35 = default(T35), T36 item36 = default(T36), T37 item37 = default(T37), T38 item38 = default(T38), T39 item39 = default(T39), T40 item40 = default(T40), T41 item41 = default(T41), T42 item42 = default(T42), T43 item43 = default(T43), T44 item44 = default(T44), T45 item45 = default(T45), T46 item46 = default(T46), T47 item47 = default(T47), T48 item48 = default(T48))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
			this.Item6 = item6;
			this.Item7 = item7;
			this.Item8 = item8;
			this.Item9 = item9;
			this.Item10 = item10;
			this.Item11 = item11;
			this.Item12 = item12;
			this.Item13 = item13;
			this.Item14 = item14;
			this.Item15 = item15;
			this.Item16 = item16;
			this.Item17 = item17;
			this.Item18 = item18;
			this.Item19 = item19;
			this.Item20 = item20;
			this.Item21 = item21;
			this.Item22 = item22;
			this.Item23 = item23;
			this.Item24 = item24;
			this.Item25 = item25;
			this.Item26 = item26;
			this.Item27 = item27;
			this.Item28 = item28;
			this.Item29 = item29;
			this.Item30 = item30;
			this.Item31 = item31;
			this.Item32 = item32;
			this.Item33 = item33;
			this.Item34 = item34;
			this.Item35 = item35;
			this.Item36 = item36;
			this.Item37 = item37;
			this.Item38 = item38;
			this.Item39 = item39;
			this.Item40 = item40;
			this.Item41 = item41;
			this.Item42 = item42;
			this.Item43 = item43;
			this.Item44 = item44;
			this.Item45 = item45;
			this.Item46 = item46;
			this.Item47 = item47;
			this.Item48 = item48;
		}

		public static implicit operator (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48)(tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48> original)
		{
			return (original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26, original.Item27, original.Item28, original.Item29, original.Item30, original.Item31, original.Item32, original.Item33, original.Item34, original.Item35, original.Item36, original.Item37, original.Item38, original.Item39, original.Item40, original.Item41, original.Item42, original.Item43, original.Item44, original.Item45, original.Item46, original.Item47, original.Item48);
		}

		public static implicit operator tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>((T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48) original)
		{
			return new tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>(original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26, original.Item27, original.Item28, original.Item29, original.Item30, original.Item31, original.Item32, original.Item33, original.Item34, original.Item35, original.Item36, original.Item37, original.Item38, original.Item39, original.Item40, original.Item41, original.Item42, original.Item43, original.Item44, original.Item45, original.Item46, original.Item47, original.Item48);
		}

	}

	public class tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }
		public T18 Item18 { get; set; }
		public T19 Item19 { get; set; }
		public T20 Item20 { get; set; }
		public T21 Item21 { get; set; }
		public T22 Item22 { get; set; }
		public T23 Item23 { get; set; }
		public T24 Item24 { get; set; }
		public T25 Item25 { get; set; }
		public T26 Item26 { get; set; }
		public T27 Item27 { get; set; }
		public T28 Item28 { get; set; }
		public T29 Item29 { get; set; }
		public T30 Item30 { get; set; }
		public T31 Item31 { get; set; }
		public T32 Item32 { get; set; }
		public T33 Item33 { get; set; }
		public T34 Item34 { get; set; }
		public T35 Item35 { get; set; }
		public T36 Item36 { get; set; }
		public T37 Item37 { get; set; }
		public T38 Item38 { get; set; }
		public T39 Item39 { get; set; }
		public T40 Item40 { get; set; }
		public T41 Item41 { get; set; }
		public T42 Item42 { get; set; }
		public T43 Item43 { get; set; }
		public T44 Item44 { get; set; }
		public T45 Item45 { get; set; }
		public T46 Item46 { get; set; }
		public T47 Item47 { get; set; }
		public T48 Item48 { get; set; }
		public T49 Item49 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2), T3 item3 = default(T3), T4 item4 = default(T4), T5 item5 = default(T5), T6 item6 = default(T6), T7 item7 = default(T7), T8 item8 = default(T8), T9 item9 = default(T9), T10 item10 = default(T10), T11 item11 = default(T11), T12 item12 = default(T12), T13 item13 = default(T13), T14 item14 = default(T14), T15 item15 = default(T15), T16 item16 = default(T16), T17 item17 = default(T17), T18 item18 = default(T18), T19 item19 = default(T19), T20 item20 = default(T20), T21 item21 = default(T21), T22 item22 = default(T22), T23 item23 = default(T23), T24 item24 = default(T24), T25 item25 = default(T25), T26 item26 = default(T26), T27 item27 = default(T27), T28 item28 = default(T28), T29 item29 = default(T29), T30 item30 = default(T30), T31 item31 = default(T31), T32 item32 = default(T32), T33 item33 = default(T33), T34 item34 = default(T34), T35 item35 = default(T35), T36 item36 = default(T36), T37 item37 = default(T37), T38 item38 = default(T38), T39 item39 = default(T39), T40 item40 = default(T40), T41 item41 = default(T41), T42 item42 = default(T42), T43 item43 = default(T43), T44 item44 = default(T44), T45 item45 = default(T45), T46 item46 = default(T46), T47 item47 = default(T47), T48 item48 = default(T48), T49 item49 = default(T49))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
			this.Item6 = item6;
			this.Item7 = item7;
			this.Item8 = item8;
			this.Item9 = item9;
			this.Item10 = item10;
			this.Item11 = item11;
			this.Item12 = item12;
			this.Item13 = item13;
			this.Item14 = item14;
			this.Item15 = item15;
			this.Item16 = item16;
			this.Item17 = item17;
			this.Item18 = item18;
			this.Item19 = item19;
			this.Item20 = item20;
			this.Item21 = item21;
			this.Item22 = item22;
			this.Item23 = item23;
			this.Item24 = item24;
			this.Item25 = item25;
			this.Item26 = item26;
			this.Item27 = item27;
			this.Item28 = item28;
			this.Item29 = item29;
			this.Item30 = item30;
			this.Item31 = item31;
			this.Item32 = item32;
			this.Item33 = item33;
			this.Item34 = item34;
			this.Item35 = item35;
			this.Item36 = item36;
			this.Item37 = item37;
			this.Item38 = item38;
			this.Item39 = item39;
			this.Item40 = item40;
			this.Item41 = item41;
			this.Item42 = item42;
			this.Item43 = item43;
			this.Item44 = item44;
			this.Item45 = item45;
			this.Item46 = item46;
			this.Item47 = item47;
			this.Item48 = item48;
			this.Item49 = item49;
		}

		public static implicit operator (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49)(tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49> original)
		{
			return (original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26, original.Item27, original.Item28, original.Item29, original.Item30, original.Item31, original.Item32, original.Item33, original.Item34, original.Item35, original.Item36, original.Item37, original.Item38, original.Item39, original.Item40, original.Item41, original.Item42, original.Item43, original.Item44, original.Item45, original.Item46, original.Item47, original.Item48, original.Item49);
		}

		public static implicit operator tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49>((T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49) original)
		{
			return new tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49>(original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26, original.Item27, original.Item28, original.Item29, original.Item30, original.Item31, original.Item32, original.Item33, original.Item34, original.Item35, original.Item36, original.Item37, original.Item38, original.Item39, original.Item40, original.Item41, original.Item42, original.Item43, original.Item44, original.Item45, original.Item46, original.Item47, original.Item48, original.Item49);
		}

	}

	public class tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }
		public T18 Item18 { get; set; }
		public T19 Item19 { get; set; }
		public T20 Item20 { get; set; }
		public T21 Item21 { get; set; }
		public T22 Item22 { get; set; }
		public T23 Item23 { get; set; }
		public T24 Item24 { get; set; }
		public T25 Item25 { get; set; }
		public T26 Item26 { get; set; }
		public T27 Item27 { get; set; }
		public T28 Item28 { get; set; }
		public T29 Item29 { get; set; }
		public T30 Item30 { get; set; }
		public T31 Item31 { get; set; }
		public T32 Item32 { get; set; }
		public T33 Item33 { get; set; }
		public T34 Item34 { get; set; }
		public T35 Item35 { get; set; }
		public T36 Item36 { get; set; }
		public T37 Item37 { get; set; }
		public T38 Item38 { get; set; }
		public T39 Item39 { get; set; }
		public T40 Item40 { get; set; }
		public T41 Item41 { get; set; }
		public T42 Item42 { get; set; }
		public T43 Item43 { get; set; }
		public T44 Item44 { get; set; }
		public T45 Item45 { get; set; }
		public T46 Item46 { get; set; }
		public T47 Item47 { get; set; }
		public T48 Item48 { get; set; }
		public T49 Item49 { get; set; }
		public T50 Item50 { get; set; }

		public tuple(T1 item1 = default(T1), T2 item2 = default(T2), T3 item3 = default(T3), T4 item4 = default(T4), T5 item5 = default(T5), T6 item6 = default(T6), T7 item7 = default(T7), T8 item8 = default(T8), T9 item9 = default(T9), T10 item10 = default(T10), T11 item11 = default(T11), T12 item12 = default(T12), T13 item13 = default(T13), T14 item14 = default(T14), T15 item15 = default(T15), T16 item16 = default(T16), T17 item17 = default(T17), T18 item18 = default(T18), T19 item19 = default(T19), T20 item20 = default(T20), T21 item21 = default(T21), T22 item22 = default(T22), T23 item23 = default(T23), T24 item24 = default(T24), T25 item25 = default(T25), T26 item26 = default(T26), T27 item27 = default(T27), T28 item28 = default(T28), T29 item29 = default(T29), T30 item30 = default(T30), T31 item31 = default(T31), T32 item32 = default(T32), T33 item33 = default(T33), T34 item34 = default(T34), T35 item35 = default(T35), T36 item36 = default(T36), T37 item37 = default(T37), T38 item38 = default(T38), T39 item39 = default(T39), T40 item40 = default(T40), T41 item41 = default(T41), T42 item42 = default(T42), T43 item43 = default(T43), T44 item44 = default(T44), T45 item45 = default(T45), T46 item46 = default(T46), T47 item47 = default(T47), T48 item48 = default(T48), T49 item49 = default(T49), T50 item50 = default(T50))
  		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
			this.Item6 = item6;
			this.Item7 = item7;
			this.Item8 = item8;
			this.Item9 = item9;
			this.Item10 = item10;
			this.Item11 = item11;
			this.Item12 = item12;
			this.Item13 = item13;
			this.Item14 = item14;
			this.Item15 = item15;
			this.Item16 = item16;
			this.Item17 = item17;
			this.Item18 = item18;
			this.Item19 = item19;
			this.Item20 = item20;
			this.Item21 = item21;
			this.Item22 = item22;
			this.Item23 = item23;
			this.Item24 = item24;
			this.Item25 = item25;
			this.Item26 = item26;
			this.Item27 = item27;
			this.Item28 = item28;
			this.Item29 = item29;
			this.Item30 = item30;
			this.Item31 = item31;
			this.Item32 = item32;
			this.Item33 = item33;
			this.Item34 = item34;
			this.Item35 = item35;
			this.Item36 = item36;
			this.Item37 = item37;
			this.Item38 = item38;
			this.Item39 = item39;
			this.Item40 = item40;
			this.Item41 = item41;
			this.Item42 = item42;
			this.Item43 = item43;
			this.Item44 = item44;
			this.Item45 = item45;
			this.Item46 = item46;
			this.Item47 = item47;
			this.Item48 = item48;
			this.Item49 = item49;
			this.Item50 = item50;
		}

		public static implicit operator (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50)(tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50> original)
		{
			return (original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26, original.Item27, original.Item28, original.Item29, original.Item30, original.Item31, original.Item32, original.Item33, original.Item34, original.Item35, original.Item36, original.Item37, original.Item38, original.Item39, original.Item40, original.Item41, original.Item42, original.Item43, original.Item44, original.Item45, original.Item46, original.Item47, original.Item48, original.Item49, original.Item50);
		}

		public static implicit operator tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50>((T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50) original)
		{
			return new tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50>(original.Item1, original.Item2, original.Item3, original.Item4, original.Item5, original.Item6, original.Item7, original.Item8, original.Item9, original.Item10, original.Item11, original.Item12, original.Item13, original.Item14, original.Item15, original.Item16, original.Item17, original.Item18, original.Item19, original.Item20, original.Item21, original.Item22, original.Item23, original.Item24, original.Item25, original.Item26, original.Item27, original.Item28, original.Item29, original.Item30, original.Item31, original.Item32, original.Item33, original.Item34, original.Item35, original.Item36, original.Item37, original.Item38, original.Item39, original.Item40, original.Item41, original.Item42, original.Item43, original.Item44, original.Item45, original.Item46, original.Item47, original.Item48, original.Item49, original.Item50);
		}

	}

}
