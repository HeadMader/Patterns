namespace Patterns.Builder
{
	internal class Director
	{
		/// <summary>
		/// Sets all nessessory components to the <see cref="Car"></see>
		/// </summary>
		/// <param name="carBuilder"></param>
		/// <returns><see cref="Car"/></returns>
		public static Car BuildCarWithGoogleMaps(ICarBuilder carBuilder)
		{
			carBuilder.SetEngine();
			carBuilder.SetCarBody();
			carBuilder.SetCarInterior();
			carBuilder.Services.TryAddService(new GoogleMap());
			carBuilder.SetServices();
			return carBuilder.GetCar();
		}
		public static Car BuildFullFeaturedCar(ICarBuilder carBuilder)
		{
			carBuilder.SetEngine();
			carBuilder.SetCarBody();
			carBuilder.SetCarInterior();
			carBuilder.Services.TryAddService(new GoogleMap());
			carBuilder.Services.TryAddService(new AutoPilot());
			carBuilder.SetServices();
			return carBuilder.GetCar();
		}
	}
}
