/*
 * Created by SharpDevelop.
 * User: User
 * Date: 24.01.2019
 * Time: 19:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
namespace Museym
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Thread th;
		public MainForm()
		{		  
			InitializeComponent();
		}
		void Button4Click(object sender, EventArgs e)
		{
			this.Close();
			th = new Thread(open);
			th.SetApartmentState(ApartmentState.STA);
			th.Start();
		}
		public void open(object obj)
		{
			Application.Run(new Form1());		
		}
		void Button2Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("http://museum141.tilda.ws/");
		}
		void Button3Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("http://xn--141-5cd3cgu2f.xn--80acgfbsl1azdqr.xn--p1ai/");				
		}
		void Button1Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void Button5Click(object sender, EventArgs e)
		{
			this.Close();
			th = new Thread(open1);
			th.SetApartmentState(ApartmentState.STA);
			th.Start();
		}
		public void open1(object obj)
		{
			Application.Run(new Guide1());		
		}
	}
}
