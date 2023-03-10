using System.Text;
using System.Xml.Linq;

namespace Patterns.Builder
{
	public interface IEngine
	{
		string Name { get; }
		string Description { get; set; }

		/// <summary>
		/// Info about <see cref="IEngine"/>
		/// </summary>
		public string? Info()
		{
			StringBuilder stringBuilder = new StringBuilder();

			string str = "";

			str = Name != "" ? $"Name: {Name} \n " : "Name: Engine\n";
			stringBuilder.Append(str);

			str = Description != "" ? $"Description: {Description} \n " : "Description: \n";
			stringBuilder.Append(str);

			return stringBuilder.ToString();
		}
	}
}
