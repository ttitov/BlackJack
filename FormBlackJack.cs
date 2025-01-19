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
        private int totalPointsPlayer = 0;
        private int totalPointsDealer = 0;

        private double betAmount;
        private double totalBankAmount = 0; //total money in the Bank

        private bool isPlayerWon, isBlackJack;
        private bool isDraw = false;
        private bool isDoubleDown = false; //only one move available if it was double-down bet

        private List<PictureBox> dealerPictureBoxes;
        private int dealerCardIndex;

        private List<PictureBox> playerPictureBoxes;
        private int playerCardIndex;

        public FormBlackJack()
        {
            InitializeComponent();
            InitializePictureBoxes();
            deck = new Deck();
        }

        public void InitializePictureBoxes()
        {
            // Initialize bicture boxes List
            dealerPictureBoxes = new List<PictureBox>
            {
                pictureBoxDealerCard1,
                pictureBoxDealerCard2,
                pictureBoxDealerCard3,
                pictureBoxDealerCard4,
                pictureBoxDealerCard5,
                pictureBoxDealerCard6
            };

            playerPictureBoxes = new List<PictureBox>
            {
                pictureBoxPlayerCard1,
                pictureBoxPlayerCard2,
                pictureBoxPlayerCard3,
                pictureBoxPlayerCard4,
                pictureBoxPlayerCard5,
                pictureBoxPlayerCard6
            };

        }

        private void buttonStick_Click(object sender, EventArgs e)
        {
            // Pass move to Dealer
            DealerPlayCards();
        }

        private void pictureBoxDeck_Click(object sender, EventArgs e)
        {
            // Take card from the Deck by Player
            if (totalPointsPlayer < 21 && playerCardIndex < playerPictureBoxes.Count)
            {
                try 
                {
                    // Draw new card
                    Card drawnCard = deck.DrawCard();

                    // Display card in next available picture box
                    playerPictureBoxes[playerCardIndex].Image =
                        Properties.Resources.ResourceManager.GetObject(drawnCard.ImagePath) as System.Drawing.Bitmap;

                    // Add card value to total
                    totalPointsPlayer += CalculatePoints(drawnCard);
                    if (totalPointsPlayer > 21 && drawnCard.CardRank == Card.Rank.Ace)
                    {
                        totalPointsPlayer -= 10; // Subtract 10 if the card is Ace and total is < 21 
                    }
                    // Update player's points display
                    labelTotalPlayerPoints.Text = "Total Points: " + totalPointsPlayer.ToString();

                    // Move to next picture box
                    playerCardIndex++;


                    // Check if player busted
                    if (totalPointsPlayer > 21)
                    {
                        CheckWinner();
                        return;
                    }

                    // Add a small delay so you can see cards being moved
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(1000);

                    if (isDoubleDown) 
                    {
                        CheckWinner(); // the last move for player 
                    }
                } 
                catch 
                {
                    MessageBox.Show("Not enough cards in deck!");
                    CheckWinner();
                    return;
                }
            }
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            textBoxBet.Enabled = true;
            // Reset game if there was a previous game 
            if (pictureBoxPlayerCard1.Image != null)
            {
                ResetGame();
            }
            // Start the Game
            if (IsBetValid(textBoxBet.Text))
                {
                betAmount = double.Parse(textBoxBet.Text);
                
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
                    totalPointsPlayer = CalculatePoints(firstCard) + CalculatePoints(secondCard);
                    if (totalPointsPlayer > 21 && (firstCard.CardRank == Card.Rank.Ace || secondCard.CardRank == Card.Rank.Ace)) {
                        totalPointsPlayer -= 10; // Minus 10 if one of the card is Ace and total is over 21 
                    }
                    labelTotalPlayerPoints.Text = "Total Points: " + totalPointsPlayer.ToString();

                    playerCardIndex = 2; // set index for the next moves

                    // Put one card for Dealer 
                    Card thirdCard = deck.DrawCard();
                    pictureBoxDealerCard1.Image = Properties.Resources.ResourceManager.GetObject(thirdCard.ImagePath) as System.Drawing.Bitmap;
                    totalPointsDealer = CalculatePoints(thirdCard);
                    labelTotalPointsDealer.Text = "Total Points Dealer: " + totalPointsDealer.ToString();

                    dealerCardIndex = 1; // Set index since 1st position already filled
                    //Check if it's already BlackJack 
                    if (totalPointsPlayer == 21)
                    { 
                        CheckWinner(); 
                    }

                    //TBD Check if it's Double-down option 
                    //if (totalPointsPlayer == 22 || totalPointsPlayer == 18 || totalPointsPlayer == 20) {
                    //    buttonDouble.Enabled = true;
                    //}

                    pictureBoxDeck.Enabled = true; // you can make moves 
                    textBoxBet.Enabled = false; // Player can't change bet after game started
                    buttonStick.Enabled = true;
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("No cards left in deck!");
                }
            }
            else
                {
                    MessageBox.Show("Please enter a valid bet amount! (2-100)");
                }

        }

        private int CalculatePoints(Card card) 
        {
 
            // Return number 
            switch (card.CardRank) {
                case Card.Rank.Ace: return 11; // Check since it coild be 11 
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

        private void CalculateBet() 
        {
            //Calculate Bet 
            if (isBlackJack)
            {
                betAmount = betAmount * 3 / 2;
                textBoxBet.Text = "£" + betAmount.ToString();
                textBoxBet.Enabled = false;
            }
            else if (isPlayerWon)
            {
                betAmount = betAmount * 2;
                textBoxBet.Text = "£" + betAmount.ToString();
                textBoxBet.Enabled = false;
            }
            else {
                labelBank.Text = "Bank: £" + betAmount.ToString();
            }
        }

        private void CheckWinner() 
        {
            //Check if anyone has 21 points or check on draw or check who has more point but less than 21

            if (totalPointsPlayer == 21)
            {
                CalculateBet();
                MessageBox.Show("Player WON!!! Blackjack!");
                totalBankAmount -= betAmount; 
                isBlackJack = true;
                isPlayerWon = true;
                labelBank.Text = "Bank: £" + totalBankAmount.ToString();
            }
            else if ((totalPointsPlayer > totalPointsDealer && totalPointsPlayer <= 21) || totalPointsDealer > 21)
            {
                CalculateBet();
                MessageBox.Show("Player WON!!!");
                isBlackJack = false;
                isPlayerWon = true;
                totalBankAmount -= betAmount;
                labelBank.Text = "Bank: £" + totalBankAmount.ToString();
            }
            else if (totalPointsDealer == 21 || totalPointsPlayer > 21) 
            {
                CalculateBet();
                MessageBox.Show("You lose.");
                isBlackJack = false; 
                isPlayerWon = false;
                textBoxBet.Text = "0";
                textBoxBet.Enabled = false;
                totalBankAmount += betAmount;
                labelBank.Text = "Bank: £" + totalBankAmount.ToString();
            }
            else if (totalPointsPlayer == totalPointsDealer)
            {
                MessageBox.Show("It's DRAW");
                isBlackJack = false;
                isPlayerWon = false;
                isDraw = true;
            }
            else if (totalPointsDealer > totalPointsPlayer && totalPointsDealer <= 21)
            {
                CalculateBet();
                MessageBox.Show("You lose. Dealer won");
                isBlackJack = false;
                isPlayerWon = false;
                isDraw = false;
                textBoxBet.Text = "0";
                textBoxBet.Enabled = false;
                totalBankAmount += betAmount;
                labelBank.Text = "Bank: £" + totalBankAmount.ToString();
            }


            // End game logic - can't click on the deck and you can start with bet 
            pictureBoxDeck.Enabled = false;
            textBoxBet.Enabled = true;
            buttonStick.Enabled = false;

        }

        // Check if bet in the range £2 - £100 
        private bool IsBetValid(String bet)
        {
            double betAmount;
            double MIN_BET = 2;
            double MAX_BET = 100;
            try
            {
                betAmount = Double.Parse(bet);
                return betAmount >= MIN_BET && betAmount <= MAX_BET;
            }
            catch
            {
                return false;
            }
        }

        // Delear's move
        private void DealerPlayCards()
        {

            while (totalPointsDealer < 17 && dealerCardIndex < dealerPictureBoxes.Count)
            {
                try
                {
                    // Draw new card
                    Card drawnCard = deck.DrawCard();

                    // Display card in next available picture box
                    dealerPictureBoxes[dealerCardIndex].Image =
                        Properties.Resources.ResourceManager.GetObject(drawnCard.ImagePath) as System.Drawing.Bitmap;

                    // Add card value to total
                    totalPointsDealer += CalculatePoints(drawnCard);
                    if (totalPointsDealer > 21 && drawnCard.CardRank == Card.Rank.Ace)
                    {
                        totalPointsDealer -= 10; // Subtract 10 if the card is Ace and total is < 21 
                    }

                    // Update dealer points display
                    labelTotalPointsDealer.Text = "Total Points Dealer: " + totalPointsDealer.ToString();

                    // Move to next picture box
                    dealerCardIndex++;

                    // Check if dealer busted
                    if (totalPointsDealer > 21)
                    {
                        CheckWinner();
                        return;
                    }

                    // Add a small delay so player can see cards being dealt
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(1000);
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("Not enough cards in deck!");
                    CheckWinner();
                    return;
                }
            }

            CheckWinner();
           
        }

        private void buttonDouble_Click(object sender, EventArgs e)
        {

        }

        private void ResetGame()
        {
            // Clear all picture boxes for dealer
            pictureBoxDealerCard1.Image = null;
            pictureBoxDealerCard2.Image = null;
            pictureBoxDealerCard3.Image = null;
            pictureBoxDealerCard4.Image = null;
            pictureBoxDealerCard5.Image = null;
            pictureBoxDealerCard6.Image = null;

            // Clear all picture boxes for player
            pictureBoxPlayerCard1.Image = null;
            pictureBoxPlayerCard2.Image = null;
            pictureBoxPlayerCard3.Image = null;
            pictureBoxPlayerCard4.Image = null;
            pictureBoxPlayerCard5.Image = null;
            pictureBoxPlayerCard6.Image = null;

            // Reset card indexes
            dealerCardIndex = 0;
            playerCardIndex = 0;  // If you're tracking player cards similarly

            // Reset points
            totalPointsDealer = 0;
            totalPointsPlayer = 0;

            // Update labels
            labelTotalPlayerPoints.Text = "Total Points: ";
            labelTotalPointsDealer.Text = "Total Points Dealer: ";

            // Reset any bet-related variables
            //betAmount = 0;
            //textBoxBet.Text = "";

            // Enable/disable buttons
            buttonSplit.Enabled = false;
            buttonDouble.Enabled = false;
            buttonStick.Enabled = true;
        }
    }
}
