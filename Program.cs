using Patterns.Bulder;
using Patterns.Bulder.Builders;
using Patterns.Bulder.Services;
using Patterns.Extansions;

namespace Patterns
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var teslaCar = CarFactory.BuildFullFeaturedCar(new TeslaCarBuilder());
			var teslaCarAutoPilot = teslaCar.CarServices.GetService<AutoPilot>();

			Console.WriteLine(teslaCar.ToString());

			if (teslaCarAutoPilot != null)
				teslaCarAutoPilot.Start();

			Console.WriteLine();

			var audiCar = CarFactory.BuildCarWithGoogleMaps(new AudiCarBuilder());
			var audiGoogleMap = audiCar.CarServices.GetService<GoogleMap>();

			Console.WriteLine(audiCar.ToString());

			if (audiGoogleMap != null)
				Console.WriteLine(audiGoogleMap.Name);
		}
	}
}