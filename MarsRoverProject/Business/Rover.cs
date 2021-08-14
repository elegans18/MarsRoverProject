using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRoverProject.Enums;
using MarsRoverProject.Interfaces;

namespace MarsRoverProject.Business
{
    class Rover : IRover
    {
        public int LocationX
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
        public int LocationY
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

        public Direction CurrentDirection
        {
            get
            {
                return currentDirection;
            }
            set
            {
                currentDirection = value;
            }
        }

        private int locationX;
        private int locationY;

        private Direction currentDirection;

        public Rover()
        {

        }

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
            else
            {
                //Exception
            }
        }

        public void TurnLeft()
        {
            if (currentDirection == Direction.North)
            {
                currentDirection = Direction.West;
            }
            else if (currentDirection == Direction.South)
            {
                currentDirection = Direction.East;
            }
            else if (currentDirection == Direction.West)
            {
                currentDirection = Direction.South;
            }
            else if (currentDirection == Direction.East)
            {
                currentDirection = Direction.North;
            }
            else
            {
                //Exception
            }
        }

        public void MoveForward()
        {
            if (currentDirection == Direction.North)
            {
                locationY++;
            }
            else if (currentDirection == Direction.South)
            {
                locationY--;
            }
            else if (currentDirection == Direction.West)
            {
                locationX--;
            }
            else if (currentDirection == Direction.East)
            {
                locationX++;
            }
            else
            {
                //Exception
            }
        }
    }
}
