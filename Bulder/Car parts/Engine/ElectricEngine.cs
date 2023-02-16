using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Bulder
{
	class ElectricEngine : IEngine
	{
		public string Name => "ElectricEngine";
		public string Description { get; set; } = "Top";
	}
}
