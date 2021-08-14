using MarsRoverProject.Enums;

namespace MarsRoverProject.Interfaces
{
    public interface IRover
    {
        int LocationX { get; set; }
        int LocationY { get; set; }
        Directions CurrentDirection { get; set; }

        void TurnRight();
        void TurnLeft();
        void MoveForward();
        string GetCurrentRoverInfo();
    }
}