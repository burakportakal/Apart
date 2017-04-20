using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulatedAnnealing
{
    class TourManager
    {
        // Holds our cities
        private static List<City> destinationCities = new List<City>();

        // Adds a destination city
        public static void addCity(City city)
        {
            destinationCities.Add(city);
        }

        // Get a city
        public static City getCity(int index)
        {
            return (City)destinationCities.ElementAt(index);
        }

        // Get the number of destination cities
        public static int numberOfCities()
        {
            return destinationCities.Count();
        }
    }
}
