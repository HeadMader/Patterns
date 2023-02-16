using Patterns.Bulder.Car_parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Bulder
{
	public class Car
	{
		public string Name { get; set; }
		public IEngine Engine { get; set; }
		public IBody Body { get; set; }
		public IInterior Interior { get; set; }
		public IEnumerable<ICarService> CarServices { set; get; }

		public Car() : this("Car") { }

		public Car(string name)
		{
			this.Name = name;
		}

		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();

			string str = "";
			
			str = Name != "" ? $"Name: {Name}\n" : "Name: \n";
			stringBuilder.Append(str);

			str = Engine != null ? $"Engine: \n {Engine.Info()}\n" : "Engine: \n";
			stringBuilder.Append(str);

			str = Body != null ? $"Body: \n {Body.Info()}\n" : "Body: \n";
			stringBuilder.Append(str);

			str = Interior != null ? $"Interior: \n {Interior.Info()}\n" : "Interior: \n";
			stringBuilder.Append(str);

			return stringBuilder.ToString();
		}
	}
}
