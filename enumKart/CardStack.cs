using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumKart
{
    public class CardOnStack : Card, IComparable<Card>
    {
        private Player owner;

        public Player Owner
        {
            get
            {
                return owner;
            }
        }

        public CardOnStack(Card card, Player inOwner) : base(card.Suit, card.Value)
        {
            owner = inOwner;
        }

        public int CompareTo(Card otherCard)
        {
            if (Value + (int)Suit > otherCard.Value + (int)otherCard.Suit)
                return 1;
            else if (Value + (int)Suit < otherCard.Value + (int)otherCard.Suit)
                return -1;
            else
                return 0;
        }
    }
}
