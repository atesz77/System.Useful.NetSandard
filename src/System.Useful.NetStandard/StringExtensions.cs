using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace System
{
	 public static class StringExtensions
    {
        /// <summary>
        /// Indicates whether the specified string is null or an System.String.Empty string.
        /// </summary>
        /// <param name="s">The string to test.</param>
        /// <returns>true if the value parameter is null or an empty string (""); otherwise, false.</returns>
        public static bool IsNullOrEmpty(this string s)
        {
            return string.IsNullOrEmpty(s);
        }

        public static bool IsNotNullAndEmpty(this string s)
        {
            return !string.IsNullOrEmpty(s);
        }

        public static bool IsNullOrWhiteSpace(this string s)
        {
            return string.IsNullOrWhiteSpace(s);
        }

        public static bool IsNotNullAndWhiteSpace(this string s)
        {
            return !string.IsNullOrWhiteSpace(s);
        }

        //public static bool IsNullOrEmptyOrWhiteSpace(this string s)
        //{
        //    return string.IsNullOrEmpty(s) || string.IsNullOrWhiteSpace(s);
        //}

        public static string Format(this string s, params object[] parameters)
        {
            return string.Format(s, parameters);
        }

        public static string Join<T>(this IEnumerable<T> list, string separator)
        {
            return string.Join(separator, list);
        }

        public static string[] Split(this string s, params string[] separators)
        {
            return s.Split(separators, StringSplitOptions.None);
        }

        public static string[] SplitIgnore(this string s, char startIgnore, char endIgnore, params char[] separators)
        {
            List<string> splitted = new List<string>();

            string actual = "";
            int inIgnore = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (separators.Any(x => s[i] == x) && inIgnore == 0)
                {
                    splitted.Add(actual);
                    actual = "";
                }
                else
                {
                    if (s[i] == startIgnore) inIgnore++;
                    if (s[i] == endIgnore) inIgnore--;
                    actual += s[i];
                }
            }
            splitted.Add(actual);

            return splitted.ToArray();
        }

        public static byte[] GetBytes(this string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        public static string GetString(this byte[] bytes)
        {
            char[] chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }

        public static string ByteArrayJoin(this byte[] bytes)
        {
            return string.Join("-", bytes);
        }

        public static byte[] ByteArraySplit(this string bytes)
        {
            return bytes.Split('-').Select(x => byte.Parse(x)).ToArray();
        }

        /// <summary>
        /// Removes all numbers from the given string
        /// </summary>
        /// <param name="text">the string</param>
        /// <returns></returns>
        public static string UnNumberize(this string text)
        {
            return Regex.Replace(text, @"[\d-]", string.Empty);
        }

        public static bool IsNumber(this string text)
        {
            return text != null && text.TryParseDoubleInvariant().HasValue;
        }

        public static bool IsGuid(this string text)
        {
            return text != null && text.TryParseGuid().HasValue;
        }

        public static int GetNumber(this string c, int offset = 0)
        {
            return c[0].GetNumber(offset);
        }

        public static int GetNumberOffset(this string c, int offset = 9)
        {
            return c.GetNumber(offset);
        }
    }

    public class StringEx
    {
        private string content;

        public char this[int index]
        {
            get
            {
                return content[index];
            }
            set
            {
                var chars = content.ToCharArray();
                chars[index] = value;
                content = new string(chars);
            }
        }

        public string GetContent()
        {
            return content;
        }

        public StringEx()
        {
        }

        public StringEx(string _content)
        {
            content = _content;
        }

        public static implicit operator string (StringEx str)
        {
            return str.GetContent();
        }

        public static implicit operator StringEx(string str)
        {
            return new StringEx(str);
        }

        public override bool Equals(object obj)
        {
            if (obj is string)
            {
                return obj.Equals(content);
            }
            else if (obj is StringEx)
            {
                (obj as StringEx).GetContent().Equals(content);
            }

            return this.Equals(obj);
        }

        public override int GetHashCode()
        {
            return content.GetHashCode();
        }

        public override string ToString()
        {
            return content;
        }

    }
}