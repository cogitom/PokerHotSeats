namespace enumKart
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.newDealButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bobSurfaceCardTextBox = new System.Windows.Forms.TextBox();
            this.nextTourButton = new System.Windows.Forms.Button();
            this.TomSurfaceCardTextBox = new System.Windows.Forms.TextBox();
            this.LilySurfaceCardTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TomNumberOfCards = new System.Windows.Forms.TextBox();
            this.BobNumberOfCards = new System.Windows.Forms.TextBox();
            this.LilyNumberOfCards = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // newDealButton
            // 
            this.newDealButton.Location = new System.Drawing.Point(12, 34);
            this.newDealButton.Name = "newDealButton";
            this.newDealButton.Size = new System.Drawing.Size(114, 23);
            this.newDealButton.TabIndex = 3;
            this.newDealButton.Text = "Rozdaj karty";
            this.newDealButton.UseVisualStyleBackColor = true;
            this.newDealButton.Click += new System.EventHandler(this.newDealButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Karty Toma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Karty Boba";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Karty Lily";
            // 
            // bobSurfaceCardTextBox
            // 
            this.bobSurfaceCardTextBox.Location = new System.Drawing.Point(272, 138);
            this.bobSurfaceCardTextBox.Multiline = true;
            this.bobSurfaceCardTextBox.Name = "bobSurfaceCardTextBox";
            this.bobSurfaceCardTextBox.ReadOnly = true;
            this.bobSurfaceCardTextBox.Size = new System.Drawing.Size(206, 45);
            this.bobSurfaceCardTextBox.TabIndex = 8;
            // 
            // nextTourButton
            // 
            this.nextTourButton.Location = new System.Drawing.Point(12, 102);
            this.nextTourButton.Name = "nextTourButton";
            this.nextTourButton.Size = new System.Drawing.Size(114, 23);
            this.nextTourButton.TabIndex = 11;
            this.nextTourButton.Text = "Następna tura";
            this.nextTourButton.UseVisualStyleBackColor = true;
            this.nextTourButton.Click += new System.EventHandler(this.nextTourButton_Click);
            // 
            // TomSurfaceCardTextBox
            // 
            this.TomSurfaceCardTextBox.Location = new System.Drawing.Point(272, 34);
            this.TomSurfaceCardTextBox.Multiline = true;
            this.TomSurfaceCardTextBox.Name = "TomSurfaceCardTextBox";
            this.TomSurfaceCardTextBox.ReadOnly = true;
            this.TomSurfaceCardTextBox.Size = new System.Drawing.Size(208, 45);
            this.TomSurfaceCardTextBox.TabIndex = 12;
            // 
            // LilySurfaceCardTextBox
            // 
            this.LilySurfaceCardTextBox.Location = new System.Drawing.Point(272, 238);
            this.LilySurfaceCardTextBox.Multiline = true;
            this.LilySurfaceCardTextBox.Name = "LilySurfaceCardTextBox";
            this.LilySurfaceCardTextBox.ReadOnly = true;
            this.LilySurfaceCardTextBox.Size = new System.Drawing.Size(206, 45);
            this.LilySurfaceCardTextBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(550, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ilość Kart Toma";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(550, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ilość kart Boba";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(550, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ilość kart Lily";
            // 
            // TomNumberOfCards
            // 
            this.TomNumberOfCards.Location = new System.Drawing.Point(553, 36);
            this.TomNumberOfCards.Name = "TomNumberOfCards";
            this.TomNumberOfCards.ReadOnly = true;
            this.TomNumberOfCards.Size = new System.Drawing.Size(78, 20);
            this.TomNumberOfCards.TabIndex = 17;
            // 
            // BobNumberOfCards
            // 
            this.BobNumberOfCards.Location = new System.Drawing.Point(553, 138);
            this.BobNumberOfCards.Name = "BobNumberOfCards";
            this.BobNumberOfCards.ReadOnly = true;
            this.BobNumberOfCards.Size = new System.Drawing.Size(78, 20);
            this.BobNumberOfCards.TabIndex = 18;
            // 
            // LilyNumberOfCards
            // 
            this.LilyNumberOfCards.Location = new System.Drawing.Point(553, 238);
            this.LilyNumberOfCards.Name = "LilyNumberOfCards";
            this.LilyNumberOfCards.ReadOnly = true;
            this.LilyNumberOfCards.Size = new System.Drawing.Size(78, 20);
            this.LilyNumberOfCards.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 368);
            this.Controls.Add(this.LilyNumberOfCards);
            this.Controls.Add(this.BobNumberOfCards);
            this.Controls.Add(this.TomNumberOfCards);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LilySurfaceCardTextBox);
            this.Controls.Add(this.TomSurfaceCardTextBox);
            this.Controls.Add(this.nextTourButton);
            this.Controls.Add(this.bobSurfaceCardTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newDealButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button newDealButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bobSurfaceCardTextBox;
        private System.Windows.Forms.Button nextTourButton;
        private System.Windows.Forms.TextBox TomSurfaceCardTextBox;
        private System.Windows.Forms.TextBox LilySurfaceCardTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TomNumberOfCards;
        private System.Windows.Forms.TextBox BobNumberOfCards;
        private System.Windows.Forms.TextBox LilyNumberOfCards;
    }
}

