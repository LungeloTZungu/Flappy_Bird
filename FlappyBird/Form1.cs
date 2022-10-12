using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int pipespeed = 8;
        int gravity = 12;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity; // Moving the bird down using the initail gravity var 
            pipeBottom.Left -= pipespeed; // moving pipes toward the left using the pipe speed var 
            pipeTop.Left -= pipespeed;
            ScoreText.Text = "Score:" + score; // updating the score 
            if(pipeBottom.Left < -150) // condition to make sure the pipes will continaully appear 
            {
                pipeBottom.Left = 900;
                score++;
            }

            if (pipeTop.Left< -180) // condition to make sure the pipes will continaully appear 
            {
                pipeTop.Left = 1050;
                score++;
            }

            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) || flappyBird.Bounds.IntersectsWith(pipeTop.Bounds)
                || flappyBird.Bounds.IntersectsWith(Ground.Bounds)) // conditions to trigger tbhe end game function if the bird touches the pipes or the ground 
            {
                EndGame();     
            }

           if (score > 5) // if players goes above the score of 5 the speed of the game will increase to make it more difficult 
            {
                pipespeed = 15;
            }
           if (score > 10) // if players goes above the score of 10  the speed of the game will increase to make it more difficult
            {
                pipespeed = 20;
            }

           if (flappyBird.Top < -25) // if players tries to glitch the game and goes all thw way up the game will end
            {
                EndGame(); // function to end the game 
            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -12;
            }

        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 12;
            }
        }
        private void EndGame() // function to end the game 
        {
            gameTimer.Stop(); // stops the timer 
            ScoreText.Text += "        Game Over!!!"; // tells user that game is over
        }
    }
}
