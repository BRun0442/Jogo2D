/*
 * Created by SharpDevelop.
 * User: 
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
	public partial class MainForm : Form
	{
		//Instancia as classes do fundo e do jogador
		public static Level background = new Level();
		Player player = new Player();
		int initialPlayerPosY = 300;
		int initialPlayerPosX = 20;
		
//		Image image = Image.FromFile("SampImag.jpg");
//		PictureBox initialFloatingSprite = new PictureBox();
		
		public MainForm()
		{
			InitializeComponent();
			
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			
			button1.BackColor = Color.Transparent;
			button1.Parent = this;
			button1.Left = (this.Width - button1.Width)/2;
			
//			initialSceneBg.Load("background3.jpg");
//			initialSceneBg.Width = this.Width;
//			initialSceneBg.Height = this.Height;
			
			spriteInicialScene.Load("character_right.gif");
			spriteInicialScene.BackColor = Color.Transparent;
			spriteInicialScene.Width = 152;
			spriteInicialScene.Height = 300;
			spriteInicialScene.Parent = this;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			this.BackgroundImage = null;
			spriteInicialScene.Visible = false;
			
			timer1.Enabled = true;
			
			//Configura o botão como invisível e desabilita o mesmo
			this.KeyPreview = true;
			button1.Visible = false;
			button1.Enabled = false;

			//Ajusta o background de acordo com a tela e deixa um espaço para a UI do player
			background.Parent = this;
			background.Width = this.Width;
			background.Height = this.Height - 150;
			
			//Ajusta a pictureBox do player e sua posição inicial em relação à origin (0, 0)
			player.Width = 76;
			player.Height = 150;
			player.Left = initialPlayerPosX;
			player.Top = initialPlayerPosY;
		}
		
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			//Caso seja o primeiro level (primeira tela), o jogador não consegue recuar 
			//pois não há nenhuma tela antes dessa
			if(Level.currentLevel == 0)
			{
				if((e.KeyCode == Keys.A || e.KeyCode == Keys.Left) && (player.Left > 0))
				{
					player.playerMovHorizontal(-1);
				}
			}else{
				if((e.KeyCode == Keys.A || e.KeyCode == Keys.Left))
				{
					player.playerMovHorizontal(-1);
				}
			}
			
			
			//Caso seja o ultimo level (ultima tela), o jogador não consegue avançar 
			//pois não há nenhuma tela depois dessa
			if(Level.currentLevel == Level.lastLevel)
			{
				if((e.KeyCode == Keys.D || e.KeyCode == Keys.Right) && 
				  ((player.Left + player.Width) < background.Width))
					player.playerMovHorizontal(1);
			}else
			{
				if((e.KeyCode == Keys.D || e.KeyCode == Keys.Right))
					player.playerMovHorizontal(1);
			}
			
			
			//Só podera se mover para baixo até chegar na borda da UI
			if((e.KeyCode == Keys.S || e.KeyCode == Keys.Down) && 
			   player.Top + player.Height <= background.Height)
				player.playerMovVertical(1);
			
			
			//Só poderá se mover para cima caso sua posição seja maior que zero (origin da tela)
			if((e.KeyCode == Keys.W || e.KeyCode == Keys.Up) && player.Top >= 0)     
				player.playerMovVertical(-1);
		}
		
		
		void Timer1Tick(object sender, EventArgs e)
		{
			Fireball bolaFogo = new Fireball();
			bolaFogo.Left += 50;
		}
	}
}
