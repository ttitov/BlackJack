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
        private int totalPointsPlayer;
        private int totalPointsDealer;
        private double betAmount;
        private bool isPlayerWon;
        private bool isBlackJack;
        private bool isDraw = false;
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
            //betAmount = int.Parse(textBoxBet.Text);
            // Start the Game


            if (double.TryParse(textBoxBet.Text, out betAmount))
                {
                betAmount = int.Parse(textBoxBet.Text);
                try
                {
                    deck = new Deck();
                    // Draw a random card from deck
                    Card firstCard = deck.DrawCard();

                    // Get the image of a card from Resources and display it
                    string resourceName = firstCard.ImagePath;  // This will be like "4_of_hearts"
                    pictureBoxPlayerCard1.Image = Properties.Resources.ResourceManager.GetObject(firstCard.ImagePath) as System.Drawing.Bitmap;

                    Card secondCard = deck.DrawCard();
                    pictureBoxPlayerCard2.Image = Properties.Resources.ResourceManager.GetObject(secondCard.ImagePath) as System.Drawing.Bitmap;

                    // Calculate points and set them to Total label of Player
                    totalPointsPlayer = calculatePoints(firstCard) + calculatePoints(secondCard);
                    if (totalPointsPlayer == 11 && (firstCard.CardRank == Card.Rank.Ace || secondCard.CardRank == Card.Rank.Ace)) {
                        totalPointsPlayer += 10; // Add 10 if one of the card is Ace and total is 11 
                    }
                    labelTotalPlayerPoints.Text = "Total Points: " + totalPointsPlayer.ToString(); 

                    // Put one card for Dealer 
                    Card thirdCard = deck.DrawCard();
                    pictureBoxDealerCard1.Image = Properties.Resources.ResourceManager.GetObject(thirdCard.ImagePath) as System.Drawing.Bitmap;
                    totalPointsDealer = calculatePoints(thirdCard);
                    labelTotalPointsDealer.Text = "Total Points Dealer: " + totalPointsDealer.ToString();

                    //Check if it's already BlackJack 
                    if (totalPointsPlayer == 21)
                    { 
                        checkWinner(); 
                    }

                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("No cards left in deck!");
                }
            }
            else
                {
                    MessageBox.Show("Please enter a valid bet amount!");
                }
            
                
            
        }

        private int calculatePoints(Card card) 
        {
 
            // Return number 
            switch (card.CardRank) {
                case Card.Rank.Ace: return 1; // Check since it coild be 11 
                case Card.Rank.Two: return 2;
                case Card.Rank.Three: return 3;
                case Card.Rank.Four: return 4;
                case Card.Rank.Five: return 5;
                case Card.Rank.Six: return 6;
                case Card.Rank.Seven: return 7;
                case Card.Rank.Eight: return 8;
                case Card.Rank.Nine: return 9;
                case Card.Rank.Ten: return 10;
                case Card.Rank.Jack: return 10;
                case Card.Rank.Queen: return 10;
                case Card.Rank.King: return 10;
                default: throw new ArgumentException("Invalid rank");
            }

        }

        private void calculateBet() 
        {
            //Calculate Bet 
            if (isBlackJack) 
            {
                betAmount = betAmount * 3 / 2; 
            }
            else if (isPlayerWon) 
            {
                betAmount = betAmount * 2; 
            }
        }

        private void checkWinner() 
        {
            //Check if anyone has 21 points or check on draw or check who has more point but less than 21

            if (totalPointsPlayer == 21)
            {
                MessageBox.Show("Player WON!!! Blackjack!");
                isBlackJack = true;
                isPlayerWon = true;

            }
            else if (totalPointsDealer == 21) 
            {
                MessageBox.Show("You lose.");
                isBlackJack = false; 
                isPlayerWon = false;
            }
            else if (totalPointsPlayer > totalPointsDealer)
            {
                MessageBox.Show("Player WON!!!");
                isBlackJack = false;
                isPlayerWon = true;
            }
            else if (totalPointsPlayer == totalPointsDealer)
            {
                MessageBox.Show("It's DRAW");
                isBlackJack = false;
                isPlayerWon = false;
                isDraw = true;
            }
            else if (totalPointsDealer > totalPointsPlayer)
            {
                MessageBox.Show("You lose. Dealer won");
                isBlackJack = false;
                isPlayerWon = false;
                isDraw = false;
            }

        }
    }
}
