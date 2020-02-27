using MarsRover.Models;
using MarsRover.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Threading.Tasks;
using static MarsRover.Models.Enums;

namespace MarsRover.Services.Concrete
{
    /// <summary>
    /// Rover controls his movements according to the incoming text. 
    /// </summary>
    public class RoverManager : IRoverService
    {
        private static Position position = new Position();

        /// <summary>
        /// Initilaze Method
        /// </summary>
        /// <returns></returns>
        public async Task Initilaze()
        {
            Console.WriteLine(Constants.UserFriendlyMessages.ENTER_MOTION_ENTRIES);
            string entries = Console.ReadLine().Trim();

            foreach (var item in entries)
            {
                switch (item)
                {
                    case 'M':
                        await Move();
                        break;
                    case 'L':
                        await Left();
                        break;
                    case 'R':
                        await Right();
                        break;
                    default:
                        Console.WriteLine($"Invalid Character {item}");
                        break;
                }
            }
            Console.WriteLine(position.X + " " + position.Y + " " + position.Directory);
        }

        /// <summary>
        /// Move in the direction.
        /// </summary>
        /// <returns></returns>
        protected async Task Move()
        {
            switch (position.Directory)
            {
                case Direction.N:
                    position.Y = position.Y + 1;
                    break;
                case Direction.S:
                    position.Y = position.Y - 1;
                    break;
                case Direction.E:
                    position.X = position.X + 1;
                    break;
                case Direction.W:
                    position.X = position.X - 1;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Turn left 90 degrees.
        /// </summary>
        /// <returns></returns>
        protected async Task Left()
        {
            switch (position.Directory)
            {
                case Direction.N:
                    position.Directory = Direction.W;
                    break;
                case Direction.S:
                    position.Directory = Direction.E;
                    break;
                case Direction.E:
                    position.Directory = Direction.N;
                    break;
                case Direction.W:
                    position.Directory = Direction.S;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Turn right 90 degrees.
        /// </summary>
        /// <returns></returns>
        protected async Task Right()
        {
            switch (position.Directory)
            {
                case Direction.N:
                    position.Directory = Direction.E;
                    break;
                case Direction.S:
                    position.Directory = Direction.W;
                    break;
                case Direction.E:
                    position.Directory = Direction.S;
                    break;
                case Direction.W:
                    position.Directory = Direction.N;
                    break;
                default:
                    break;
            }
        }
    }
}
