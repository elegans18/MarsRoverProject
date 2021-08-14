using System;
using MarsRoverProject.Enums;
using MarsRoverProject.Interfaces;

namespace MarsRoverProject.Business
{
    public class MarsExploration
    {
        private IRover rover;
        private IField field;

        private string MovementText;
        private string RoverInput;
        private string FieldInput;

        public IRover Rover
        {
            get
            {
                return rover;
            }
            set
            {
                rover = value;
            }
        }

        public IField Field
        {
            get
            {
                return field;
            }
            set
            {
                field = value;
            }
        }

        public MarsExploration(string fieldInput, string roverInput, string movementText)
        {
            MovementText = movementText;
            RoverInput = roverInput;
            FieldInput = fieldInput;
            Init();
        }

        private void Init()
        {
            field = CreateField();
            rover = CreateRover();
        }

        private IRover CreateRover()
        {
            string[] roverInpArray = RoverInput.Split(' ');

            IRover rover = new Rover();
            rover.LocationX = Convert.ToInt32(roverInpArray[0]);
            rover.LocationY = Convert.ToInt32(roverInpArray[1]);
            rover.CurrentDirection = GetDirection(roverInpArray[2]);
            field.CheckFieldLimits(rover);
            return rover;
        }

        private IField CreateField()
        {
            string[] fieldInputArray = FieldInput.Split(' ');

            int FieldLimitX = Convert.ToInt32(fieldInputArray[0]);
            int FieldLimitY = Convert.ToInt32(fieldInputArray[1]);

            IField _field = new Field(FieldLimitX, FieldLimitY);
            return _field;
        }

        private Directions GetDirection(string directionText)
        {
            if (directionText == "N")
                return Directions.North;
            else if (directionText == "S")
                return Directions.South;
            else if (directionText == "W")
                return Directions.West;
            else if (directionText == "E")
                return Directions.East;
            else
            {
                throw new Exception("Direction input is not valid.");
            }
        }

        public void ExploreSurface()
        {
            foreach (var moveType in MovementText)
            {
                if (moveType == 'L')
                {
                    rover.TurnLeft();
                }
                else if (moveType == 'R')
                {
                    rover.TurnRight();
                }
                else if (moveType == 'M')
                {
                    rover.MoveForward();
                }

                field.CheckFieldLimits(rover);
            }
        }

        public void PrintResults()
        {
            string finalLocation = rover.GetCurrentRoverInfo();
            Console.WriteLine(finalLocation);
        }
    }
}