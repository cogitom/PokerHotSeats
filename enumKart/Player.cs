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
        
        public TextBox textBox
        {
            get;
        }
        public TextBox numberOfCardsText
        
        {
            get;
        }

        public string Name
        {
            get;
                           
            set;
                                       
        }
       
        public int NumberOfCards
        {
            get
            {
                return handCard.Count;
            }
        }

       public Card PeekCard
        {
            get
            {
                return handCard.Peek();
            }

        } 
        
        public Player(string inName,TextBox inTextBox, TextBox numberOfCardsText)
        {
            Name = inName;
            textBox = inTextBox;
            this.numberOfCardsText = numberOfCardsText;
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

        public void UpdateTextBoxes()
        {
            if (NumberOfCards != 0)
            {
                textBox.Text = PeekCard.Name;
                numberOfCardsText.Text = NumberOfCards.ToString();
            }
            else
            {
                textBox.Text = Name+ " PRZEGRYWA !!!  ";
                numberOfCardsText.Text = "BRAK";
                textBox.BackColor = System.Drawing.Color.Red;
            }
        }
    }
}
