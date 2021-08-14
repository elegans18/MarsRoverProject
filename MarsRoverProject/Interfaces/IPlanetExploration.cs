using MarsRoverProject.Enums;

namespace MarsRoverProject.Interfaces
{
    public interface IPlanetExploration
    {
        IRover Rover { get; set; }
        IField Field { get; set; }
        
        void ExploreSurface();
        void PrintResults();
    }
}