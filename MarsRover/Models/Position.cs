using System;
using System.Collections.Generic;
using System.Text;
using static MarsRover.Models.Enums;

namespace MarsRover.Models
{
    public class Position
    {
        public Position()
        {
            X = 1;
            Y = 2;
            Directory = Direction.N;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public Direction Directory { get; set; }
    }
}
