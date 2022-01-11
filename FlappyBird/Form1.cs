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
    public partial class FlappyBird : Form
    {
        int pipSpeed = 8;
        int gravity = 15;
        int score = 0;
        
        public FlappyBird()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            bird.Top += gravity;
            pipDown.Left -= pipSpeed;
            pipUp.Left -= pipSpeed;
            scoreText.Text = "Score: " + score;

            if (pipDown.Left < -75)
            {
                pipDown.Left = 400;
                score++;
            }

            if (pipUp.Left < -75)
            {
                pipUp.Left = 400;
            }
            if(bird.Bounds.IntersectsWith(pipDown.Bounds) || bird.Bounds.IntersectsWith(pipUp.Bounds) || bird.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
            }

        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text = "Game Over!";
        }

        private void FlappyBird_Load(object sender, EventArgs e)
        {
        }
    }
}
