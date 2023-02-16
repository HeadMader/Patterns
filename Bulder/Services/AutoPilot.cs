using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Bulder.Services
{
	internal class AutoPilot : ICarService
	{
		public string Name => "AutoPilot";
		
		public void Start()
		{
			Console.WriteLine("AutoPilot started");
		}

		public void Stop()
		{
			Console.WriteLine("AutoPilot stoped");
		}
	}
}
