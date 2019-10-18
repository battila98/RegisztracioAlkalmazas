namespace RegisztracioAlkalmazas
{
    partial class Regisztracio
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
            this.NevLabel = new System.Windows.Forms.Label();
            this.DatumLabel = new System.Windows.Forms.Label();
            this.NemLabel = new System.Windows.Forms.Label();
            this.HobbiLabel = new System.Windows.Forms.Label();
            this.HobbiListBox = new System.Windows.Forms.ListBox();
            this.HobbiAddLabel = new System.Windows.Forms.Label();
            this.NevBox = new System.Windows.Forms.TextBox();
            this.HozzaadButton = new System.Windows.Forms.Button();
            this.MentesButton = new System.Windows.Forms.Button();
            this.BetoltesButton = new System.Windows.Forms.Button();
            this.FerfiRadioButton = new System.Windows.Forms.RadioButton();
            this.NoRadioButton = new System.Windows.Forms.RadioButton();
            this.MuskatliRadioButton = new System.Windows.Forms.RadioButton();
            this.DatumBox = new System.Windows.Forms.TextBox();
            this.HobbiBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NevLabel
            // 
            this.NevLabel.AutoSize = true;
            this.NevLabel.Location = new System.Drawing.Point(24, 27);
            this.NevLabel.Name = "NevLabel";
            this.NevLabel.Size = new System.Drawing.Size(30, 13);
            this.NevLabel.TabIndex = 0;
            this.NevLabel.Text = "Név:";
            // 
            // DatumLabel
            // 
            this.DatumLabel.AutoSize = true;
            this.DatumLabel.Location = new System.Drawing.Point(24, 58);
            this.DatumLabel.Name = "DatumLabel";
            this.DatumLabel.Size = new System.Drawing.Size(64, 13);
            this.DatumLabel.TabIndex = 1;
            this.DatumLabel.Text = "Szul.Datum:";
            // 
            // NemLabel
            // 
            this.NemLabel.AutoSize = true;
            this.NemLabel.Location = new System.Drawing.Point(24, 88);
            this.NemLabel.Name = "NemLabel";
            this.NemLabel.Size = new System.Drawing.Size(32, 13);
            this.NemLabel.TabIndex = 2;
            this.NemLabel.Text = "Nem:";
            // 
            // HobbiLabel
            // 
            this.HobbiLabel.AutoSize = true;
            this.HobbiLabel.Location = new System.Drawing.Point(24, 122);
            this.HobbiLabel.Name = "HobbiLabel";
            this.HobbiLabel.Size = new System.Drawing.Size(91, 13);
            this.HobbiLabel.TabIndex = 3;
            this.HobbiLabel.Text = "Kedvenc hobbik: ";
            // 
            // HobbiListBox
            // 
            this.HobbiListBox.FormattingEnabled = true;
            this.HobbiListBox.Location = new System.Drawing.Point(110, 122);
            this.HobbiListBox.Name = "HobbiListBox";
            this.HobbiListBox.Size = new System.Drawing.Size(156, 147);
            this.HobbiListBox.TabIndex = 4;
            // 
            // HobbiAddLabel
            // 
            this.HobbiAddLabel.AutoSize = true;
            this.HobbiAddLabel.Location = new System.Drawing.Point(24, 289);
            this.HobbiAddLabel.Name = "HobbiAddLabel";
            this.HobbiAddLabel.Size = new System.Drawing.Size(49, 13);
            this.HobbiAddLabel.TabIndex = 5;
            this.HobbiAddLabel.Text = "Új hobbi:";
            // 
            // NevBox
            // 
            this.NevBox.Location = new System.Drawing.Point(110, 27);
            this.NevBox.Name = "NevBox";
            this.NevBox.Size = new System.Drawing.Size(156, 20);
            this.NevBox.TabIndex = 6;
            // 
            // HozzaadButton
            // 
            this.HozzaadButton.Location = new System.Drawing.Point(138, 312);
            this.HozzaadButton.Name = "HozzaadButton";
            this.HozzaadButton.Size = new System.Drawing.Size(75, 23);
            this.HozzaadButton.TabIndex = 7;
            this.HozzaadButton.Text = "Hozzáad";
            this.HozzaadButton.UseVisualStyleBackColor = true;
            // 
            // MentesButton
            // 
            this.MentesButton.Location = new System.Drawing.Point(219, 361);
            this.MentesButton.Name = "MentesButton";
            this.MentesButton.Size = new System.Drawing.Size(75, 23);
            this.MentesButton.TabIndex = 8;
            this.MentesButton.Text = "Mentés";
            this.MentesButton.UseVisualStyleBackColor = true;
            // 
            // BetoltesButton
            // 
            this.BetoltesButton.Location = new System.Drawing.Point(63, 361);
            this.BetoltesButton.Name = "BetoltesButton";
            this.BetoltesButton.Size = new System.Drawing.Size(75, 23);
            this.BetoltesButton.TabIndex = 9;
            this.BetoltesButton.Text = "Betöltés";
            this.BetoltesButton.UseVisualStyleBackColor = true;
            // 
            // FerfiRadioButton
            // 
            this.FerfiRadioButton.AutoSize = true;
            this.FerfiRadioButton.Location = new System.Drawing.Point(106, 88);
            this.FerfiRadioButton.Name = "FerfiRadioButton";
            this.FerfiRadioButton.Size = new System.Drawing.Size(45, 17);
            this.FerfiRadioButton.TabIndex = 10;
            this.FerfiRadioButton.TabStop = true;
            this.FerfiRadioButton.Text = "Férfi";
            this.FerfiRadioButton.UseVisualStyleBackColor = true;
            // 
            // NoRadioButton
            // 
            this.NoRadioButton.AutoSize = true;
            this.NoRadioButton.Location = new System.Drawing.Point(157, 88);
            this.NoRadioButton.Name = "NoRadioButton";
            this.NoRadioButton.Size = new System.Drawing.Size(39, 17);
            this.NoRadioButton.TabIndex = 11;
            this.NoRadioButton.TabStop = true;
            this.NoRadioButton.Text = "Nő";
            this.NoRadioButton.UseVisualStyleBackColor = true;
            // 
            // MuskatliRadioButton
            // 
            this.MuskatliRadioButton.AutoSize = true;
            this.MuskatliRadioButton.Location = new System.Drawing.Point(202, 88);
            this.MuskatliRadioButton.Name = "MuskatliRadioButton";
            this.MuskatliRadioButton.Size = new System.Drawing.Size(64, 17);
            this.MuskatliRadioButton.TabIndex = 12;
            this.MuskatliRadioButton.TabStop = true;
            this.MuskatliRadioButton.Text = "Muskátli";
            this.MuskatliRadioButton.UseVisualStyleBackColor = true;
            // 
            // DatumBox
            // 
            this.DatumBox.Location = new System.Drawing.Point(110, 58);
            this.DatumBox.Name = "DatumBox";
            this.DatumBox.Size = new System.Drawing.Size(114, 20);
            this.DatumBox.TabIndex = 13;
            // 
            // HobbiBox
            // 
            this.HobbiBox.Location = new System.Drawing.Point(79, 286);
            this.HobbiBox.Name = "HobbiBox";
            this.HobbiBox.Size = new System.Drawing.Size(187, 20);
            this.HobbiBox.TabIndex = 14;
            // 
            // Regisztracio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 413);
            this.Controls.Add(this.HobbiBox);
            this.Controls.Add(this.DatumBox);
            this.Controls.Add(this.MuskatliRadioButton);
            this.Controls.Add(this.NoRadioButton);
            this.Controls.Add(this.FerfiRadioButton);
            this.Controls.Add(this.BetoltesButton);
            this.Controls.Add(this.MentesButton);
            this.Controls.Add(this.HozzaadButton);
            this.Controls.Add(this.NevBox);
            this.Controls.Add(this.HobbiAddLabel);
            this.Controls.Add(this.HobbiListBox);
            this.Controls.Add(this.HobbiLabel);
            this.Controls.Add(this.NemLabel);
            this.Controls.Add(this.DatumLabel);
            this.Controls.Add(this.NevLabel);
            this.Name = "Regisztracio";
            this.Text = "Regisztráció";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NevLabel;
        private System.Windows.Forms.Label DatumLabel;
        private System.Windows.Forms.Label NemLabel;
        private System.Windows.Forms.Label HobbiLabel;
        private System.Windows.Forms.ListBox HobbiListBox;
        private System.Windows.Forms.Label HobbiAddLabel;
        private System.Windows.Forms.TextBox NevBox;
        private System.Windows.Forms.Button HozzaadButton;
        private System.Windows.Forms.Button MentesButton;
        private System.Windows.Forms.Button BetoltesButton;
        private System.Windows.Forms.RadioButton FerfiRadioButton;
        private System.Windows.Forms.RadioButton NoRadioButton;
        private System.Windows.Forms.RadioButton MuskatliRadioButton;
        private System.Windows.Forms.TextBox DatumBox;
        private System.Windows.Forms.TextBox HobbiBox;
    }
}

