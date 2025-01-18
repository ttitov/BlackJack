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
            this.pictureBoxCard1 = new System.Windows.Forms.PictureBox();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCard1
            // 
            this.pictureBoxCard1.Location = new System.Drawing.Point(106, 131);
            this.pictureBoxCard1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBoxCard1.Name = "pictureBoxCard1";
            this.pictureBoxCard1.Size = new System.Drawing.Size(348, 507);
            this.pictureBoxCard1.TabIndex = 0;
            this.pictureBoxCard1.TabStop = false;
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
            // FormBlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2326, 1227);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPlayer);
            this.Controls.Add(this.pictureBoxCard1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormBlackJack";
            this.Text = "Blackjack";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCard1;
        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.Label label1;
    }
}

