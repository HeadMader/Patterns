using System.Text;

namespace Patterns.Builder
{
	public class Car
	{
		public string Name { get; private set; }
		private IEngine _engine;
		private IBody _body;
		private IInterior _interior;

		public IEngine Engine
		{
			get => _engine;
			set
			{
				if (_engine == null) 
					_engine = value;
			}
		}

		public IBody Body
		{
			get => _body;
			set
			{
				if (_body == null)
					_body = value;
			}
		}

		public IInterior Interior
		{
			get => _interior;
			set
			{
				if (value != null)
					_interior = value;
			}
		}

		public ICollection<ICarService> CarServices { get; set; }

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
