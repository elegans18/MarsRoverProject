namespace MarsRoverProject.Interfaces
{
    public interface IField
    {
        public int FieldLimitX { get; set; }
        public int FieldLimitY { get; set; }

        public void CheckFieldLimits(IRover Rover);
    }
}