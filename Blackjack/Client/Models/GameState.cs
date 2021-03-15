using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blackjack.Client.Models
{
    public enum GameState
    {
        NotStarted,
        Betting,
        Dealing,
        InProgress,
        Insurance,
        Payout,
        Shuffling,
        EscortedOut
    }
}