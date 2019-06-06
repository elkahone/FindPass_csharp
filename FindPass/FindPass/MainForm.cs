/*
 * Created by SharpDevelop.
 * User: KucharskiL
 * Date: 21.05.2019
 * Time: 11:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace FindPass
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
//path to the local file that contains all listed projects
		string all_projects_path;
//path to the direcotry where are all credential files
		string credential_path;
		public MainForm()
		{
			InitializeComponent();
			update_project_list();
		}
//open form to add new project with credentials to the lsit		
		void AddBtnClick(object sender, EventArgs e)
		{
			Add_project add_project = new Add_project();
			add_project.Show();
		}
//remove an existing profile from database list		
		void RemoveBtnClick(object sender, EventArgs e)
		{
			
			string project_text = comboBox1.Text;
			string old;
			string n = "";
			StreamReader sr = File.OpenText(all_projects_path);
			while ((old = sr.ReadLine()) !=null)
			{
				if(!old.Contains(project_text))
				{
					n += old + Environment.NewLine;
				}
			}
			sr.Close();
			File.WriteAllText(all_projects_path, n);
			File.Delete(@"credential_path" + project_text + "Log.txt");
			File.Delete(@"credential_path" + project_text + "Pass.txt");
			Thread.Sleep(500);
			textBox1.Clear();
			textBox2.Clear();
			comboBox1.Text = "Select logon profile";
			update_project_list();
		}
//update combobox with all existing profiles		
		public void update_project_list()
		{
			comboBox1.Items.Clear();
			var projects = File.ReadAllLines(all_projects_path);
			comboBox1.Items.AddRange(projects);
		}
//run update combobox method		
		void RefreschBtnClick(object sender, EventArgs e)
		{
			update_project_list();
		}
//raise an event when selectig item from combobox		
		void ComboBox1SelectedValueChanged(object sender, EventArgs e)
		{
			string project = comboBox1.SelectedItem.ToString();
			StreamReader sr1 = File.OpenText(@"credentail_path" + project + "Log.txt");
			textBox1.Text = sr1.ReadLine();
			sr1.Close();
			StreamReader sr2 = File.OpenText(@"credentail_path" + project + "Pass.txt");
			textBox2.Text = sr2.ReadLine();
			sr2.Close();
	
		}
//raise events when moving mouse		
		void AddBtnMouseMove(object sender, MouseEventArgs e)
		{
			info.Text = "Add new Logon profile (profiel name, login, password)";
		}
		void AddBtnMouseLeave(object sender, EventArgs e)
		{
			info.Text = "";
		}
		void RemoveBtnMouseMove(object sender, MouseEventArgs e)
		{
			info.Text = "It will remove an existing profile with saved credentials";
		}
		void RemoveBtnMouseLeave(object sender, EventArgs e)
		{
			info.Text = "";
		}
//password generator method		
		public string CreatePassword(int length)
		{
	        string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
	        StringBuilder res = new StringBuilder();
	        Random rnd = new Random();
	        while (0 < length--)
	        {
	            res.Append(valid[rnd.Next(valid.Length)]);
	        }
	        return newpassBox.Text =  res.ToString();
	        
		}
//run create password method		
		void Button1Click(object sender, EventArgs e)
		{
			int i = Convert.ToInt32(textBox3.Text);
			CreatePassword(i);
		}
		void Button2MouseMove(object sender, MouseEventArgs e)
		{
			info.Text = "Set new password for current logon profile";
		}
//update new password to the file
		void ChangePassBtnClick(object sender, EventArgs e)
		{
			string name =  comboBox1.Text;
			string password = textBox2.Text;
			File.Delete(@"credentailpath" + name + "Pass.txt");
			string filenamePass = @"credential_path" + name + "Pass.txt";
			File.WriteAllText(filenamePass, password);
			MessageBox.Show("Password has been updated!");
		} 

	}
}
