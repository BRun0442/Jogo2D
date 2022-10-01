/*
 * Created by SharpDevelop.
 * User: gamer
 * Date: 03/09/2022
 * Time: 16:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace jogo2D
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox spriteInicialScene;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.button1 = new System.Windows.Forms.Button();
			this.spriteInicialScene = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.spriteInicialScene)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.button1.AutoSize = true;
			this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.Color.Transparent;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(114, 112);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(474, 156);
			this.button1.TabIndex = 0;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// spriteInicialScene
			// 
			this.spriteInicialScene.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.spriteInicialScene.Location = new System.Drawing.Point(268, 12);
			this.spriteInicialScene.Name = "spriteInicialScene";
			this.spriteInicialScene.Size = new System.Drawing.Size(100, 124);
			this.spriteInicialScene.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.spriteInicialScene.TabIndex = 1;
			this.spriteInicialScene.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(704, 344);
			this.Controls.Add(this.spriteInicialScene);
			this.Controls.Add(this.button1);
			this.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
			this.Text = "jogo2D";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			((System.ComponentModel.ISupportInitialize)(this.spriteInicialScene)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
