using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class FormBlackJack : Form
    {
        private Deck deck;
        public FormBlackJack()
        {
            InitializeComponent();
            deck = new Deck();
        }

        private void buttonStick_Click(object sender, EventArgs e)
        {
            // Pass move to Dealer

        }

        private void pictureBoxDeck_Click(object sender, EventArgs e)
        {
            // Take card from the Deck by Player

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            // Start the Game
            if (textBoxBet.Text.Length != 0) 
            {
                try
                { 
                    deck = new Deck();
                    // Draw a random card from deck
                    Card firstCard = deck.DrawCard();

                    // Get the image from Resources and display it
                    string resourceName = firstCard.ImagePath;  // This will be like "4_of_hearts"
                    pictureBoxPlayerCard1.Image = Properties.Resources.ResourceManager.GetObject(firstCard.ImagePath) as System.Drawing.Bitmap;

                    Card secondCard = deck.DrawCard();
                    pictureBoxPlayerCard2.Image = Properties.Resources.ResourceManager.GetObject(secondCard.ImagePath) as System.Drawing.Bitmap;
                    // Optionally display card info (for testing)
                    //MessageBox.Show($"Drew {drawnCard.CardRank} of {drawnCard.CardSuit}");
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("No cards left in deck!");
                }
            }
        }
    }
}
