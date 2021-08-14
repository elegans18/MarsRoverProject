using System;
using MarsRoverProject.Business;

namespace MarsRoverProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string fieldInput = "5 5";
            string rover1Input = "1 2 N";
            string rover1movementInput = "LMLMLMLMM";

            string rover2Input = "3 3 E";
            string rover2movementInput = "MMRMMRMRRM";

            try
            {
                MarsExploration marsExplore1 = new MarsExploration(fieldInput, rover1Input, rover1movementInput);
                marsExplore1.ExploreSurface();
                marsExplore1.PrintResults();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Rover 1 Explore : ", ex.Message);
                throw;
            }

            try
            {
                MarsExploration marsExplore2 = new MarsExploration(fieldInput, rover2Input, rover2movementInput);
                marsExplore2.ExploreSurface();
                marsExplore2.PrintResults();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Rover 2 Explore : ", ex.Message);
                throw;
            }
        }
    }
}
