using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder
{
    internal class GoogleMap : ICarService
	{
		public string Name => "GoogleMap";

		public void SetCordinats()
		{
			Console.WriteLine("cords seted");
		}
	}
}
