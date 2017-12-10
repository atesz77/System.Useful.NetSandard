using System.Collections;
using System.Collections.Generic;

namespace System.Linq
{
    public static class LinqExtensions
    {
        public static List<TSource> ConcatL<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
        {
            return first.Concat(second).ToList();
        }

        public static TSource[] ConcatA<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
        {
            return first.Concat(second).ToArray();
        }

        public static List<T> OrderByL<T, Tkey>(this IEnumerable<T> list, Func<T, Tkey> keySelector)
        {
            return list.OrderBy(keySelector).ToList();
        }

        public static T[] OrderByA<T, Tkey>(this IEnumerable<T> list, Func<T, Tkey> keySelector)
        {
            return list.OrderBy(keySelector).ToArray();
        }

        public static List<T> OrderByDescendingL<T, Tkey>(this IEnumerable<T> list, Func<T, Tkey> keySelector)
        {
            return list.OrderByDescending(keySelector).ToList();
        }

        public static T[] OrderByDescendingA<T, Tkey>(this IEnumerable<T> list, Func<T, Tkey> keySelector)
        {
            return list.OrderByDescending(keySelector).ToArray();
        }

        public static List<T> OrderByL<T, Tkey>(this IEnumerable<T> list, Func<T, Tkey> keySelector, IComparer<Tkey> comparer)
        {
            return list.OrderBy(keySelector, comparer).ToList();
        }

        public static T[] OrderByA<T, Tkey>(this IEnumerable<T> list, Func<T, Tkey> keySelector, IComparer<Tkey> comparer)
        {
            return list.OrderBy(keySelector, comparer).ToArray();
        }

        public static List<T> OrderByDescendingL<T, Tkey>(this IEnumerable<T> list, Func<T, Tkey> keySelector, IComparer<Tkey> comparer)
        {
            return list.OrderByDescending(keySelector, comparer).ToList();
        }

        public static T[] OrderByDescendingA<T, Tkey>(this IEnumerable<T> list, Func<T, Tkey> keySelector, IComparer<Tkey> comparer)
        {
            return list.OrderByDescending(keySelector, comparer).ToArray();
        }

        public static List<TResult> CastL<TResult>(this IEnumerable source)
        {
            return source.Cast<TResult>().ToList();
        }

        public static TResult[] CastA<TResult>(this IEnumerable source)
        {
            return source.Cast<TResult>().ToArray();
        }

        public static List<TSource> DistinctL<TSource>(this IEnumerable<TSource> source)
        {
            return source.Distinct().ToList();
        }
        public static List<TSource> DistinctL<TSource>(this IEnumerable<TSource> source, IEqualityComparer<TSource> comparer)
        {
            return source.Distinct(comparer).ToList();
        }

        public static TSource[] DistinctA<TSource>(this IEnumerable<TSource> source)
        {
            return source.Distinct().ToArray();
        }
        public static TSource[] DistinctA<TSource>(this IEnumerable<TSource> source, IEqualityComparer<TSource> comparer)
        {
            return source.Distinct(comparer).ToArray();
        }

        public static List<TSource> ExceptL<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
        {
            return first.Except(second).ToList();
        }
        public static List<TSource> ExceptL<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
        {
            return first.Except(second, comparer).ToList();
        }

        public static TSource[] ExceptA<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
        {
            return first.Except(second).ToArray();
        }
        public static TSource[] ExceptA<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
        {
            return first.Except(second, comparer).ToArray();
        }

        public static List<TSource> IntersectL<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
        {
            return first.Intersect(second).ToList();
        }

        public static List<TSource> IntersectL<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
        {
            return first.Intersect(second, comparer).ToList();
        }

        public static TSource[] IntersectA<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
        {
            return first.Intersect(second).ToArray();
        }

        public static TSource[] IntersectA<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
        {
            return first.Intersect(second, comparer).ToArray();
        }

        public static List<TResult> JoinL<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, TResult> resultSelector)
        {
            return outer.Join(inner, outerKeySelector, innerKeySelector, resultSelector).ToList();
        }

