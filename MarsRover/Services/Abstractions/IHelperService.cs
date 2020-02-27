using MarsRover.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Services.Abstractions
{
    public interface IHelperService
    {
        Task<Dictionary<string,int>> InsertDirections();

        Task<Dictionary<string, int>> InsertMoves();
    }
}
