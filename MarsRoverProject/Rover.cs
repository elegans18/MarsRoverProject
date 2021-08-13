using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverProject
{
    class Rover : IRover
    {
        private int LocationX
        {
            get
            {
                return locationX;
            }
            set
            {
                locationX = value;
            }
        }
        private int LocationY
        {
            get
            {
                return locationY;
            }
            set
            {
                locationY = value;
            }
        }

        public int locationX;
        public int locationY;

        public Direction currentDirection;

        public void TurnRight()
        {
            if (currentDirection == Direction.North)
            {
                currentDirection = Direction.East;
            }
            else if (currentDirection == Direction.South)
            {
                currentDirection = Direction.West;
            }
            else if (currentDirection == Direction.West)
            {
                currentDirection = Direction.North;
            }
            else if (currentDirection == Direction.East)
            {
                currentDirection = Direction.South;
            }
        }

        public void TurnLeft()
        {
            if (currentDirection == Direction.North)
            {
                currentDirection = Direction.East;
            }
            else if (currentDirection == Direction.South)
            {
                currentDirection = Direction.West;
            }
            else if (currentDirection == Direction.West)
            {
                currentDirection = Direction.North;
            }
            else if (currentDirection == Direction.East)
            {
                currentDirection = Direction.South;
            }
        }

        public void MoveForward()
        {

        }
    }
}
