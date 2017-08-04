using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumKart
{
    public class CardsDeck :IQueueCards
    {
        private Queue <Card> cards;
        
        public CardsDeck()
        {
            cards = new Queue<Card>();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 2; j <= 14; j++)
                {
                    cards.Enqueue(new Card((Suits)i, (Values)j));
                }
            }
        }

        public CardsDeck(Queue<Card> cardStack)
        {
            cards = new Queue<Card>(cardStack);
        }

        public Card PeekCard
        {
            get
            {
                return cards.Peek();
            }
         
        }
        
        public int NumberOfCards
        {
            get
            {
                return cards.Count;
            }
        }

        public void CollectCard(Card card)
        {
            cards.Enqueue(card);
        }

        public Card PutCard()
        {
            return cards.Dequeue();
        }

        public void Shuffle(int numberOfShuffles)
        {
            Random random = new Random();
            List<Card> newCardDeck = cards.ToList();

            for (int c = 0; c < numberOfShuffles; c++)
            {
                for (int i = 0; i <= cards.Count - 1; i++)
                {
                    int r = random.Next(i, cards.Count - 1);

                    Card buffer = newCardDeck[r];

                    newCardDeck[r] = newCardDeck[i];
                    newCardDeck[i] = buffer;

                }

                int last_random = random.Next(0, cards.Count - 1);
                Card lastCard = newCardDeck.Last();

                newCardDeck[cards.Count - 1] = newCardDeck[last_random];
                newCardDeck[last_random] = lastCard;

                cards.Clear();


                foreach (Card card in newCardDeck)
                {
                    cards.Enqueue(card);
                }
                
            }
            
          

        }
   

    }
}
