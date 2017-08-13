namespace enumKart
{
    partial class mainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.newPlayerBox = new System.Windows.Forms.GroupBox();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addNewPlayerButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.playersListText = new System.Windows.Forms.TextBox();
            this.newPlayerBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(216, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Symulator gry w pokera";
            // 
            // newPlayerBox
            // 
            this.newPlayerBox.AccessibleDescription = "newPlayerBox";
            this.newPlayerBox.AccessibleName = "newPlayerBox";
            this.newPlayerBox.Controls.Add(this.confirmPasswordTextBox);
            this.newPlayerBox.Controls.Add(this.passwordTextBox);
            this.newPlayerBox.Controls.Add(this.nameTextBox);
            this.newPlayerBox.Controls.Add(this.label4);
            this.newPlayerBox.Controls.Add(this.label3);
            this.newPlayerBox.Controls.Add(this.label2);
            this.newPlayerBox.Controls.Add(this.addNewPlayerButton);
            this.newPlayerBox.Location = new System.Drawing.Point(24, 48);
            this.newPlayerBox.Name = "newPlayerBox";
            this.newPlayerBox.Size = new System.Drawing.Size(290, 254);
            this.newPlayerBox.TabIndex = 1;
            this.newPlayerBox.TabStop = false;
            this.newPlayerBox.Text = "groupBox1";
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(86, 161);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(195, 20);
            this.confirmPasswordTextBox.TabIndex = 7;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(86, 109);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(195, 20);
            this.passwordTextBox.TabIndex = 6;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(87, 49);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(195, 20);
            this.nameTextBox.TabIndex = 5;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Powtórz hasło:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hasło gracza:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nazwa gracza: ";
            // 
            // addNewPlayerButton
            // 
            this.addNewPlayerButton.Location = new System.Drawing.Point(130, 213);
            this.addNewPlayerButton.Name = "addNewPlayerButton";
            this.addNewPlayerButton.Size = new System.Drawing.Size(154, 23);
            this.addNewPlayerButton.TabIndex = 2;
            this.addNewPlayerButton.Text = "Dodaj gracza";
            this.addNewPlayerButton.UseVisualStyleBackColor = true;
            this.addNewPlayerButton.Click += new System.EventHandler(this.addNewPlayerButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Zacznij Grę";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.playersListText);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(333, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 254);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Lista graczy";
            // 
            // playersListText
            // 
            this.playersListText.Location = new System.Drawing.Point(6, 49);
            this.playersListText.Multiline = true;
            this.playersListText.Name = "playersListText";
            this.playersListText.Size = new System.Drawing.Size(288, 167);
            this.playersListText.TabIndex = 9;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 314);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.newPlayerBox);
            this.Controls.Add(this.label1);
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.newPlayerBox.ResumeLayout(false);
            this.newPlayerBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox newPlayerBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addNewPlayerButton;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox playersListText;
    }
}