        public static List<TResult> JoinL<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, TResult> resultSelector, IEqualityComparer<TKey> comparer)
        {
            return outer.Join(inner, outerKeySelector, innerKeySelector, resultSelector, comparer).ToList();
        }

        public static TResult[] JoinA<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, TResult> resultSelector)
        {
            return outer.Join(inner, outerKeySelector, innerKeySelector, resultSelector).ToArray();
        }

        public static TResult[] JoinA<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, TResult> resultSelector, IEqualityComparer<TKey> comparer)
        {
            return outer.Join(inner, outerKeySelector, innerKeySelector, resultSelector, comparer).ToArray();
        }

        public static List<TResult> OfTypeL<TResult>(this IEnumerable source)
        {
            return source.OfType<TResult>().ToList();
        }

        public static TResult[] OfTypeA<TResult>(this IEnumerable source)
        {
            return source.OfType<TResult>().ToArray();
        }

        public static List<TSource> ReverseL<TSource>(this IEnumerable<TSource> source)
        {
            return source.Reverse().ToList();
        }

        public static TSource[] ReverseA<TSource>(this IEnumerable<TSource> source)
        {
            return source.Reverse().ToArray();
        }

        public static List<TResult> SelectL<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, int, TResult> selector)
        {
            return source.Select(selector).ToList();
        }
        public static List<TResult> SelectL<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
        {
            return source.Select(selector).ToList();
        }

        public static TResult[] SelectA<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, int, TResult> selector)
        {
            return source.Select(selector).ToArray();
        }
        public static TResult[] SelectA<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
        {
            return source.Select(selector).ToArray();
        }


        public static List<TResult> SelectManyL<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, int, IEnumerable<TResult>> selector)
        {
            return source.SelectMany(selector).ToList();
        }
        public static List<TResult> SelectManyL<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector)
        {
            return source.SelectMany(selector).ToList();
        }
        public static List<TResult> SelectManyL<TSource, TCollection, TResult>(this IEnumerable<TSource> source, Func<TSource, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector)
        {
            return source.SelectMany(collectionSelector, resultSelector).ToList();
        }
        public static List<TResult> SelectManyL<TSource, TCollection, TResult>(this IEnumerable<TSource> source, Func<TSource, int, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector)
        {
            return source.SelectMany(collectionSelector, resultSelector).ToList();
        }

        public static TResult[] SelectManyA<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, int, IEnumerable<TResult>> selector)
        {
            return source.SelectMany(selector).ToArray();
        }
        public static TResult[] SelectManyA<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector)
        {
            return source.SelectMany(selector).ToArray();
        }
        public static TResult[] SelectManyA<TSource, TCollection, TResult>(this IEnumerable<TSource> source, Func<TSource, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector)
        {
            return source.SelectMany(collectionSelector, resultSelector).ToArray();
        }
        public static TResult[] SelectManyA<TSource, TCollection, TResult>(this IEnumerable<TSource> source, Func<TSource, int, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector)
        {
            return source.SelectMany(collectionSelector, resultSelector).ToArray();
        }

        public static List<TSource> SkipL<TSource>(this IEnumerable<TSource> source, int count)
        {
            return source.Skip(count).ToList();
        }
        public static List<TSource> SkipWhileL<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
        {
            return source.SkipWhile(predicate).ToList();
        }
        public static List<TSource> SkipWhileL<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            return source.SkipWhile(predicate).ToList();
        }


        public static TSource[] SkipA<TSource>(this IEnumerable<TSource> source, int count)
        {
            return source.Skip(count).ToArray();
        }
        public static TSource[] SkipWhileA<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
        {
            return source.SkipWhile(predicate).ToArray();
        }
        public static TSource[] SkipWhileA<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            return source.SkipWhile(predicate).ToArray();
        }

        public static List<TSource> TakeL<TSource>(this IEnumerable<TSource> source, int count)
        {
            return source.Take(count).ToList();
        }
        public static List<TSource> TakeWhileL<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
        {
            return source.TakeWhile(predicate).ToList();
        }
        public static List<TSource> TakeWhileL<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            return source.TakeWhile(predicate).ToList();
        }

        public static TSource[] TakeA<TSource>(this IEnumerable<TSource> source, int count)
        {
            return source.Take(count).ToArray();
        }
        public static TSource[] TakeWhileA<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
        {
            return source.TakeWhile(predicate).ToArray();
        }
        public static TSource[] TakeWhileA<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            return source.TakeWhile(predicate).ToArray();
        }

        public static List<TSource> ThenByL<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            return source.ThenBy(keySelector).ToList();
        }
        public static List<TSource> ThenByL<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
        {
            return source.ThenBy(keySelector, comparer).ToList();
        }
        public static List<TSource> ThenByDescendingL<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            return source.ThenByDescending(keySelector).ToList();
        }
        public static List<TSource> ThenByDescendingL<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
        {
            return source.ThenByDescending(keySelector, comparer).ToList();
        }


        public static TSource[] ThenByA<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            return source.ThenBy(keySelector).ToArray();
        }
        public static TSource[] ThenByA<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
        {
            return source.ThenBy(keySelector, comparer).ToArray();
        }
        public static TSource[] ThenByDescendingA<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            return source.ThenByDescending(keySelector).ToArray();
        }
        public static TSource[] ThenByDescendingA<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
        {
            return source.ThenByDescending(keySelector, comparer).ToArray();
        }


        public static List<TSource> UnionL<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
        {
            return first.Union(second).ToList();
        }
        public static List<TSource> UnionL<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
        {
            return first.Union(second, comparer).ToList();
        }

        public static TSource[] UnionA<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
        {
            return first.Union(second).ToArray();
        }
        public static TSource[] UnionA<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
        {
            return first.Union(second, comparer).ToArray();
        }

        public static List<TSource> WhereL<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
        {
            return source.Where(predicate).ToList();
        }
        public static List<TSource> WhereL<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            return source.Where(predicate).ToList();
        }

        public static TSource[] WhereA<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
        {
            return source.Where(predicate).ToArray();
        }
        public static TSource[] WhereA<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            return source.Where(predicate).ToArray();
        }




        public static IEnumerable<TResult> WhereSelect<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, bool> predicate, Func<TSource, int, TResult> selector)
        {
            return source.Where(predicate).Select(selector);
        }
        public static IEnumerable<TResult> WhereSelect<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> selector)
        {
            return source.Where(predicate).Select(selector);
        }
        public static IEnumerable<TResult> WhereSelect<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate, Func<TSource, int, TResult> selector)
        {
            return source.Where(predicate).Select(selector);
        }
        public static IEnumerable<TResult> WhereSelect<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate, Func<TSource, TResult> selector)
        {
            return source.Where(predicate).Select(selector);
        }


        public static List<TResult> WhereSelectL<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, bool> predicate, Func<TSource, int, TResult> selector)
        {
            return source.Where(predicate).Select(selector).ToList();
        }
        public static List<TResult> WhereSelectL<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> selector)
        {
            return source.Where(predicate).Select(selector).ToList();
        }
        public static List<TResult> WhereSelectL<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate, Func<TSource, int, TResult> selector)
        {
            return source.Where(predicate).Select(selector).ToList();
        }
        public static List<TResult> WhereSelectL<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate, Func<TSource, TResult> selector)
        {
            return source.Where(predicate).Select(selector).ToList();
        }

        public static TResult[] WhereSelectA<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, bool> predicate, Func<TSource, int, TResult> selector)
        {
            return source.Where(predicate).Select(selector).ToArray();
        }
        public static TResult[] WhereSelectA<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> selector)
        {
            return source.Where(predicate).Select(selector).ToArray();
        }
        public static TResult[] WhereSelectA<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate, Func<TSource, int, TResult> selector)
        {
            return source.Where(predicate).Select(selector).ToArray();
        }
        public static TResult[] WhereSelectA<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate, Func<TSource, TResult> selector)
        {
            return source.Where(predicate).Select(selector).ToArray();
        }




        public static List<TResult> ZipL<TFirst, TSecond, TResult>(this IEnumerable<TFirst> first, IEnumerable<TSecond> second, Func<TFirst, TSecond, TResult> resultSelector)
        {
            return first.Zip(second, resultSelector).ToList();
        }

        public static TResult[] ZipA<TFirst, TSecond, TResult>(this IEnumerable<TFirst> first, IEnumerable<TSecond> second, Func<TFirst, TSecond, TResult> resultSelector)
        {
            return first.Zip(second, resultSelector).ToArray();
        }



        public static IEnumerable<TSource> Sublist<TSource>(this IEnumerable<TSource> source, int from, int to)
        {
            return source.Skip(from).Take(to - from + 1);
        }

        public static List<TSource> SublistL<TSource>(this IEnumerable<TSource> source, int from, int to)
        {
            return source.Sublist(from, to).ToList();
        }

        public static TSource[] SublistA<TSource>(this IEnumerable<TSource> source, int from, int to)
        {
            return source.Sublist(from, to).ToArray();
        }

        public static IEnumerable<TSource> Splice<TSource>(this IEnumerable<TSource> source, int from, int count)
        {
            return source.Skip(from).Take(count);
        }

        public static List<TSource> SpliceL<TSource>(this IEnumerable<TSource> source, int from, int count)
        {
            return source.Splice(from, count).ToList();
        }

        public static TSource[] SpliceA<TSource>(this IEnumerable<TSource> source, int from, int count)
        {
            return source.Splice(from, count).ToArray();
        }



        public static IEnumerable<Tuple<T1, T2>> ToTuples<T1, T2>(this Dictionary<T1, T2> dict)
        {
            return dict.Select(x => new Tuple<T1, T2>(x.Key, x.Value));
        }

        public static List<Tuple<T1, T2>> ToTuplesL<T1, T2>(this Dictionary<T1, T2> dict)
        {
            return dict.ToTuples().ToList();
        }

        public static Tuple<T1, T2>[] ToTuplesA<T1, T2>(this Dictionary<T1, T2> dict)
        {
            return dict.ToTuples().ToArray();
        }

        public static Dictionary<Tkey, Tval> ToDictionary<Tkey, Tval>(this IEnumerable<KeyValuePair<Tkey, Tval>> kvlist)
        {
            return kvlist.ToDictionary(k => k.Key, v => v.Value);
        }

        public static T Second<T>(this IEnumerable<T> enumeration)
        {
            return enumeration.ElementAt(1);
        }

        public static T Third<T>(this IEnumerable<T> enumeration)
        {
            return enumeration.ElementAt(2);
        }

        public static void Apply<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (T element in source)
            {
                action(element);
            }
        }

        public static void ApplyL<T>(this List<T> source, Action<T> action)
        {
            foreach (T element in source)
            {
                action(element);
            }
        }

        public static void ApplyA<T>(this T[] source, Action<T> action)
        {
            for (int i = 0; i < source.Length; i++)
            {
                var item = source[i];
                action(item);
            }
        }


        public static Dictionary<TKey, List<TSource>> GroupByD<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            return source.GroupBy(keySelector).ToDictionary(k => k.Key, v => v.ToList());
        }
        public static Dictionary<TKey, List<TSource>> GroupByD<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
        {
            return source.GroupBy(keySelector, comparer).ToDictionary(k => k.Key, v => v.ToList());
        }
        public static Dictionary<TKey, List<TElement>> GroupByD<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
        {
            return source.GroupBy(keySelector, elementSelector).ToDictionary(k => k.Key, v => v.ToList());
        }
        public static Dictionary<TKey, List<TElement>> GroupByD<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
        {
            return source.GroupBy(keySelector, elementSelector, comparer).ToDictionary(k => k.Key, v => v.ToList());
        }

        public static IGrouping<TKey, TSource>[] GroupByA<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            return source.GroupBy(keySelector).ToArray();
        }
        public static IGrouping<TKey, TSource>[] GroupByA<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
        {
            return source.GroupBy(keySelector, comparer).ToArray();
        }
        public static IGrouping<TKey, TElement>[] GroupByA<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
        {
            return source.GroupBy(keySelector, elementSelector).ToArray();
        }
        public static IGrouping<TKey, TElement>[] GroupByA<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
        {
            return source.GroupBy(keySelector, elementSelector, comparer).ToArray();
        }

        public static List<IGrouping<TKey, TSource>> GroupByL<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            return source.GroupBy(keySelector).ToList();
        }
        public static List<IGrouping<TKey, TSource>> GroupByL<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
        {
            return source.GroupBy(keySelector, comparer).ToList();
        }
        public static List<IGrouping<TKey, TElement>> GroupByL<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
        {
            return source.GroupBy(keySelector, elementSelector).ToList();
        }
        public static List<IGrouping<TKey, TElement>> GroupByL<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
        {
            return source.GroupBy(keySelector, elementSelector, comparer).ToList();
        }




        public static TResult[] GroupByA<TSource, TKey, TResult>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TKey, IEnumerable<TSource>, TResult> resultSelector)
        {
            return source.GroupBy(keySelector, resultSelector).ToArray();
        }
        public static TResult[] GroupByA<TSource, TKey, TResult>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TKey, IEnumerable<TSource>, TResult> resultSelector, IEqualityComparer<TKey> comparer)
        {
            return source.GroupBy(keySelector, resultSelector, comparer).ToArray();
        }

        public static List<TResult> GroupByL<TSource, TKey, TResult>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TKey, IEnumerable<TSource>, TResult> resultSelector)
        {
            return source.GroupBy(keySelector, resultSelector).ToList();
        }
        public static List<TResult> GroupByL<TSource, TKey, TResult>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TKey, IEnumerable<TSource>, TResult> resultSelector, IEqualityComparer<TKey> comparer)
        {
            return source.GroupBy(keySelector, resultSelector, comparer).ToList();
        }





        public static TResult[] GroupByA<TSource, TKey, TElement, TResult>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, Func<TKey, IEnumerable<TElement>, TResult> resultSelector)
        {
            return source.GroupBy(keySelector, elementSelector, resultSelector).ToArray();
        }
        public static TResult[] GroupByA<TSource, TKey, TElement, TResult>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, Func<TKey, IEnumerable<TElement>, TResult> resultSelector, IEqualityComparer<TKey> comparer)
        {
            return source.GroupBy(keySelector, elementSelector, resultSelector, comparer).ToArray();
        }

        public static List<TResult> GroupByL<TSource, TKey, TElement, TResult>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, Func<TKey, IEnumerable<TElement>, TResult> resultSelector)
        {
            return source.GroupBy(keySelector, elementSelector, resultSelector).ToList();
        }
        public static List<TResult> GroupByL<TSource, TKey, TElement, TResult>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, Func<TKey, IEnumerable<TElement>, TResult> resultSelector, IEqualityComparer<TKey> comparer)
        {
            return source.GroupBy(keySelector, elementSelector, resultSelector, comparer).ToList();
        }

    }
}
