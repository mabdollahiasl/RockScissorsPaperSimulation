using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockScissorsPaperSimulation
{
    public class PlayerOnRock : IPlayer
    {
        public PlayStatus LastPlay { get; set; }


        public PlayStatus Play()
        {
            LastPlay = PlayStatus.Rock;
            return LastPlay;
        }
    }
}
