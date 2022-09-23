﻿/*
 * Created by SharpDevelop.
 * User: gamer
 * Date: 03/09/2022
 * Time: 16:01
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
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public static Level background = new Level();
		Player player = new Player();
		
		public MainForm()
		{
			InitializeComponent();
			button1.BackColor = Color.Transparent;
			button1.Parent = this;
			button1.Left = (this.Width - button1.Width)/2;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			this.KeyPreview = true;
			button1.Visible = false;
			button1.Enabled = false;

			background.Parent = this;
			background.Width = this.Width;
			background.Height = this.Height - 100;
			
			player.Width = 76;
			player.Height = 150;
			player.Left = 20;
			player.Top = 300;
		}
		
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			if((e.KeyCode == Keys.A || e.KeyCode == Keys.Left))
				player.playerMovHorizontal(-1);
			
			if(Level.lastLevel == Level.currentLevel)
			{
				if((e.KeyCode == Keys.D || e.KeyCode == Keys.Right) && ((player.Left + player.Width) < (background.Width - player.Width))){
					player.playerMovHorizontal(1);
				}
			}else{
				if((e.KeyCode == Keys.D || e.KeyCode == Keys.Right))
				{
					player.playerMovHorizontal(1);
				}
			}
			
			if((e.KeyCode == Keys.S || e.KeyCode == Keys.Down) && player.Top + player.Height <= background.Height)   
				player.playerMovVertical(1);
			
			if((e.KeyCode == Keys.W || e.KeyCode == Keys.Up) && player.Top >= 0)     
				player.playerMovVertical(-1);
		}
	}
}
