using System;
using System.Collections.Generic;
using System.Linq;

namespace System
{
    public static class T
    {
        public static Tret ry<Tval, Tret>(Tval tryObject, Func<Tval, Tret> tryValue, Tret defaultValue = default(Tret))
        {
            if (tryObject == null)
            {
                return defaultValue;
            }

            try
            {
                return tryValue(tryObject);
            }
            catch
            {
                return defaultValue;
            }
        }

        public static void ry<Tval>(Tval tryObject, Action<Tval> tryCall)
        {
            if (tryObject != null)
            {
                tryCall(tryObject);
            }
        }

    }

    public static class Ar
    {
        public static string[] ray(params string[] elements)
        {
            return elements;
        }

        public static string[] ray(params int[] elements)
        {
            return elements.Select(x => x.ToString()).ToArray();
        }
    }

    public static class Li
    {
        public static List<string> st(params string[] elements)
        {
            return elements.ToList();
        }

        public static List<string> st(params int[] elements)
        {
            return elements.Select(x => x.ToString()).ToList();
        }
    }
}