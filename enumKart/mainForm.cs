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
    public partial class mainForm : Form
    {
        List<Player>players;
        public mainForm()
        {
            InitializeComponent();
            addNewPlayerButton.Visible = false;
            players = new List<Player>();
        }

        private void addNewPlayerButton_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Text != confirmPasswordTextBox.Text)
            {
                MessageBox.Show("HASŁA NIE SĄ ZGODNE !!!");
            }
            else if (players.Count+1 > 4)
            {
                MessageBox.Show("Ilosc graczy nie może przekroczyć 4!!!");                       
            }
            else if (!isNameUnique(nameTextBox.Text))
            {
                MessageBox.Show("Nazwa uzytkownika nie jest unikalna!! ");
            }
            else
            {  
               players.Add(new Player(nameTextBox.Text, passwordTextBox.Text));
               playersListText.Text += "\r\n Gracz nr: " + players.Count + "      Nazwa gracza:" + players.Last().Name;                                  
            }          
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            addNewPlayerButton.Visible = true;
        }

        private bool isNameUnique(string inName)
        {
            foreach (Player player in players)
            {
                if (inName == player.Name)
                {
                    return false;
                }                
                else
                {
                    ;
                }                
            }          
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Game = new Form1(players);
            this.Hide();
            Game.Show();
        }
    }
}
