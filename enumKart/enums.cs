﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumKart
{
   public enum Suits
    {
          Spades=0, Clubs=1, Diamonds=2, Hearts=3
    }
    public enum Values
    {
        Ace=14, Two=2, Three=3, Four=4, Five=5, Six=6, Seven=7, Eight=8, Nine=9, Ten=10, Jack=11, Queen=12, King=13
    }

    public enum Figures
    {
        HighCards=1,Pair=2,TwoPairs=3,ThreeOfKinds=4,Full=5,FourOfKinds=6,Flush=7, RoyalFlush=8
    }
    
    
}
