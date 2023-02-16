using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Bulder;

namespace Patterns.Extansions
{
    internal static class Extansions
    {
        /// <summary>
        /// Add new <see cref="ICarService"/> if we dont have it
        /// </summary>
        /// <param name="services"></param>
        /// <param name="carService"></param>
        public static void TryAddService(this ICollection<ICarService> services, ICarService carService)
        {
            if (!services.Contains(carService.GetType()))
            {
                services.Add(carService);
            }
        }

        /// <summary>
        /// Removes <see cref="IEnumerable{ICarService}">IEnumerable&lt;ICarService&gt;</see> from the collection
        /// </summary>
        /// <param name="services"></param>
        /// <typeparam name="services">The type returned from this method</typeparam>
        /// <param name="carService"></param>
        public static void RemoveService(this IEnumerable<ICarService> services, ICarService carService)
        {
            services.RemoveService(carService);
        }

        /// <summary>
        /// Check if collection of <see cref="name.space.typename{T}"/> contaions object of specific type
        /// </summary>
        /// <param name="services"></param>
        /// <param name="carService"></param>
        /// <returns><see cref="true"/> if contain</returns>
        public static bool Contains(this IEnumerable<ICarService> services, Type carService)
        {
            return services.FirstOrDefault(c => c.GetType() == carService) == null ? false : true;
        }

        /// <summary>
        /// Gets specific service from collection
        /// </summary>
        /// <param name="services"></param>
        /// <returns><see cref="ICarService"/> from collection of <see cref="IEnumerable{ICarService}">IEnumerable&lt;ICarService&gt;</see></returns>
        public static T? GetService<T>(this IEnumerable<ICarService> services) where T : ICarService
        {
            if (services.Count() != 0)
            {

                var service = services.Where(s => s.GetType() == typeof(T)).FirstOrDefault();

                if (service != null)
                {
                    return (T)service;
                }
                ///Downcast to specific class that implement <see cref="ICarService"
            }
            return default;
        }
    }
}
