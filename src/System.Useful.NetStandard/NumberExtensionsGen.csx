#r "nuget:NETStandard.Library, 2.0.1"

using System.IO;

string[] allTypes = new[] { "byte", "sbyte", "short", "ushort", "int", "uint", "long", "ulong", "float", "double", "decimal" };
string[] signedTypes = new[] { "sbyte", "short", "int", "long", "float", "double", "decimal" };
string[] unsignedTypes = new[] { "byte", "ushort", "uint", "ulong" };
string[] allTypesCap = new[] { "Byte", "SByte", "Short", "UShort", "Int", "UInt", "Long", "ULong", "Float", "Double", "Decimal" };
string[] intTypes = new[] { "byte", "sbyte", "short", "ushort", "int", "uint", "long", "ulong" };
string[] intTypesBox = new[] { "Byte", "SByte", "Int16", "UInt16", "Int32", "UInt32", "Int64", "UInt64" };
string[] intTypesCap = new[] { "Byte", "SByte", "Short", "UShort", "Int", "UInt", "Long", "ULong" };
string[] realTypes = new[] { "float", "double", "decimal" };
string[] realTypesCap = new[] { "Float", "Double", "Decimal" };

var template = string.Empty;
template += $@"
namespace System
{{
	public static class NumberExtensionsGen
    {{";

foreach (var item in allTypes) {
	template += $@"

		public static bool Between(this {item} num, {item} start, {item} end)
        {{
            return start <= num && num <= end;
        }}
	";
}

foreach (var item in intTypes) {
	template += $@"

		public static void Times(this {item} count, Action act)
        {{
            for ({item} i = 0; i < count; i++)
            {{
                act();
            }}
        }}

        public static void Times(this {item} count, Action<{item}> act)
        {{
            for ({item} i = 0; i < count; i++)
            {{
            	var locali = i;
                act(locali);
            }}
        }}
	";
}

template += $@"
    }}
}}
";


TextWriter tw = new StreamWriter("NumberExtensionsGen.cs");
tw.Write(template);
tw.Close();