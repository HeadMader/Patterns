using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Bulder.Car_parts.Engine
{

	public class DVSEngine : IEngine 
	{
		public string Name => "DVSEngine";
		public string Description { get; set; } = "1.2l";
	}
}
