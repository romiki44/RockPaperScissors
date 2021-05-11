using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockPaperScissors.Helpers
{
    public class Hand
    {
        public OptionRPS Selection { get; set; }
        public OptionRPS WinsAgainst { get; set; }
        public OptionRPS LosesAgainst { get; set; }
        public string Image { get; set; }

        public GamerStatus PlayAgainst(Hand opponentHand)
        {
            if (Selection == opponentHand.Selection)
                return GamerStatus.Draw;
            
            if (LosesAgainst == opponentHand.Selection)
                return GamerStatus.Loss;

            return GamerStatus.Victory;
        }
    }
}
