using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulatedAnnealing
{
    class City
    {
        int x;
        int y;

        // Constructs a randomly placed city
        public City()
        {
            Random r1 = new Random();
            Random r2 = new Random();
            this.x = (int)(r1.NextDouble() * 200);
            this.y = (int)(r2.NextDouble() * 200);
        }

        // Constructs a city at chosen x, y location
        public City(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // Gets city's x coordinate
        public int getX()
        {
            return this.x;
        }

        // Gets city's y coordinate
        public int getY()
        {
            return this.y;
        }

        // Gets the distance to given city
        public double distanceTo(City city)
        {
            double xDistance = Math.Abs(getX() - city.getX());
            double yDistance = Math.Abs(getY() - city.getY());
            double distance = Math.Sqrt((xDistance * xDistance) + (yDistance * yDistance));

            return distance;
        }

      
        public override string ToString()
        {
            return getX() + ", " + getY();
        }
    }
}
