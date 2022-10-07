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
		
		public Fireball()
		{
			Random r = new Random();
			
			this.BackColor = Color.Transparent;
			this.Parent = MainForm.background;
			this.SizeMode = PictureBoxSizeMode.StretchImage;
			this.Left = MainForm.background.Width - 50;
			this.Top = r.Next(0, MainForm.background.Width);
			this.Load("fireball.gif");	
		}
	}
}
