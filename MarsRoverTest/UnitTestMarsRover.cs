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
        [Fact]
        public void TestTurnLeft()
        {
            IRover rover = new Rover();
            IField field = new Field(5, 5);

            rover.LocationX = 0;
            rover.LocationY = 0;

            rover.CurrentDirection = Direction.North;
            rover.TurnLeft();
            Assert.NotNull(rover.CurrentDirection);
            Assert.Equal(rover.CurrentDirection, Direction.West);
            Assert.Equal(rover.LocationX, 0);

            rover.CurrentDirection = Direction.South;
            rover.TurnLeft();
            Assert.NotNull(rover.CurrentDirection);
            Assert.Equal(rover.CurrentDirection, Direction.East);
            Assert.Equal(rover.LocationX, 0);

            rover.CurrentDirection = Direction.West;
            rover.TurnLeft();
            Assert.NotNull(rover.CurrentDirection);
            Assert.Equal(rover.CurrentDirection, Direction.South);
            Assert.Equal(rover.LocationX, 0);

            rover.CurrentDirection = Direction.East;
            rover.TurnLeft();
            Assert.NotNull(rover.CurrentDirection);
            Assert.Equal(rover.CurrentDirection, Direction.North);
            Assert.Equal(rover.LocationX, 0);
        }

        [Fact]
        public void TestTurnRight()
        {
            IRover rover = new Rover();
            IField field = new Field(5, 5);
            rover.LocationX = 0;
            rover.LocationY = 0;

            rover.CurrentDirection = Direction.North;
            rover.TurnRight();
            Assert.NotNull(rover.CurrentDirection);
            Assert.Equal(rover.CurrentDirection, Direction.East);
            Assert.Equal(rover.LocationX, 0);

            rover.CurrentDirection = Direction.South;
            rover.TurnRight();
            Assert.NotNull(rover.CurrentDirection);
            Assert.Equal(rover.CurrentDirection, Direction.West);
            Assert.Equal(rover.LocationX, 0);

            rover.CurrentDirection = Direction.West;
            rover.TurnRight();
            Assert.NotNull(rover.CurrentDirection);
            Assert.Equal(rover.CurrentDirection, Direction.North);
            Assert.Equal(rover.LocationX, 0);

            rover.CurrentDirection = Direction.East;
            rover.TurnRight();
            Assert.NotNull(rover.CurrentDirection);
            Assert.Equal(rover.CurrentDirection, DirectioSouthth);
            Assert.Equal(rover.LocationX, 0);
        }
    }
}
