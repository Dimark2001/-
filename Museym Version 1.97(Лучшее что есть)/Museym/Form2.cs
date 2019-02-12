/*
 * Created by SharpDevelop.
 * User: User
 * Date: 24.01.2019
 * Time: 19:54
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
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
		Thread th;
		public Form2()
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
			Application.Run(new Form3());		
		}
		void Button10Click(object sender, EventArgs e)
		{
			Application.Exit();
		}	
	}
}
