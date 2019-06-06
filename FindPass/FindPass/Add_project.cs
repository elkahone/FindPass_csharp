/*
 * Created by SharpDevelop.
 * User: KucharskiL
 * Date: 21.05.2019
 * Time: 12:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace FindPass
{

	public partial class Add_project : Form
	{
		
		public Add_project()
		{
			InitializeComponent();

		}
# add new project(profile) to the project list
		void AddItemBtnClick(object sender, EventArgs e)
		{	
			string name =  textBox1.Text;
			StreamWriter text = new StreamWriter(@"all_projects_path", true);
			text.WriteLine(name);
			text.Close();
			data_uploader();
			MessageBox.Show("New Item added successfully!");
		}
# create file with the password and login name		
		void data_uploader()
		{
			string name =  textBox1.Text;
			string login = textBox2.Text;
			string password = textBox3.Text;
			string filenameLog = @"credential_path" + name + "Log.txt";
			string filenamePass = @"credential_path" + name + "Pass.txt";
			if (File.Exists(filenameLog))
    		{    
				MessageBox.Show("This object already exist. Please remove it first.");
    		}
			File.WriteAllText(filenameLog, login);
			File.WriteAllText(filenamePass, password);			
		}

	}
}
