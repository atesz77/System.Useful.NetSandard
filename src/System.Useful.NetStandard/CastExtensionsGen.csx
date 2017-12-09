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

Dictionary<string,string> allTypesShort = new Dictionary<string,string>
 { 
	 { "byte"    , "B" }   ,
	 { "sbyte"   , "SB" }  ,
	 { "short"   , "S" }   ,
	 { "int16"   , "S" }   ,
	 { "ushort"  , "US" }  ,
	 { "uint16"  , "US" }  ,
	 { "int32"     , "I" }   ,
	 { "int"     , "I" }   ,
	 { "uint32"    , "UI" }  ,
	 { "uint"    , "UI" }  ,
	 { "int64"    , "L" }   ,
	 { "long"    , "L" }   ,
	 { "ulong"   , "UL" }  ,
	 { "uint64"   , "UL" }  ,
	 { "float"   , "F" }   ,
	 { "double"  , "D" }   ,
	 { "decimal" , "DE" }
 };

var template = string.Empty;
template += $@"
namespace System
{{
	public static class CastExtensionsGen
    {{";

foreach (var cfrom in allTypes) {
	template += $"\n		#region {cfrom.ToUpper()}";

	foreach (var cto in allTypes) {
		template += $@"

		/// <summary>
		/// Cast a number to {cto.ToUpper()}
		/// </summary>
		/// <param name='number'></param>
		/// <returns></returns>
		public static {cto} {allTypesShort[cto]}(this {cfrom} number)
		{{
			return ({cto})number;
		}}
		";
	}

	template += "\n		#endregion";
}

template += "\n\n		#region BOOL";

foreach (var item in allTypes) {
	template += $@"

		/// <summary>
		/// Cast a number to BOOL
		/// </summary>
		/// <param name='number'></param>
		/// <returns></returns>
		public static bool BO(this {item} number)
		{{
			return number == 0 ? false : true;
		}}
	";
}

foreach (var cto in allTypes) {
	template += $@"

		/// <summary>
		/// Cast a BOOL to {cto.ToUpper()}
		/// </summary>
		/// <param name='number'></param>
		/// <returns></returns>
		public static {cto} {allTypesShort[cto]}(this bool expr)
		{{
			return expr ? ({cto})1 : ({cto})0;
		}}
	";
}

template += "\n		#endregion";

template += $@"
    }}
}}
";


TextWriter tw = new StreamWriter("CastExtensionsGen.cs");
tw.Write(template);
tw.Close();