using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRoverProject.Enums;
using MarsRoverProject.Interfaces;

namespace MarsRoverProject.Business
{
    public class Rover : IRover
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

        public Directions CurrentDirection
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

        private Directions currentDirection;

        public Rover()
        {

        }

        public void TurnRight()
        {
            if (currentDirection == Directions.North)
            {
                currentDirection = Directions.East;
            }
            else if (currentDirection == Directions.South)
            {
                currentDirection = Directions.West;
            }
            else if (currentDirection == Directions.West)
            {
                currentDirection = Directions.North;
            }
            else if (currentDirection == Directions.East)
            {
                currentDirection = Directions.South;
            }
            else
            {
                throw new Exception("Current direction is invalid.");
            }
        }

        public void TurnLeft()
        {
            if (currentDirection == Directions.North)
            {
                currentDirection = Directions.West;
            }
            else if (currentDirection == Directions.South)
            {
                currentDirection = Directions.East;
            }
            else if (currentDirection == Directions.West)
            {
                currentDirection = Directions.South;
            }
            else if (currentDirection == Directions.East)
            {
                currentDirection = Directions.North;
            }
            else
            {
                throw new Exception("Current direction is invalid.");
            }
        }

        public void MoveForward()
        {
            if (currentDirection == Directions.North)
            {
                locationY++;
            }
            else if (currentDirection == Directions.South)
            {
                locationY--;
            }
            else if (currentDirection == Directions.West)
            {
                locationX--;
            }
            else if (currentDirection == Directions.East)
            {
                locationX++;
            }
            else
            {
                throw new Exception("Current direction is invalid.");
            }
        }

        public string GetCurrentRoverInfo()
        {
            Direction direction = new Direction();
            string roverDirection = direction.GetShortDirect(CurrentDirection);
            string result = $"{LocationX} {LocationY} {roverDirection}";
            return result;
        }
    }
}
