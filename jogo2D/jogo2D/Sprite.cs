/*
 * Created by SharpDevelop.
 * User: aluno.etec
 * Date: 08/09/2022
 * Time: 21:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace jogo2D
{
	public class Sprite : PictureBox
	{
		public int hp;
		public int atk;
		public int shield;
		public int speed;
		
		public Sprite()
		{
			this.BackColor = Color.Transparent;
		}
	}
}
