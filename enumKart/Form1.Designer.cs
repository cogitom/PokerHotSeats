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
            this.pickRandomCard = new System.Windows.Forms.Button();
            this.showCardsDeck = new System.Windows.Forms.Button();
            this.shuffleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pickRandomCard
            // 
            this.pickRandomCard.Location = new System.Drawing.Point(75, 49);
            this.pickRandomCard.Name = "pickRandomCard";
            this.pickRandomCard.Size = new System.Drawing.Size(96, 23);
            this.pickRandomCard.TabIndex = 0;
            this.pickRandomCard.Text = "Wylosuj kartę";
            this.pickRandomCard.UseVisualStyleBackColor = true;
            this.pickRandomCard.Click += new System.EventHandler(this.pickRandomCard_Click);
            // 
            // showCardsDeck
            // 
            this.showCardsDeck.Location = new System.Drawing.Point(66, 94);
            this.showCardsDeck.Name = "showCardsDeck";
            this.showCardsDeck.Size = new System.Drawing.Size(114, 23);
            this.showCardsDeck.TabIndex = 1;
            this.showCardsDeck.Text = "Pokaż karty w talii";
            this.showCardsDeck.UseVisualStyleBackColor = true;
            this.showCardsDeck.Click += new System.EventHandler(this.showCardsDeck_Click);
            // 
            // shuffleButton
            // 
            this.shuffleButton.Location = new System.Drawing.Point(66, 152);
            this.shuffleButton.Name = "shuffleButton";
            this.shuffleButton.Size = new System.Drawing.Size(114, 23);
            this.shuffleButton.TabIndex = 2;
            this.shuffleButton.Text = "Potasuj karty";
            this.shuffleButton.UseVisualStyleBackColor = true;
            this.shuffleButton.Click += new System.EventHandler(this.shuffleButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.shuffleButton);
            this.Controls.Add(this.showCardsDeck);
            this.Controls.Add(this.pickRandomCard);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pickRandomCard;
        private System.Windows.Forms.Button showCardsDeck;
        private System.Windows.Forms.Button shuffleButton;
    }
}

