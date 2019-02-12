/*
 * Created by SharpDevelop.
 * User: User
 * Date: 25.01.2019
 * Time: 19:24
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
	/// Description of Guide4.
	/// </summary>
	public partial class Guide4 : Form
	{
		Thread th;
		public Guide4()
		{
			InitializeComponent();
		}
		void Button1Click(object sender, EventArgs e)
		{
			this.Close();
			th = new Thread(open1);
			th.SetApartmentState(ApartmentState.STA);
			th.Start();
		}
		public void open1(object obj)
		{
			Application.Run(new MainForm());		
		}
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		void Guide1Load(object sender, EventArgs e)
		{
	
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
