namespace Final_Project___Word_Scramble
{
    partial class GameForm1
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.WordsLabel = new System.Windows.Forms.Label();
            this.HintLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.CheckButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Niagara Solid", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(177, 47);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Word Scramble";
            // 
            // WordsLabel
            // 
            this.WordsLabel.Font = new System.Drawing.Font("Niagara Solid", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordsLabel.Location = new System.Drawing.Point(1, 71);
            this.WordsLabel.Name = "WordsLabel";
            this.WordsLabel.Size = new System.Drawing.Size(797, 78);
            this.WordsLabel.TabIndex = 1;
            this.WordsLabel.Text = "label2";
            this.WordsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HintLabel
            // 
            this.HintLabel.AutoSize = true;
            this.HintLabel.Font = new System.Drawing.Font("Niagara Solid", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HintLabel.Location = new System.Drawing.Point(220, 197);
            this.HintLabel.Name = "HintLabel";
            this.HintLabel.Size = new System.Drawing.Size(80, 43);
            this.HintLabel.TabIndex = 2;
            this.HintLabel.Text = "HINT : ";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Niagara Solid", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(220, 233);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(137, 43);
            this.TimeLabel.TabIndex = 3;
            this.TimeLabel.Text = "TIME LEFT : ";
            // 
            // RefreshButton
            // 
            this.RefreshButton.Font = new System.Drawing.Font("Niagara Solid", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshButton.Location = new System.Drawing.Point(228, 376);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(153, 62);
            this.RefreshButton.TabIndex = 4;
            this.RefreshButton.Text = "REFRESH WORD";
            this.RefreshButton.UseVisualStyleBackColor = true;
            // 
            // CheckButton
            // 
            this.CheckButton.Font = new System.Drawing.Font("Niagara Solid", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckButton.Location = new System.Drawing.Point(423, 376);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(153, 62);
            this.CheckButton.TabIndex = 5;
            this.CheckButton.Text = "CHECK WORD";
            this.CheckButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Niagara Solid", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(225, 286);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(351, 50);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Enter a valid word";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // GameForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.HintLabel);
            this.Controls.Add(this.WordsLabel);
            this.Controls.Add(this.TitleLabel);
            this.Name = "GameForm1";
            this.Text = "GameForm1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label WordsLabel;
        private System.Windows.Forms.Label HintLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}