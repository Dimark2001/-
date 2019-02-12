/*
 * Created by SharpDevelop.
 * User: User
 * Date: 24.01.2019
 * Time: 19:32
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
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		Thread th;
		public Form1()
		{
			InitializeComponent();
		}
		void Button10Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

	 	void Button1Click(object sender, EventArgs e)
		{
			this.Close();
			th = new Thread(open);
			th.SetApartmentState(ApartmentState.STA);
			th.Start();}
		
		public void open(object obj)
		{
			Application.Run(new Form2());		
		}
	}
}

