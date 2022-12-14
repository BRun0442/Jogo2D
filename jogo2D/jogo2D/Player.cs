/*
 * Created by SharpDevelop.
 * User: aluno.etec
 * Date: 08/09/2022
 * Time: 21:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace jogo2D
{
	public class Player : Sprite
	{
		int movSpeedData = 0;
		
		public Player()
		{
			this.hp = 100;
			this.atk = 10;
			this.shield = 0;
			this.speed = 15;
			this.Parent = MainForm.background;
			this.SizeMode = PictureBoxSizeMode.StretchImage;
			this.Load("character_right.gif");	
		}
		
		public void playerMovHorizontal(int movSpeed)
		{				
			if(movSpeed != movSpeedData)
			{
				if(movSpeed == 1)
				{
					this.Load("character_right.gif");
				}else if(movSpeed == -1)
				{
					this.Load("character_left.gif");
				}
			}
			this.Left += speed * movSpeed;
			movSpeedData = movSpeed;
			
			
			if(this.Left >= MainForm.background.Width)
			{
				Level.currentLevel++;
				movSpeedData = 0;
				this.Load("character_right.gif");
				MainForm.background.changeLevel();	
				this.Left = 20;
			}else if(this.Left <= -this.Width)
			{
				Level.currentLevel--;
				movSpeedData = 0;
				this.Load("character_right.gif");
				MainForm.background.changeLevel();
				this.Left = MainForm.background.Width - this.Width - 20;
			}
		}

		public void playerMovVertical(int movSpeed)
		{
			this.Top += speed * movSpeed;
		}
		
		public void fireTrigger()
		{
			Fireball fireball = new Fireball(1);
		}
	}
}
