/*
 * Created by SharpDevelop.
 * User: User
 * Date: 25.01.2019
 * Time: 20:29
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
	/// Description of Guide3.
	/// </summary>
	public partial class Guide3 : Form
	{
		Thread th;
		public Guide3()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
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
			th = new Thread(open3);
			th.SetApartmentState(ApartmentState.STA);
			th.Start();
		}
		public void open3(object obj)
		{
			Application.Run(new Guide4());		
		}
		
	}
}
