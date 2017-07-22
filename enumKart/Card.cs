using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumKart
{
    public class Card
    {
        public Suits Suit;
        
        public Values Value;
       

        public string Name
        {
            get
            {
                return Value.ToString() + " of " + Suit.ToString();
            }
               
        }

        public Card(Suits inSuit, Values inValue)
        {
            Suit = inSuit;
            Value = inValue;
        }
    }
}
