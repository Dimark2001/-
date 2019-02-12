/*
 * Created by SharpDevelop.
 * User: User
 * Date: 24.01.2019
 * Time: 21:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
namespace Museym
{
	/// <summary>
	/// Description of Form5.
	/// </summary>
	public partial class Form5 : Form
	{
		Thread th;
		public Form5()
		{
			InitializeComponent();
		}
		void Button1Click(object sender, EventArgs e)
		{
			this.Close();
			th = new Thread(open);
			th.SetApartmentState(ApartmentState.STA);
			th.Start();
		}
		public void open(object obj)
		{
			Application.Run(new MainForm());		
		}
		void Button10Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void Button3Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
			th = new Thread(open2);
			th.SetApartmentState(ApartmentState.STA);
			th.Start();
		}
		public void open2(object obj)
		{
			Application.Run(new MainForm());
		}

		
	}
}
