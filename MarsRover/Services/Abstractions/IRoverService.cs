using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Services.Abstractions
{
    /// <summary>
    /// Service layer for Rover
    /// </summary>
    public interface IRoverService
    {
        Task Initilaze();
    }
}
