using MarsRover.Models;
using MarsRover.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Services.Concrete
{
    public class HelperManager : IHelperService
    {
        public async Task<Dictionary<string, int>> InsertDirections()
        {
            return new Dictionary<string, int>()
            {
                {"N",0 },
                {"S",1 },
                {"E",2 },
                {"W",3 }
            };
        }

        public async Task<Dictionary<string, int>> InsertMoves()
        {
            return new Dictionary<string, int>()
            {
                {"L",0 },
                {"R",1 },
                {"M",2 }
            };
        }
    }
}
