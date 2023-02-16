using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Bulder.Car_parts
{
	public class Interior : IInterior
	{
		public string Name { get; set; }

		internal Interior(string name)
		{
			Name = name;
		}	
	}
}
