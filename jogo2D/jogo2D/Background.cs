/*
 * Created by SharpDevelop.
 * User: Aluno Etec
 * Date: 09/09/2022
 * Time: 08:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace jogo2D
{
	public class Background : PictureBox
	{
		public Background()
		{
			this.SizeMode = PictureBoxSizeMode.StretchImage;
		}
		
		public void sceneChange(int level)
		{
			switch(level)
			{
				case 1:
					this.Load("background.jpg");
				break;
				case 2:
					this.Load("background2.jpg");
				break;
				
				default:
					this.Load("initalScene.jpg");
				break;
			}
		}
	}
}
