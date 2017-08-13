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
            this.player1Label = new System.Windows.Forms.Label();
            this.player2Label = new System.Windows.Forms.Label();
            this.player3Label = new System.Windows.Forms.Label();
            this.player2CardsTextBox = new System.Windows.Forms.TextBox();
            this.player1CardsTextBox = new System.Windows.Forms.TextBox();
            this.player3CardsTextBox = new System.Windows.Forms.TextBox();
            this.player4TextBox = new System.Windows.Forms.TextBox();
            this.player4Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // player1Label
            // 
            this.player1Label.AutoSize = true;
            this.player1Label.Location = new System.Drawing.Point(314, 9);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(126, 13);
            this.player1Label.TabIndex = 4;
            this.player1Label.Text = "Karty zawodnika numer 1";
            // 
            // player2Label
            // 
            this.player2Label.AutoSize = true;
            this.player2Label.Location = new System.Drawing.Point(316, 83);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(126, 13);
            this.player2Label.TabIndex = 5;
            this.player2Label.Text = "Karty zawodnika numer 2";
            // 
            // player3Label
            // 
            this.player3Label.AutoSize = true;
            this.player3Label.Location = new System.Drawing.Point(316, 157);
            this.player3Label.Name = "player3Label";
            this.player3Label.Size = new System.Drawing.Size(126, 13);
            this.player3Label.TabIndex = 6;
            this.player3Label.Text = "Karty zawodnika numer 3";
            // 
            // player2CardsTextBox
            // 
            this.player2CardsTextBox.Location = new System.Drawing.Point(317, 99);
            this.player2CardsTextBox.Multiline = true;
            this.player2CardsTextBox.Name = "player2CardsTextBox";
            this.player2CardsTextBox.ReadOnly = true;
            this.player2CardsTextBox.Size = new System.Drawing.Size(206, 45);
            this.player2CardsTextBox.TabIndex = 8;
            this.player2CardsTextBox.Visible = false;
            // 
            // player1CardsTextBox
            // 
            this.player1CardsTextBox.Location = new System.Drawing.Point(315, 25);
            this.player1CardsTextBox.Multiline = true;
            this.player1CardsTextBox.Name = "player1CardsTextBox";
            this.player1CardsTextBox.ReadOnly = true;
            this.player1CardsTextBox.Size = new System.Drawing.Size(208, 45);
            this.player1CardsTextBox.TabIndex = 12;
            this.player1CardsTextBox.Visible = false;
            // 
            // player3CardsTextBox
            // 
            this.player3CardsTextBox.Location = new System.Drawing.Point(315, 182);
            this.player3CardsTextBox.Multiline = true;
            this.player3CardsTextBox.Name = "player3CardsTextBox";
            this.player3CardsTextBox.ReadOnly = true;
            this.player3CardsTextBox.Size = new System.Drawing.Size(206, 45);
            this.player3CardsTextBox.TabIndex = 13;
            this.player3CardsTextBox.Visible = false;
            // 
            // player4TextBox
            // 
            this.player4TextBox.Location = new System.Drawing.Point(315, 256);
            this.player4TextBox.Multiline = true;
            this.player4TextBox.Name = "player4TextBox";
            this.player4TextBox.ReadOnly = true;
            this.player4TextBox.Size = new System.Drawing.Size(206, 45);
            this.player4TextBox.TabIndex = 14;
            this.player4TextBox.Visible = false;
            // 
            // player4Label
            // 
            this.player4Label.AutoSize = true;
            this.player4Label.Location = new System.Drawing.Point(316, 240);
            this.player4Label.Name = "player4Label";
            this.player4Label.Size = new System.Drawing.Size(126, 13);
            this.player4Label.TabIndex = 15;
            this.player4Label.Text = "Karty zawodnika numer 4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 368);
            this.Controls.Add(this.player4Label);
            this.Controls.Add(this.player4TextBox);
            this.Controls.Add(this.player3CardsTextBox);
            this.Controls.Add(this.player1CardsTextBox);
            this.Controls.Add(this.player2CardsTextBox);
            this.Controls.Add(this.player3Label);
            this.Controls.Add(this.player2Label);
            this.Controls.Add(this.player1Label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.Label player2Label;
        private System.Windows.Forms.Label player3Label;
        private System.Windows.Forms.TextBox player2CardsTextBox;
        private System.Windows.Forms.TextBox player1CardsTextBox;
        private System.Windows.Forms.TextBox player3CardsTextBox;
        private System.Windows.Forms.TextBox player4TextBox;
        private System.Windows.Forms.Label player4Label;
    }
}

