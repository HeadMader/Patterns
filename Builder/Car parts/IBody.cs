using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder
{
	public interface IBody
	{
		string Name { get; }

		/// <summary>
		/// Info about <see cref="IBody"/>
		/// </summary>
		public string? Info()
		{
			StringBuilder stringBuilder = new StringBuilder();

			string str = "";

			str = Name != "" ? $"Name: {Name} \n " : "Name: Body\n";
			stringBuilder.Append(str);

			return stringBuilder.ToString();
		}
	}
}
