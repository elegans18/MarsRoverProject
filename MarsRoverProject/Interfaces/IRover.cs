namespace MarsRoverProject.Interfaces
{
    public interface IRover
    {
        public int LocationX { get; set; }
        public int LocationY { get; set; }

        void TurnRight();
        void TurnLeft();
        void MoveForward();
    }
}