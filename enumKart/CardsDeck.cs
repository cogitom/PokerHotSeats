using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumKart
{
    public class CardsDeck
    {
        public List<Card> cards;

        public CardsDeck()
        {
            cards = new List <Card>();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j <= 13; j++)
                {
                    cards.Add(new Card((Suits)i, (Values)j));
                }
            }
        }

        public void ShowAllCard()
        {
            foreach (Card cc in cards)
            {
                Console.Write(cc.Name + "\r\n");
            }
        }

        public void Shuffle()
        {
            Random random = new Random();
            List <Card> newCardDeck = new List<Card>();

            for (int i = 0; i <= cards.Count-1; i++)
            {
              int r = random.Next(i, cards.Count-1);
               
                Card buffer = cards[r];

                cards[r] = cards[i];
                cards[i] = buffer;

            }

             int last_random = random.Next(0, cards.Count - 1);
             Card lastCard = cards.Last();

            cards[cards.Count - 1] = cards[last_random];
            cards[last_random] = lastCard;
           

        }


    }
}
