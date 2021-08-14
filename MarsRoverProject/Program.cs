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

            MarsExploration marsExplore1 = new MarsExploration(rover1movementInput, rover1Input, fieldInput);
            marsExplore1.ExploreSurface();
            marsExplore1.PrintResults();

            MarsExploration marsExplore2 = new MarsExploration(rover2movementInput, rover2Input, fieldInput);
            marsExplore2.ExploreSurface();
            marsExplore2.PrintResults();
        }
    }
}
