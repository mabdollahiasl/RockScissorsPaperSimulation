using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockScissorsPaperSimulation
{
    public class RockScissorsPaperGame
    {
        
        private ILogger _logger;

        public IPlayer PlayerA { get; }
        public IPlayer PlayerB { get; }

        public RockScissorsPaperGame(IPlayer playerA, IPlayer playerB, ILogger logger)
        {
            PlayerA = playerA;
            PlayerB = playerB;
            _logger = logger;
        }
        public IPlayer LastWinner
        {
            get
            {
                PlayStatus lastPlay = (PlayerA.LastPlay | PlayerB.LastPlay);
                switch (lastPlay)
                {
                    case PlayStatus.PaperRock:
                        return PlayerA.LastPlay == PlayStatus.Paper ? PlayerA : PlayerB;
                    case PlayStatus.PaperScissor:
                        return PlayerA.LastPlay == PlayStatus.Scissor ? PlayerA : PlayerB;
                    case PlayStatus.ScissorRock:
                        return PlayerA.LastPlay == PlayStatus.Rock ? PlayerA : PlayerB;
                    default:
                        return null;
                }
            }
        }

        /// <summary>
        /// play one round and return the winner
        /// </summary>
        /// <returns></returns>
        public IPlayer PlayOneRound()
        {
            PlayerA.Play();
            PlayerB.Play();
            return LastWinner;
        }
       
        public void Simulate(int numberOfSimulation)
        {
            int aWonCount = 0;
            int bWonCount=0;

            for (int i = 0; i < numberOfSimulation; i++)
            {
 
                var winner = this.PlayOneRound();

                string winnerName = "no one";
                if (winner == PlayerA)
                {
                    aWonCount += 1;
                    winnerName = "A";
                }
                else if (winner == PlayerB)
                {
                    bWonCount += 1;
                    winnerName = "B";
                }
                _logger.Log($"A:{PlayerA.LastPlay}\tB:{PlayerB.LastPlay}, {winnerName} won!");
            }
            _logger.Log($"Summery: A won in {aWonCount} and B won in {bWonCount}");
        }
    }
}
