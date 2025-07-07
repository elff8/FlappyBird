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
		int pipeSpeed = 8;
		int gravity = 5;
		int score = 0;
		public Form1()
		{
			InitializeComponent();

		}

		private void gameTimerEvent(object sender, EventArgs e)
		{
			flappyBird.Top += gravity;//чтобы птичка паала
			pipeBottom.Left -= pipeSpeed;
			pipeTop.Left -= pipeSpeed;
			scoreText.Text = "Score:" + score;
			if (pipeBottom.Left < -150)//условие чтобы появлялись столбы
			{
				pipeBottom.Left = 800; //чтобы появилялись за картой
				score++;
			}
			if (pipeTop.Left < -180)
			{
				pipeTop.Left = 950;
				score++;
			}
			if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
				flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
				flappyBird.Bounds.IntersectsWith(ground.Bounds) ||
				flappyBird.Top < -25)
			{
				endGame();
			}
			if (score > 10)
			{
				//pipeSpeed = 15;
			}
			//if (flappyBird.Top < -25)//если птичка улетает вверх 
			//{
			//	endGame();
			//}
		}

		private void gamekeyisdown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Space)
			{
				gravity = -15;
			}
		}

		private void gamekeyisup(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Space) //без условия будет улетать наверх
			{
				gravity = 15;
			}
			//if (e.KeyCode == Keys.R && gameOver)
			//{
			//	RestartGame();
			//}
		}

		private void endGame()
		{
			gameTimer.Stop();
			//gameOver = true;
			Form3 f = new Form3(this.scoreText.Text);
			f.Show();
			Hide();
		}

	
		//private void RestartGame()
		//{
		//	gameOver = false;
		//	flappyBird.Location = new Point(56, 233);
		//	pipeTop.Left = 800;
		//	pipeBottom.Left = 1200;
		//	score = 0;
		//	pipeSpeed = 8;
		//	scoreText.Text = "";
		//	gameTimer.Start();

		//}
	}
}
