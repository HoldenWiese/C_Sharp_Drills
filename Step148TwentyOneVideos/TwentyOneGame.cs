﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Step148TwentyOneVideos
{
    class TwentyOneGame: Game, IWalkAway
    {
        public override void Play()
        {
            throw new NotImplementedException();
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players");
            base.ListPlayers();
        }
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
