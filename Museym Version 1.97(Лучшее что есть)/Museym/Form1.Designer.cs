/*
 * Created by SharpDevelop.
 * User: User
 * Date: 24.01.2019
 * Time: 19:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Museym
{
	partial class Form1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button1;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.button10 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Location = new System.Drawing.Point(12, 881);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1896, 99);
			this.label1.TabIndex = 6;
			this.label1.Text = "Вы очнулись в подозрительно тёмной комнате...\r\nИ конечно ничего не увидели!";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// button10
			// 
			this.button10.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.button10.BackColor = System.Drawing.Color.Transparent;
			this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button10.ForeColor = System.Drawing.Color.Maroon;
			this.button10.Location = new System.Drawing.Point(1748, 1000);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(157, 26);
			this.button10.TabIndex = 16;
			this.button10.Text = "Выход";
			this.button10.UseVisualStyleBackColor = false;
			this.button10.Click += new System.EventHandler(this.Button10Click);
			// 
			// button1
			// 
			this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.Color.Maroon;
			this.button1.Location = new System.Drawing.Point(844, 984);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(232, 26);
			this.button1.TabIndex = 17;
			this.button1.Text = "Продолжить";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1920, 1080);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}
	}
}
