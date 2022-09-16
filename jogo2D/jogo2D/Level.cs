using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace jogo2D
{
	/// <summary>
	/// Description of level.
	/// </summary>
	public class Level : PictureBox
	{
		public int currentLevel = 1;
		public Level()
		{
			this.SizeMode = PictureBoxSizeMode.StretchImage;
			this.Load("initalScene.jpg");
		}
		
		
		public void changeLevel(int currentLevel)
		{
			this.currentLevel = currentLevel;
			switch(currentLevel)
			{
				case 1:
					this.Load("background.jpg");
				break;
				case 2:
					this.Load("backgroundEgito.jpg");
				break;
				
				default:
					this.Load("initialScene.jpg");
				break;
			}
		}
	}
}