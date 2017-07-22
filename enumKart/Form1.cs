using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enumKart
{
    public partial class Form1 : Form
    {
        Card randomCard;
        Random random;
        CardsDeck carddeck;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
            carddeck = new CardsDeck();
        }

        private void pickRandomCard_Click(object sender, EventArgs e)
        {
            int randomSuit = random.Next(3);
            int randomValue = random.Next(1, 13);

            randomCard = new Card((Suits)randomSuit, (Values)randomValue);
            MessageBox.Show(randomCard.Name);
        }

        private void showCardsDeck_Click(object sender, EventArgs e)
        {

            carddeck.ShowAllCard();
        }

        private void shuffleButton_Click(object sender, EventArgs e)
        {
            carddeck.Shuffle();
            Console.Write("Po potasowaniu!!!!1!!11!");
        }
    }
}
