namespace BlackJack
{
    partial class FormBlackJack
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxPlayerCard1 = new System.Windows.Forms.PictureBox();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxDeck = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlayerCard2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDealerCard1 = new System.Windows.Forms.PictureBox();
            this.labelBet = new System.Windows.Forms.Label();
            this.textBoxBet = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.buttonStick = new System.Windows.Forms.Button();
            this.pictureBoxDealerCard2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDealerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDealerCard2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPlayerCard1
            // 
            this.pictureBoxPlayerCard1.Location = new System.Drawing.Point(117, 144);
            this.pictureBoxPlayerCard1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBoxPlayerCard1.Name = "pictureBoxPlayerCard1";
            this.pictureBoxPlayerCard1.Size = new System.Drawing.Size(348, 507);
            this.pictureBoxPlayerCard1.TabIndex = 0;
            this.pictureBoxPlayerCard1.TabStop = false;
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer.Location = new System.Drawing.Point(110, 70);
            this.labelPlayer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(124, 42);
            this.labelPlayer.TabIndex = 1;
            this.labelPlayer.Text = "Player";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1855, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dealer";
            // 
            // pictureBoxDeck
            // 
            this.pictureBoxDeck.Image = global::BlackJack.Properties.Resources.cover;
            this.pictureBoxDeck.Location = new System.Drawing.Point(959, 144);
            this.pictureBoxDeck.Name = "pictureBoxDeck";
            this.pictureBoxDeck.Size = new System.Drawing.Size(352, 507);
            this.pictureBoxDeck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDeck.TabIndex = 3;
            this.pictureBoxDeck.TabStop = false;
            // 
            // pictureBoxPlayerCard2
            // 
            this.pictureBoxPlayerCard2.Location = new System.Drawing.Point(523, 144);
            this.pictureBoxPlayerCard2.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBoxPlayerCard2.Name = "pictureBoxPlayerCard2";
            this.pictureBoxPlayerCard2.Size = new System.Drawing.Size(348, 507);
            this.pictureBoxPlayerCard2.TabIndex = 4;
            this.pictureBoxPlayerCard2.TabStop = false;
            // 
            // pictureBoxDealerCard1
            // 
            this.pictureBoxDealerCard1.Location = new System.Drawing.Point(1402, 144);
            this.pictureBoxDealerCard1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBoxDealerCard1.Name = "pictureBoxDealerCard1";
            this.pictureBoxDealerCard1.Size = new System.Drawing.Size(348, 507);
            this.pictureBoxDealerCard1.TabIndex = 5;
            this.pictureBoxDealerCard1.TabStop = false;
            // 
            // labelBet
            // 
            this.labelBet.AutoSize = true;
            this.labelBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBet.Location = new System.Drawing.Point(117, 782);
            this.labelBet.Name = "labelBet";
            this.labelBet.Size = new System.Drawing.Size(58, 33);
            this.labelBet.TabIndex = 6;
            this.labelBet.Text = "Bet";
            // 
            // textBoxBet
            // 
            this.textBoxBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBet.Location = new System.Drawing.Point(211, 779);
            this.textBoxBet.Name = "textBoxBet";
            this.textBoxBet.Size = new System.Drawing.Size(100, 40);
            this.textBoxBet.TabIndex = 7;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(117, 861);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(107, 37);
            this.labelTotal.TabIndex = 8;
            this.labelTotal.Text = "Total: ";
            // 
            // buttonStick
            // 
            this.buttonStick.Location = new System.Drawing.Point(523, 766);
            this.buttonStick.Name = "buttonStick";
            this.buttonStick.Size = new System.Drawing.Size(205, 70);
            this.buttonStick.TabIndex = 9;
            this.buttonStick.Text = "STICK";
            this.buttonStick.UseVisualStyleBackColor = true;
            // 
            // pictureBoxDealerCard2
            // 
            this.pictureBoxDealerCard2.Location = new System.Drawing.Point(1843, 144);
            this.pictureBoxDealerCard2.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBoxDealerCard2.Name = "pictureBoxDealerCard2";
            this.pictureBoxDealerCard2.Size = new System.Drawing.Size(348, 507);
            this.pictureBoxDealerCard2.TabIndex = 10;
            this.pictureBoxDealerCard2.TabStop = false;
            // 
            // FormBlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2326, 1227);
            this.Controls.Add(this.pictureBoxDealerCard2);
            this.Controls.Add(this.buttonStick);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.textBoxBet);
            this.Controls.Add(this.labelBet);
            this.Controls.Add(this.pictureBoxDealerCard1);
            this.Controls.Add(this.pictureBoxPlayerCard2);
            this.Controls.Add(this.pictureBoxDeck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPlayer);
            this.Controls.Add(this.pictureBoxPlayerCard1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormBlackJack";
            this.Text = "Blackjack";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDealerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDealerCard2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPlayerCard1;
        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxDeck;
        private System.Windows.Forms.PictureBox pictureBoxPlayerCard2;
        private System.Windows.Forms.PictureBox pictureBoxDealerCard1;
        private System.Windows.Forms.Label labelBet;
        private System.Windows.Forms.TextBox textBoxBet;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button buttonStick;
        private System.Windows.Forms.PictureBox pictureBoxDealerCard2;
    }
}

