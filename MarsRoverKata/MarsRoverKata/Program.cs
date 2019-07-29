using System;
using RoverEngine;
namespace MarsRoverKata
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Plateau land = new Plateau(5, 5);
            Rover rvr1 = new Rover(1, 2, 'N', land.Dimensions());
            rvr1.MoveRover("LMLMLMLMM");
            Rover rvr2 = new Rover(3, 3, 'E', land.Dimensions());
            rvr2.MoveRover("MMRMMRMRRM");
            rvr1.DisplayPosition();
            rvr2.DisplayPosition();
            
        }
    }
}
