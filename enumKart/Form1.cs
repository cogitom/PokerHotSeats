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
        Random random;
        CardsDeck cardPile;
        List<CardOnStack> cardsOnStack;
        List <Player> players;
        Player Tom, Bob, Lily;

        public Form1()
        {
            InitializeComponent();

            random = new Random();
            cardPile = new CardsDeck();
            Tom = new Player("Tom",TomSurfaceCardTextBox, TomNumberOfCards);
            Bob = new Player("Bob", bobSurfaceCardTextBox, BobNumberOfCards);
            Lily = new Player("Lily", LilySurfaceCardTextBox, LilyNumberOfCards);

            players = new List<Player>() { Tom, Bob, Lily };

        }
        
        private void nextTourButton_Click(object sender, EventArgs e)
        {
            TomSurfaceCardTextBox.BackColor = DefaultBackColor;
            bobSurfaceCardTextBox.BackColor = DefaultBackColor;
            LilySurfaceCardTextBox.BackColor = DefaultBackColor;

            foreach (Player player in players)
            {
                player.UpdateTextBoxes();
            }

            Player winner = nextTour();

            winner.textBox.BackColor = Color.Green;

            for(int i =0; i<players.Count; i++)
            {
                if (players[i] == winner)
                {
                    foreach (Card card in cardsOnStack)
                    {
                        players[i].CollectCard(card);
                    }
                }

                if (players[i].NumberOfCards <= 0)
                {
                    players[i].UpdateTextBoxes();
                    players.Remove(players[i]);
                    
                }

            }
            if (players.Count==1)
            {
                MessageBox.Show("Zwycieza gracz:" + players[0]);
            }
            cardsOnStack.Clear();
        }

     

        private void newDealButton_Click(object sender, EventArgs e)
        {
            cardPile.Shuffle(10);
            int position=0;
            int playerPosition;

            while(cardPile.NumberOfCards != 0)
            {
                playerPosition = position % 3;
                players[playerPosition].CollectCard(cardPile.PutCard());
                position++;
            }            
        }

        private Player nextTour()
        {
            Player winner = players[0];

            cardsOnStack = new List<CardOnStack>();

            foreach (Player player in players)
            {
                if (player.NumberOfCards > 0)
                {
                    cardsOnStack.Add(new CardOnStack(player.PutCard(), player));
                }
            }



            cardsOnStack.Sort();

            return cardsOnStack.Last().Owner;
        }
       
       
    }
}
