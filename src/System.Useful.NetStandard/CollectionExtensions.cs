using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Collections.Generic
{
	public static class CollectionExtensions
    {
        public static Tuple<T1, T2> ToTuple<T1, T2>(this KeyValuePair<T1, T2> kvpair)
        {
            return new Tuple<T1, T2>(kvpair.Key, kvpair.Value);
        }

        public static void AddOrConcat<Tkey, Tvalue>(this Dictionary<Tkey, List<Tvalue>> dict, Tkey key, Tvalue val)
        {
            if (dict.ContainsKey(key))
            {
                dict[key].Add(val);
            }
            else
            {
                dict.Add(key, new List<Tvalue> { val });
            }
        }

        public static void AddOrUpdate<Tkey, Tvalue>(this Dictionary<Tkey, Tvalue> dict, Tkey key, Tvalue val)
        {
            if (dict.ContainsKey(key))
            {
                dict[key] = val;
            }
            else
            {
                dict.Add(key, val);
            }
        }

        //public static Tvalue? TryGetValue<Tkey, Tvalue>(this Dictionary<Tkey, Tvalue> dict, Tkey key) where Tvalue : struct
        //{
        //	if (dict.ContainsKey(key))
        //	{
        //		return null;
        //	}
        //	else
        //	{
        //		return dict[key];

        //	}
        //}

        public static Tvalue GetValueOrDefault<Tkey, Tvalue>(this Dictionary<Tkey, Tvalue> dict, Tkey key)
        {
            if (!dict.ContainsKey(key))
            {
                return default(Tvalue);
            }
            else
            {
                return dict[key];

            }
        }

        public static Tvalue GetAtIndexOrDefault<Tvalue>(this IEnumerable<Tvalue> collection, int index)
        {
            try
            {
                return collection.ElementAt(index);
            }
            catch
            {
                return default(Tvalue);
            }
        }

        public static Tvalue? GetValueOrNull<Tkey, Tvalue>(this Dictionary<Tkey, Tvalue> dict, Tkey key)
            where Tvalue : struct
        {
            if (!dict.ContainsKey(key))
            {
                return null;
            }
            else
            {
                return dict[key];

            }
        }

        public static Tvalue? GetAtIndexOrNull<Tvalue>(this IEnumerable<Tvalue> collection, int index)
            where Tvalue : struct
        {
            try
            {
                return collection.ElementAt(index);
            }
            catch
            {
                return null;
            }
        }

        public static void TryAddToValue<Tkey, Tval>(this IDictionary<Tkey, Tval> dic, Tkey key, Tval value)
        {
            if (!dic.ContainsKey(key))
            {
                dic.Add(key, value);
            }
        }

        public static void AddAll<Tkey, Tval>(this IDictionary<Tkey, Tval> dic, IDictionary<Tkey, Tval> fromDic)
        {
            if (fromDic != null)
                foreach (var item in fromDic)
                {
                    dic.Add(item.Key, item.Value);
                }
        }

        public static void AddOrUpdateAll<Tkey, Tval>(this IDictionary<Tkey, Tval> dic, IDictionary<Tkey, Tval> fromDic)
        {
            if (fromDic != null)
                foreach (var item in fromDic)
                {
                	if(dic.ContainsKey(item.Key))
                	{
                		dic[item.Key] = item.Value;
                	}
                	else 
                	{
                    	dic.Add(item.Key, item.Value);
                	}
                }
        }

        public static TimeSpan Sum(this IEnumerable<TimeSpan> times) 
        {
        	var sum = new TimeSpan(0, 0, 0);

        	foreach(var item in times)	
        	{
        		sum += item;
        	}

        	return sum;
        }

        public static TimeSpan Sum<TSource>(this IEnumerable<TSource> list, Func<TSource, TimeSpan> selector) 
        {
        	return list.Select(selector).Sum();
        }

        public static decimal SubstractAll<TSource>(this IEnumerable<TSource> list, Func<TSource, decimal> selector)
        {
            bool first = true;
            decimal result = 0;
            foreach (var item in list)
            {
                if (first)
                {
                    result = selector(item);
                    first = false;
                }
                else
                {
                    result -= selector(item);
                }
            }

            return result;
        }

        public static decimal MultiplyAll<TSource>(this IEnumerable<TSource> list, Func<TSource, decimal> selector)
        {
            decimal result = 1;
            foreach (var item in list)
            {
                result *= selector(item);
            }

            return result;
        }

        public static decimal DivideAll<TSource>(this IEnumerable<TSource> list, Func<TSource, decimal> selector)
        {
            bool first = true;
            decimal result = 0;
            foreach (var item in list)
            {
                if (first)
                {
                    result = selector(item);
                    first = false;
                }
                else
                {
                    result /= selector(item);
                }
            }

            return result;
        }

        public static decimal SafeDivideAllNoDefault<TSource>(this IEnumerable<TSource> list, Func<TSource, decimal> selector)
        {
            bool first = true;
            decimal result = 0;
            foreach (var item in list)
            {
                if (first)
                {
                    result = selector(item);
                    first = false;
                }
                else
                {
                    decimal oper = selector(item);
                    if (oper == 0)
                    {
                        result = 0;
                    }
                    else
                    {
                        result /= oper;
                    }
                }
            }

            return result;
        }

        public static decimal SafeDivideAll<TSource>(this IEnumerable<TSource> list, Func<TSource, decimal> selector, decimal defaultValue = 0)
        {
            bool first = true;
            decimal result = 0;
            foreach (var item in list)
            {
                if (first)
                {
                    result = selector(item);
                    first = false;
                }
                else
                {
                    decimal oper = selector(item);
                    if (oper == 0)
                    {
                        result = defaultValue;
                    }
                    else
                    {
                        result /= oper;
                    }
                }
            }

            return result;
        }
    }

    public class PyList<T> : IEnumerable<T>
    {
        private List<T> inner;

        public PyList()
        {
            inner = new List<T>();
        }

        public PyList(IEnumerable<T> fromenum)
        {
            inner = fromenum.ToList();
        }

        public static implicit operator PyList<T>(List<T> enumer)
        {
            return new PyList<T>(enumer);
        }

        public static implicit operator PyList<T>(T[] enumer)
        {
            return new PyList<T>(enumer);
        }

        public static implicit operator List<T>(PyList<T> enumer)
        {
            return new List<T>(enumer);
        }

        public static implicit operator T[] (PyList<T> enumer)
        {
            return new List<T>(enumer).ToArray();
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in inner)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return inner.GetEnumerator();
        }

        public List<T> this[string index]
        {
            get
            {
                if (index.Contains(":"))
                {
                    var idxs = index.Split(':');
                    //If it has 2 segments
                    if (idxs.Length == 2)
                    {
                        return Get2Index(idxs);
                    }
                    //If it has 3 segments
                    else if (idxs.Length == 3)
                    {
                        //3rd segment is empty
                        if (idxs[2].IsNullOrEmpty())
                        {
                            return Get2Index(idxs);
                        }
                        else
                        {
                            var list = Get2Index(idxs);
                            int idx3 = idxs[2].ParseInt();
                            if (idx3 == 0)
                            {
                                throw new ArgumentOutOfRangeException("Infinite elements of list");
                            }
                            else if (idx3 < 0)
                            {
                                idx3 = idx3.Abs();
                                var nlist = new List<T>(list);
                                nlist.Reverse();
                                return nlist.WhereL((x, i) => i % idx3 == 0);
                            }
                            else
                            {
                                idx3 = idx3.Abs();
                                return list.WhereL((x, i) => i % idx3 == 0);
                            }
                        }
                    }
                    //No action if more than 3 segments
                    else
                    {
                        throw new ArgumentOutOfRangeException("Too many segments");
                    }
                    return new List<T>();
                }
                else
                {
                    var idx = index.ParseInt();
                    if (idx < 0)
                    {
                        return new List<T> { inner.ElementAt(inner.Count + idx) };
                    }
                    else
                    {
                        return new List<T> { inner.ElementAt(idx) };
                    }
                }

            }
            set
            {

            }
        }

        public T this[int index]
        {
            get
            {
                if (index < 0)
                {
                    return inner.ElementAt(inner.Count + index);
                }
                else
                {
                    return inner.ElementAt(index);
                }
            }
            set
            {
                if (index < 0)
                {
                    inner[inner.Count + index] = value;
                }
                else
                {
                    inner[index] = value;
                }
            }
        }

        private List<T> Get2Index(string[] idxs)
        {
            int idx0 = 0;
            int idx1 = inner.Count - 1;
            int idxMax = inner.Count - 1;
            //If both empty
            if (idxs[1].IsNullOrEmpty() && idxs[0].IsNullOrEmpty())
            {
                return inner.ToList();
            }
            //If only first is empty
            else if (idxs[0].IsNullOrEmpty() && !idxs[1].IsNullOrEmpty())
            {
                idx1 = idxs[1].ParseInt();
            }
            //If only second is empty
            else if (idxs[1].IsNullOrEmpty() && !idxs[0].IsNullOrEmpty())
            {
                idx0 = idxs[0].ParseInt();
            }
            //If none of them are empty
            else if (!idxs[1].IsNullOrEmpty() && !idxs[0].IsNullOrEmpty())
            {
                idx0 = idxs[0].ParseInt();
                idx1 = idxs[1].ParseInt();
            }
            //Unknown
            else
            {
                throw new ArgumentOutOfRangeException("Unknown pattern");
            }

            if (idx0 < 0)
            {
                idx0 = idxMax + idx0 + 1;
            }
            if (idx1 < 0)
            {
                idx1 = idxMax + idx1 + 1;
            }
            if (idx0.Between(0, idxMax) && idx1.Between(0, idxMax))
            {
                if (idx0 == idx1)
                {
                    return new List<T>();
                }
                else if (idx0 < idx1)
                {
                    return inner.SublistL(idx0, idx1);
                }
                else
                {
                    return inner.Sublist(idx1, idx0).ReverseL();
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException("The given indexes are out of range");
            }
        }
    }

    public static class List
    {
        public static bool IsNotNullAndEmpty<TSource>(this IEnumerable<TSource> list)
        {
            return list != null && list.Count() > 0;
        }

        public static bool IsNullOrEmpty<TSource>(this IEnumerable<TSource> list)
        {
            return list == null || list.Count() == 0;
        }

        public static List<int> Range(int start, int count)
        {
            return Enumerable.Range(start, count).ToList();
        }

        public static List<TResult> Repeat<TResult>(TResult element, int count)
        {
            return Enumerable.Repeat(element, count).ToList();
        }
    }

    public static class Array 
    {
    	public static int[] Range(int start, int count)
        {
            return Enumerable.Range(start, count).ToArray();
        }

        public static TResult[] Repeat<TResult>(TResult element, int count)
        {
            return Enumerable.Repeat(element, count).ToArray();
        }
    }
}