using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project___Word_Scramble
{
    public partial class frmGame : Form
    {
        //Variables for the whole form
        List<string> remainingWords = new List<string>
        { "KNOWLEDGE", "ADVENTURE", "MYSTERIOUS" };
        List<string> remainingHints = new List<string>
        { "Something you gain by studying", "An exciting experience", "Hard to understand or explane" };

        int currenIndex;
        int score = 0;
        int timeleft = 30;
        Random rand = new Random();
        int questionCount = 0;
        int maxQuestions = 3;

        //Function to scramble a word
        string ScrambleWord(string word)
        {
            char[] chars = word.ToCharArray();
            for(int i = chars.Length - 1;i>0;i--)
            {
                int j = rand.Next(i + 1);
                char temp = chars[i];
                chars[i] = chars[j];
                chars[j] = temp;
            }
            return new string(chars);
        }

        //Load a new word for the game 
        void LoadNewWord()
        {
            if(questionCount>=maxQuestions || remainingWords.Count == 0) 
            {
                lblMessage.Text = "Game Over! Final Score : " + score;

            currenIndex = rand.Next(words.Length);//OK
            lblScrambledWord.Text= ScrambleWord(words[currenIndex]);
            lblHint.Text = hints[currenIndex];
            txtAnswer.Text = "";
            lblMessage.Text = "";
            timeleft = 30;
            lblTimer.Text = "Time Left : " + timeleft;
        }

        public frmGame()
        {
            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            LoadNewWord();
            gameTimer.Start();//Timer Interval should be 1000ms
        }



        private void lblHint_Click(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if(txtAnswer.Text.ToUpper() == words[currenIndex])
            {
                lblMessage.Text = "Correct!";
                score += 1;
                lblScore.Text = "Score : " + score;
                LoadNewWord();
            }
            else
            {
                lblMessage.Text = "Try Again!";
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lblScrambledWord.Text = ScrambleWord(words[currenIndex]);
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            timeleft--;//Decrease timeleft by 1 second
            lblTimer.Text = "Time Left : " + timeleft;

            if(timeleft <=0)
            {
                lblMessage.Text = "Time's up!";
                LoadNewWord();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
