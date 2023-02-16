using Patterns.Bulder.Car_parts;
using Patterns.Bulder.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Bulder.Builders
{
    public class TeslaCarBuilder : ICarBuilder
    {
        private Car car;

        /// <summary>
        /// Сollection of servies that builder can provide to <see cref="Car"/> 
        /// </summary>
        public ICollection<ICarService> Services { get; set; } 

        public TeslaCarBuilder()
        {
            Services = new List<ICarService>();
            car = new Car("Tesla Model S Plaid");
        }

        /// <summary>
        /// Sets car body type of <see cref="IBody"/>
        /// </summary>
        public void SetCarBody()
        {
            car.Body = new AluminiumBody();
        }

        /// <summary>
        /// Sets car interior type of <see cref="IInterior"/>
        /// </summary>
        public void SetCarInterior()
        {
            car.Interior = new Interior("cool");
        }

        /// <summary>
        /// Sets car engine type of <see cref="IEngine"/>
        /// </summary>
        public void SetEngine()
        {
            car.Engine = new ElectricEngine();
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
