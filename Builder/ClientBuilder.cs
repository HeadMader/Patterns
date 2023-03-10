namespace Patterns.Builder
{
	public class ClientBuilder
    {
        public static void TestBuilder()
        {
			var teslaCar = Director.BuildFullFeaturedCar(new TeslaCarBuilder());
			var teslaCarAutoPilot = teslaCar.CarServices.GetService<AutoPilot>();

			Console.WriteLine(teslaCar.ToString());

			if (teslaCarAutoPilot != null)
				teslaCarAutoPilot.Start();

			Console.WriteLine();

			var audiCar = Director.BuildCarWithGoogleMaps(new AudiCarBuilder());
			var audiGoogleMap = audiCar.CarServices.GetService<GoogleMap>();

			Console.WriteLine(audiCar.ToString());

			if (audiGoogleMap != null)
				Console.WriteLine(audiGoogleMap.Name);
		}
    }
}
