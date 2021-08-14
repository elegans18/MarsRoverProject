using MarsRoverProject;
using MarsRoverProject.Interfaces;
using MarsRoverProject.Enums;
using MarsRoverProject.Business;
using System;
using Xunit;

namespace MarsRoverTest
{
    public class UnitTestMarsRover
    {
        [Theory]
        [InlineData(Directions.North, Directions.West)]
        [InlineData(Directions.South, Directions.East)]
        [InlineData(Directions.West, Directions.South)]
        [InlineData(Directions.East, Directions.North)]
        public void TestTurnLeft(Directions value1, Directions expected)
        {
            IRover rover = new Rover();
            IField field = new Field(5, 5);

            rover.LocationX = 0;
            rover.LocationY = 0;

            rover.CurrentDirection = value1;
            rover.TurnLeft();
            Assert.NotNull(rover.CurrentDirection);
            Assert.Equal(rover.CurrentDirection, expected);
            Assert.Equal(rover.LocationX, 0);
        }

        [Theory]
        [InlineData(Directions.North, Directions.East)]
        [InlineData(Directions.South, Directions.West)]
        [InlineData(Directions.West, Directions.North)]
        [InlineData(Directions.East, Directions.South)]
        public void TestTurnRight(Directions value1, Directions expected)
        {
            IRover rover = new Rover();
            IField field = new Field(5, 5);
            rover.LocationX = 0;
            rover.LocationY = 0;

            rover.CurrentDirection = value1;
            rover.TurnRight();
            Assert.NotNull(rover.CurrentDirection);
            Assert.Equal(rover.CurrentDirection, expected);
            Assert.Equal(rover.LocationX, 0);
        }

        [Theory]
        [InlineData(Directions.North, 5, 5, 5, 5)]
        [InlineData(Directions.South, 0, 0, 0, 0)]
        [InlineData(Directions.North, 0, 0, 0, 1)]
        [InlineData(Directions.East, 0, 0, 1, 0)]
        [InlineData(Directions.West, 0, 0, 0, 0)]
        public void TestMoveForward(Directions value1, int value2, int value3, int Expected1, int Expected2)
        {
            IRover rover = new Rover();
            IField field = new Field(5, 5);
            rover.LocationX = value2;
            rover.LocationY = value3;

            rover.CurrentDirection = value1;
            rover.MoveForward();
            field.CheckFieldLimits(rover);
            Assert.NotNull(rover.CurrentDirection);
            Assert.Equal(rover.LocationX, Expected1);
            Assert.Equal(rover.LocationY, Expected2);
        }

        [Theory]
        [InlineData("5 5", "1 2 N", "LMLMLMLMM", "1 3 N")]
        [InlineData("5 5", "3 3 E", "MMRMMRMRRM", "5 1 E")]
        public void TestRover(string value1, string value2, string value3, string expected)
        {
            MarsExploration marsExplore = new MarsExploration(value1, value2, value3);
            marsExplore.ExploreSurface();
            marsExplore.PrintResults();
            var result = marsExplore.Rover.GetCurrentRoverInfo();
            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData("5 5", "6 4 W", "LMLMLMLMM", 5,4)]
        [InlineData("5 5", "5 6 S", "MMRMMRMRRM", 5,5)]
        public void TestCreateRover(string value1, string value2, string value3, int expected1, int expected2)
        {
            MarsExploration marsExplore = new MarsExploration(value1, value2, value3);

            Assert.Equal(marsExplore.Rover.LocationX, expected1);
            Assert.Equal(marsExplore.Rover.LocationY, expected2);
        }

    }
}
