using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_Rex_Game_Runner
{
    public partial class Form1 : Form
    {
        bool jumping = false;
        int jumpSpeed;
        int force = 7;
        int score = 0;
        int obstacleSpeed = 10;
        Random rand = new Random();
        int position;
        bool isGameOver = false;
           
        public Form1()
        {
            InitializeComponent();
            GameReset();
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            trex.Top += jumpSpeed;
            txtScore.Text = "Score:" + score;

            if (jumping == true && force < 0)
            {
                jumping = false;
            }

            if (jumping == true)
            {
                jumpSpeed = -14;
                force -= 1;
            }

            else
            {
                jumpSpeed = 14;
            }

            if (trex.Top == 365 && jumping == false)
            {
                force = 7;
                trex.Top = 365;
                jumpSpeed = 0;
            }

            foreach(Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= obstacleSpeed;

                    if (x.Left < -100)
                    {
                        x.Left = this.ClientSize.Width + rand.Next(100, 1000) + (x.Width * 15);
                        score++;
                    }

                    if (trex.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameTimer.Stop();
                        txtScore.Text = "";
                        txtEndScore.Text = "Игра окончена. Счет: " + score;
                        txtEndScore.Visible = true;
                        btnReset.Visible = true;
                        isGameOver = true;
                    }
                }
            }

            if (score > 10)
            {
                obstacleSpeed = 13;
            }

            if (score > 20)
            {
                obstacleSpeed = 16;
            }

            if (score > 30)
            {
                obstacleSpeed = 20;
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (jumping == true)
            {
                jumping = false;
            }
        }

        private void GameReset()
        {
            jumping = false;
            jumpSpeed = 0;
            force = 7;
            score = 0;
            obstacleSpeed = 10;
            txtScore.Text = "Счет: " + score;
            txtEndScore.Visible = false;
            btnReset.Visible = false;
            trex.Image = Properties.Resources.running;
            isGameOver = false;
            trex.Top = 365;

            foreach (Control x in this.Controls)
            {
               if (x is PictureBox && (string)x.Tag == "obstacle")
               {
                    position = this.ClientSize.Width + rand.Next(100, 1000) + (x.Width * 15);
                    x.Left = position;
               }
            }
            gameTimer.Start();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            GameReset();
        }
    }
}
