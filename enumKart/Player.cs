using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enumKart
{
    public class Player :IQueueCards
    {
        private Queue <Card> handCard;
        private string password;

        public TextBox cardTextBox
        {
            get;
            set;
        }

        public string Name
        {
            get;                          
            set;                              
        }
       
        public int NumberOfCards
        {
            get { return handCard.Count; }                              
        }

       public Card PeekCard
        {
            get{ return handCard.Peek(); }           
        } 
        
        public Player(string inName, string inPassword)
        {
            Name = inName;
            password = inPassword;
            handCard = new Queue<Card>();
        }

        public void CollectCard(Card card)
        {
            handCard.Enqueue(card);
        }

        public Card PutCard()
        {
            return handCard.Dequeue();
        }

        public string getAllCardsInHand()
        {
            string cards = "";

            foreach (Card card in handCard)
            {
                cards +=card.Name + ",";
            }

           return cards;
        }

       
        
         
    }
}
