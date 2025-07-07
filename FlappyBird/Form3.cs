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
	public partial class Form3 : Form
	{
		public Form3(string score)
		{
			InitializeComponent();
			this.score = score;
			scoreText.Text = "" + score;
		}
		string score;
		private void button3_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form1 f = new Form1();
			f.Show();
			Hide();
		}

	}
}
