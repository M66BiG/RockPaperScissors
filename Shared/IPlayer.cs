using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Shared
{
    public interface IPlayer
    {
        string Name { get; }
        int Points { get; }
    }
}
