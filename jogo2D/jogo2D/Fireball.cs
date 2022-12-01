/*
 * Created by SharpDevelop.
 * User: aluno.etec
 * Date: 06/10/2022
 * Time: 22:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace jogo2D
{
	/// <summary>
	/// Description of Fireball.
	/// </summary>
	public class Fireball : PictureBox
	{
		public int damage = 15;
		public int movVel = 15;
		public int attackFireRate = 100;
		public int direction = 0;
		
		Timer timer = new Timer();
		
		//Contém esse parametro pois se trata da direção do disparo, se for positivo ele irá para a esquerda
		//se negativo, irá da direita para esquerda
		public Fireball(int direction)
		{
			Random r = new Random();
			this.direction = direction;
			
			this.BackColor = Color.Transparent;
			this.Parent = MainForm.background;
			this.SizeMode = PictureBoxSizeMode.StretchImage;

			timer.Enabled = true;
			
			if(direction >= 1)
			{
				this.Load("fireballRight.gif");
				this.Left = MainForm.player.Left;
				this.Top = MainForm.player.Top;
				timer.Interval = attackFireRate;
				timer.Tick += movementPlayer;
			}else{
				this.Load("fireballLeft.gif");
				this.Left = MainForm.background.Width - 50;
				this.Top = r.Next(0, MainForm.background.Width);
				timer.Interval = attackFireRate;
				timer.Tick += movementEnemy;
			}
		}
		
		public void movementEnemy(object sender, EventArgs e)
		{			
			this.Left -= movVel;
			movVel += 3;
			
			if(this.Left <= -this.Width)
			{
				this.timer.Enabled = false;
				this.Dispose();
			}
		}
		
		public void movementPlayer(object sender, EventArgs e)
		{			
			this.Left += movVel;
			movVel += 10;
			
			if(this.Left >= MainForm.background.Width)
			{
				this.timer.Enabled = false;
				this.Dispose();
			}
		}
	}
}
