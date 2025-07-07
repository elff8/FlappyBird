﻿
namespace FlappyBird
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.flappyBird = new System.Windows.Forms.PictureBox();
			this.pipeBottom = new System.Windows.Forms.PictureBox();
			this.pipeTop = new System.Windows.Forms.PictureBox();
			this.ground = new System.Windows.Forms.PictureBox();
			this.scoreText = new System.Windows.Forms.Label();
			this.gameTimer = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
			this.SuspendLayout();
			// 
			// flappyBird
			// 
			this.flappyBird.BackColor = System.Drawing.Color.Transparent;
			this.flappyBird.Image = global::FlappyBird.Properties.Resources.bird;
			this.flappyBird.Location = new System.Drawing.Point(56, 233);
			this.flappyBird.Name = "flappyBird";
			this.flappyBird.Size = new System.Drawing.Size(78, 62);
			this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.flappyBird.TabIndex = 0;
			this.flappyBird.TabStop = false;
			// 
			// pipeBottom
			// 
			this.pipeBottom.BackColor = System.Drawing.Color.Transparent;
			this.pipeBottom.Image = global::FlappyBird.Properties.Resources.pipe;
			this.pipeBottom.Location = new System.Drawing.Point(337, 384);
			this.pipeBottom.Name = "pipeBottom";
			this.pipeBottom.Size = new System.Drawing.Size(100, 235);
			this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pipeBottom.TabIndex = 1;
			this.pipeBottom.TabStop = false;
			// 
			// pipeTop
			// 
			this.pipeTop.BackColor = System.Drawing.Color.Transparent;
			this.pipeTop.Image = global::FlappyBird.Properties.Resources.pipedown;
			this.pipeTop.Location = new System.Drawing.Point(501, -5);
			this.pipeTop.Name = "pipeTop";
			this.pipeTop.Size = new System.Drawing.Size(100, 197);
			this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pipeTop.TabIndex = 2;
			this.pipeTop.TabStop = false;
			// 
			// ground
			// 
			this.ground.Image = global::FlappyBird.Properties.Resources.ground;
			this.ground.Location = new System.Drawing.Point(-10, 609);
			this.ground.Name = "ground";
			this.ground.Size = new System.Drawing.Size(658, 75);
			this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ground.TabIndex = 3;
			this.ground.TabStop = false;
			// 
			// scoreText
			// 
			this.scoreText.AutoSize = true;
			this.scoreText.BackColor = System.Drawing.Color.Transparent;
			this.scoreText.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.scoreText.Location = new System.Drawing.Point(12, 19);
			this.scoreText.Name = "scoreText";
			this.scoreText.Size = new System.Drawing.Size(136, 23);
			this.scoreText.TabIndex = 4;
			this.scoreText.Text = "score:  0";
			// 
			// gameTimer
			// 
			this.gameTimer.Enabled = true;
			this.gameTimer.Interval = 20;
			this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleTurquoise;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(613, 665);
			this.Controls.Add(this.scoreText);
			this.Controls.Add(this.flappyBird);
			this.Controls.Add(this.ground);
			this.Controls.Add(this.pipeTop);
			this.Controls.Add(this.pipeBottom);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Flappy Bird";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
			((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox flappyBird;
		private System.Windows.Forms.PictureBox pipeBottom;
		private System.Windows.Forms.PictureBox pipeTop;
		private System.Windows.Forms.PictureBox ground;
		private System.Windows.Forms.Label scoreText;
		private System.Windows.Forms.Timer gameTimer;
	}
}

