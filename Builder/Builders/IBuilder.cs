namespace Patterns.Builder
{
    internal interface ICarBuilder
    {
        /// <summary>
        /// Collection of services that builder can provide to
        /// </summary>
        ICollection<ICarService> Services { get; }

        /// <summary>
        /// Sets car engine type of <see cref="IEngine"/>
        /// </summary>
        void SetEngine();

        /// <summary>
        /// Sets car body type of <see cref="IBody"/>
        /// </summary>
        void SetCarBody();

        /// <summary>
        /// Sets car interior type of <see cref="IInterior"/>
        /// </summary>
        void SetCarInterior();

        /// <summary>
        /// Sets car services type of <see cref="ICarService"/>
        /// </summary>
        void SetServices();

        /// <summary>
        /// Return <see cref="Car"/> with parameters that builder seted 
        /// </summary>
        /// <returns><see cref="Car"/></returns>
        Car GetCar();
    }
}
