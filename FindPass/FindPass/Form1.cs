/*
 * Created by SharpDevelop.
 * User: KucharskiL
 * Date: 23.05.2019
 * Time: 18:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FindPass
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{

			InitializeComponent();

		}
		void Button1Click(object sender, EventArgs e)
		{
			string pass = "elkahone1";
			string goodpass = passbox.Text;
			if(goodpass == pass) {
				this.timer1.Start();
			} else {DialogResult ok = MessageBox.Show("Please provide correct password!");
				if(ok == DialogResult.OK) {
					passbox.Clear();
				}			}
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			progressBar1.Maximum = 100;
			this.progressBar1.Increment(1);
			if(progressBar1.Value == progressBar1.Maximum){
			this.timer1.Stop();
			this.Hide();				
			MainForm mainform = new MainForm();
			mainform.Show();
			}

			
		}
	}
}
