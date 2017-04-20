using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulatedAnnealing
{
    static class MyExtensions
    {
        private static Random rng = new Random();
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
    class Tour
    {

        // Holds our tour of cities
        private List<City> tour = new List<City>();
        // Cache
        private int distance = 0;

        // Constructs a blank tour
        public Tour()
        {
            for (int i = 0; i < TourManager.numberOfCities(); i++)
            {
                tour.Add(null);
            }
        }

        // Constructs a tour from another tour
        public Tour(List<City> tour)
        {
            List<City> newList = new List<City>(tour.Count);

            tour.ForEach((item) =>
            {
                newList.Add(new City(item.getX(),item.getY()) );
            });
            this.tour = newList;
        }

        // Returns tour information
        public List<City> getTour()
        {
            return tour;
        }

        // Creates a random individual
        public void generateIndividual()
        {
            // Loop through all our destination cities and add them to our tour
            for (int cityIndex = 0; cityIndex < TourManager.numberOfCities(); cityIndex++)
            {
                setCity(cityIndex, TourManager.getCity(cityIndex));
            }
            // Randomly reorder the tour
            tour.Shuffle();
            
        }
        
      

        // Gets a city from the tour
        public City getCity(int tourPosition)
        {
            return (City)tour.ElementAt(tourPosition);
        }

        // Sets a city in a certain position within a tour
        public void setCity(int tourPosition, City city)
        {
            tour.RemoveAt(tourPosition);
            tour.Insert(tourPosition, city);
            // If the tours been altered we need to reset the fitness and distance
            distance = 0;
        }

        // Gets the total distance of the tour
        public int getDistance()
        {
            if (distance == 0)
            {
                int tourDistance = 0;
                // Loop through our tour's cities
                for (int cityIndex = 0; cityIndex < tourSize(); cityIndex++)
                {
                    // Get city we're traveling from
                    City fromCity = getCity(cityIndex);
                    // City we're traveling to
                    City destinationCity;
                    // Check we're not on our tour's last city, if we are set our 
                    // tour's final destination city to our starting city
                    if (cityIndex + 1 < tourSize())
                    {
                        destinationCity = getCity(cityIndex + 1);
                    }
                    else
                    {
                        destinationCity = getCity(0);
                    }
                    // Get the distance between the two cities
                    tourDistance +=(int)fromCity.distanceTo(destinationCity);
                }
                distance = tourDistance;
            }
            return distance;
        }

        // Get number of cities on our tour
        public int tourSize()
        {
            return tour.Count();
        }

       
    public override string ToString()
        {
            String geneString = "|";
            for (int i = 0; i < tourSize(); i++)
            {
                geneString += getCity(i) + "|";
            }
            return geneString;
        }
    }
}
