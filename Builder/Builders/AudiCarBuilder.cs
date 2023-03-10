namespace Patterns.Builder
{
    public class AudiCarBuilder : ICarBuilder
    {
        private Car car;

        /// <summary>
        /// Сollection of servies that builder can provide to <see cref="Car"/> 
        /// </summary>
        public ICollection<ICarService> Services { get; set; }

        public AudiCarBuilder()
        {
            Services = new List<ICarService>();
            car = new Car("Audi");
        }

        /// <summary>
        /// Sets car body type of <see cref="IBody"/>
        /// </summary>
        public void SetCarBody()
        {
            car.Body = new SteelBody();
        }

        /// <summary>
        /// Sets car interior type of <see cref="IInterior"/>
        /// </summary>
        public void SetCarInterior()
        {
            car.Interior = new Interior("AudiInterior");
        }

        /// <summary>
        /// Sets car engine type of <see cref="IEngine"/>
        /// </summary>
        public void SetEngine()
        {
            car.Engine = new DVSEngine();
        }

        /// <summary>
        /// Sets car services type of <see cref="ICarService"/>
        /// </summary>
        public void SetServices()
        {
            car.CarServices = Services;
        }

        /// <summary>
        /// Return <see cref="Car"/> with parameters that builder seted 
        /// </summary>
        /// <returns><see cref="Car"/></returns>
        public Car GetCar()
        {
            return car;
        }
    }
}
