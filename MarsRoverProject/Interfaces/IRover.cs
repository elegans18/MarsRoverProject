using MarsRoverProject.Enums;

namespace MarsRoverProject.Interfaces
{
    public interface IRover
    {
        public int LocationX { get; set; }
        public int LocationY { get; set; }
        public Direction CurrentDirection { get; set; }

        public void TurnRight();
        public void TurnLeft();
        public void MoveForward();
    }
}