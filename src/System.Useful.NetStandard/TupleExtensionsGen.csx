#r "nuget:NETStandard.Library, 2.0.1"

using System.IO;
using System.Linq;

var templateParameters = 50;

var template = string.Empty;
template += $@"
namespace System
{{";

for (int i = 2; i <= 50; i++) 
{
	var range = Enumerable.Range(1, i);

	var templateParameters = string.Join(", ", range.Select(x => $"T{x}"));
	var constructorParameters = string.Join(", ", range.Select(x => $"T{x} item{x} = default(T{x})"));
	var implicitOperator = string.Join(", ", range.Select(x => $"original.Item{x}"));

	template += $"\n	public class tuple<{templateParameters}>\n	{{";

	foreach(var j in range)
	{
		template += $"\n		public T{j} Item{j} {{ get; set; }}";
	}

	template += $"\n\n		public tuple({constructorParameters})\n  		{{";

	foreach(var j in range)
	{
		template += $"\n			this.Item{j} = item{j};";
	}
	template += "\n		}\n";

	template += $"\n		public static implicit operator ({templateParameters})(tuple<{templateParameters}> original)\n		{{";
	template += $"\n			return ({implicitOperator});";
	template += "\n		}\n";

	template += $"\n		public static implicit operator tuple<{templateParameters}>(({templateParameters}) original)\n		{{";
	template += $"\n			return new tuple<{templateParameters}>({implicitOperator});";
	template += "\n		}\n";

	template += "\n	}\n";
}

template += $@"
}}
";

TextWriter tw = new StreamWriter("TupleExtensionsGen.cs");
tw.Write(template);
tw.Close();