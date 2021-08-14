using MarsRoverProject.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverProject.Business
{
    public class Direction
    {
        public string GetShortDirect(Directions direction)
        {
            if (direction == Directions.North)
                return "N";
            else if (direction == Directions.South)
                return "S";
            else if (direction == Directions.West)
                return "W";
            else if (direction == Directions.East)
                return "E";
            else
                throw new Exception("Invalid direction.");
        }
    }
}
