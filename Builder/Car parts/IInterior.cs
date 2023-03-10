using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder
{
	public interface IInterior
	{
		string Name { get; set; }

		/// <summary>
		/// Info about <see cref="IInterior"/>
		/// </summary>
		public string? Info()
		{
			StringBuilder stringBuilder = new StringBuilder();

			string str = "";

			str = Name != "" ? $"Name: {Name} \n " : "Name: Interior\n";
			stringBuilder.Append(str);

			return stringBuilder.ToString();
		}
	}
}
