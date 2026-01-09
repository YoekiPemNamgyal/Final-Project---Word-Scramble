namespace Final_Project___Word_Scramble
{
    partial class frmGame
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
            this.components = new System.ComponentModel.Container();
            this.lblScrambledWord = new System.Windows.Forms.Label();
            this.lblHint = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnScore = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblScrambledWord
            // 
            this.lblScrambledWord.Font = new System.Drawing.Font("Niagara Solid", 64.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScrambledWord.Location = new System.Drawing.Point(1, 58);
            this.lblScrambledWord.Name = "lblScrambledWord";
            this.lblScrambledWord.Size = new System.Drawing.Size(797, 106);
            this.lblScrambledWord.TabIndex = 0;
            this.lblScrambledWord.Text = "D G L E N O W E K\r\n";
            this.lblScrambledWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Font = new System.Drawing.Font("Niagara Engraved", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHint.Location = new System.Drawing.Point(225, 193);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(340, 40);
            this.lblHint.TabIndex = 1;
            this.lblHint.Text = "HINT : Something you gain by studying";
            this.lblHint.Click += new System.EventHandler(this.lblHint_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Niagara Engraved", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(217, 354);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(137, 40);
            this.lblTimer.TabIndex = 2;
            this.lblTimer.Text = "Time Left : 30";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Niagara Engraved", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(473, 354);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(95, 40);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "Score : 0";
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Niagara Engraved", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(335, 401);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(127, 40);
            this.lblMessage.TabIndex = 4;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Niagara Engraved", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtAnswer.Location = new System.Drawing.Point(225, 236);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(349, 47);
            this.txtAnswer.TabIndex = 5;
            this.txtAnswer.Text = "Enter a valid word";
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Niagara Engraved", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(225, 302);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(156, 49);
            this.btnCheck.TabIndex = 6;
            this.btnCheck.Text = "CHECK WORD";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Niagara Engraved", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(400, 302);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(174, 49);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "REFRESH WORD";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnScore
            // 
            this.btnScore.Font = new System.Drawing.Font("Niagara Solid", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScore.Location = new System.Drawing.Point(680, 374);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(95, 55);
            this.btnScore.TabIndex = 8;
            this.btnScore.Text = "SCORE";
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.lblScrambledWord);
            this.Name = "frmGame";
            this.Text = "Game Form";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScrambledWord;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.Timer gameTimer;
    }
}