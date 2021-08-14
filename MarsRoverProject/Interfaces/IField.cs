namespace MarsRoverProject.Interfaces
{
    public interface IField
    {
        int FieldLimitX { get; set; }
        int FieldLimitY { get; set; }

        void CheckFieldLimits(IRover Rover);

        void FieldLimitCrossing();
    }
}