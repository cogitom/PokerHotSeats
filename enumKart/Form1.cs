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
        List <Player> players;
        public Form1(List <Player> inPlayers)
        {
            InitializeComponent();

            random = new Random();
            cardPile = new CardsDeck();
            players =new List<Player>(inPlayers);

            if (players.Count>=2)
            {
                player1CardsTextBox.Visible = true;
                players[0].cardTextBox = player1CardsTextBox;
                player2CardsTextBox.Visible = true;
                players[1].cardTextBox = player2CardsTextBox;
            }
            if (players.Count >= 3)
            {
                player3CardsTextBox.Visible = true;
                players[2].cardTextBox = player3CardsTextBox;
            }

            if (players.Count >= 4)
            {
                player4TextBox.Visible = true;
                players[3].cardTextBox = player3CardsTextBox;
            }

            newDeal();

            foreach ( Player player in players)
            {
                player.cardTextBox.AppendText(player.getAllCardsInHand());
            }
        }
        private void newDeal()
        {
            cardPile.Shuffle(10);
            int position = 0;
            int playerPosition;
            for (int i = 0; i < 15; i++)
            {
                playerPosition = position % players.Count;
                players[playerPosition].CollectCard(cardPile.PutCard());
                position++;
            }
        }
        
        private void newDealButton_Click(object sender, EventArgs e)
        {
            cardPile.Shuffle(10);
            int position=0;
            int playerPosition;
            for (int i = 0; i < 5; i++)
            {
                playerPosition = position % players.Count;
                players[playerPosition].CollectCard(cardPile.PutCard());
                position++;
            }
                        
        }
        
     
    }
}
