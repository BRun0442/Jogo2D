using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace jogo2D
{
	public class Level : PictureBox
	{
		public static int currentLevel = 0;
		public static int lastLevel = 4;
		public Level()
		{
			this.SizeMode = PictureBoxSizeMode.StretchImage;
			changeLevel();
		}
		
		
		public void changeLevel()
		{
			switch(currentLevel)
			{
				case 1:
					this.Load("background1.jpg");
					break;
					
				case 2:
					this.Load("background2.jpg");
					break;
					
				case 3:
					this.Load("background3.jpg");
					break;
				
				case 4:
					this.Load("background4.jpg");
					break;
					
				default:
					this.Load("background0.jpg");
					break;
			}
		}
	}
}