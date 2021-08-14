using System;
using MarsRoverProject.Enums;
using MarsRoverProject.Interfaces;

namespace MarsRoverProject.Business
{
    public class MarsExploration
    {
        private IRover Rover;
        private IField Field;

        private string MovementText;
        private string RoverInput;
        private string FieldInput;

        public MarsExploration(string movementText, string roverInput, string fieldInput)
        {
            MovementText = movementText;
            RoverInput = roverInput;
            FieldInput = fieldInput;
            InitData();
        }

        private void InitData()
        {
            Rover = CreateRover();
            Field = CreateField();
        }

        private IRover CreateRover()
        {
            string[] roverInpArray = RoverInput.Split(' ');

            IRover rover = new Rover();
            rover.LocationX = Convert.ToInt32(roverInpArray[0]);
            rover.LocationY = Convert.ToInt32(roverInpArray[1]);
            rover.CurrentDirection = GetDirection(roverInpArray[2]);
            return rover;
        }

        private IField CreateField()
        {
            string[] fieldInputArray = FieldInput.Split(' ');

            int FieldLimitX = Convert.ToInt32(fieldInputArray[0]);
            int FieldLimitY = Convert.ToInt32(fieldInputArray[1]);

            IField field = new Field(FieldLimitX, FieldLimitY);
            return field;
        }

        private Direction GetDirection(string directionText)
        {
            if (directionText == "N")
                return Direction.North;
            else if (directionText == "S")
                return Direction.South;
            else if (directionText == "W")
                return Direction.West;
            else if (directionText == "E")
                return Direction.East;
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
                    Rover.TurnLeft();
                }
                else if (moveType == 'R')
                {
                    Rover.TurnRight();
                }
                else if (moveType == 'M')
                {
                    Rover.MoveForward();
                }

                Field.CheckFieldLimits(Rover);
            }
        }

        public void PrintResults()
        {
            string finalLocation = Rover.GetCurrentRoverInfo();
            Console.WriteLine(finalLocation);
        }
    }
}