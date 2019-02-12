/*
 * Created by SharpDevelop.
 * User: User
 * Date: 25.01.2019
 * Time: 14:49
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
	/// Description of Form4.
	/// </summary>
	public partial class Form4 : Form
	{
		Thread th;
		public Form4()
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
			Application.Run(new Form5());		
		}
		void Button10Click(object sender, EventArgs e)
		{
			Application.Exit();
		}		
	}
}
