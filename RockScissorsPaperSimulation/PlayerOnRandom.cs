using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockScissorsPaperSimulation
{
    public class PlayerOnRandom : IPlayer
    {
        Random _random;
        PlayStatus[] _indexToPlaystatus;

        public PlayerOnRandom()
        {
            _random = new Random();
            _indexToPlaystatus = new PlayStatus[] { PlayStatus.Paper, PlayStatus.Rock, PlayStatus.Scissor };
        }

        public PlayStatus LastPlay { get; set; }

      

        public PlayStatus Play()
        {
            int randomPlayIndex = _random.Next(0, 3);
 
            LastPlay = _indexToPlaystatus[randomPlayIndex];
            return LastPlay;
        }
    }
}
