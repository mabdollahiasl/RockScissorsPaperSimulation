using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockScissorsPaperSimulation
{
    public interface IPlayer
    {
        PlayStatus LastPlay { get; }   
        PlayStatus Play();
    }
    public enum PlayStatus
    {
        None=0,
        Paper=1,
        Scissor=2,
        Rock=4,
        PaperScissor=3,
        PaperRock=5,
        ScissorRock=6,
    }
}
