using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulatedAnnealing
{
    class Program
    {
        public static double acceptanceProbability(int energy, int newEnergy, double temperature)
        {
            // If the new solution is better, accept it
            if (newEnergy < energy)
            {
                return 1.0;
            }
            // If the new solution is worse, calculate an acceptance probability
     
            return Math.Exp((energy - newEnergy) / temperature);
        }

        public static void Main(String[] args)
        {
            // Create and add our cities
            City city = new City(60, 200);
            TourManager.addCity(city);
            City city2 = new City(180, 200);
            TourManager.addCity(city2);
            City city3 = new City(80, 180);
            TourManager.addCity(city3);
            City city4 = new City(140, 180);
            TourManager.addCity(city4);
            City city5 = new City(20, 160);
            TourManager.addCity(city5);
            

            /*
             *  x=[82 91 12 92 63 9 28 55 96 97 15 98 96 49 80 12 80 55];
    
                 y=[14 42 92 80 96 66 3 85 94 68 76 75 39 66 17 78 80 45];
             * */
            // Set initial temp
            double temp = 10000;

            // Cooling rate
            double coolingRate = 0.003;

            // Initialize intial solution
            Tour currentSolution = new Tour();
            currentSolution.generateIndividual();

            Console.WriteLine("Initial solution distance: " + currentSolution.getDistance());

            // Set as current best
            Tour best = new Tour(currentSolution.getTour());
            Random rnd = new Random();
            // Loop until system has cooled
            while (temp > 1)
            {
                // Create new neighbour tour
                Tour newSolution = new Tour(currentSolution.getTour());
               
                // Get a random positions in the tour
                double random1 = rnd.NextDouble();
                int tourPos1 = (int)(newSolution.tourSize() * random1);
                double random2 = rnd.NextDouble();
                int tourPos2 = (int)(newSolution.tourSize() * random2);
                

                // Get the cities at selected positions in the tour
                City citySwap1 = newSolution.getCity(tourPos1);
                City citySwap2 = newSolution.getCity(tourPos2);

                // Swap them
                newSolution.setCity(tourPos2, citySwap1);
                newSolution.setCity(tourPos1, citySwap2);
               
                // Get energy of solutions
                int currentEnergy = currentSolution.getDistance();
                int neighbourEnergy = newSolution.getDistance();
                
                // Decide if we should accept the neighbour
                if (newSolution.getDistance() < currentSolution.getDistance())
                {
                    currentSolution = new Tour(newSolution.getTour());
                }
                else 
                {
                    double random3 = rnd.NextDouble();
                    if (acceptanceProbability(currentEnergy, neighbourEnergy, temp) > random3)
                        currentSolution = new Tour(newSolution.getTour());
                }

                // Keep track of the best solution found
                if (currentSolution.getDistance() < best.getDistance())
                {
                    best = new Tour(currentSolution.getTour());
                }

                // Cool system
                temp *= 1 - coolingRate;
            }

           Console.WriteLine("Final solution distance: " + best.getDistance());
           Console.WriteLine("Tour: " + best);
        }
    }
}
