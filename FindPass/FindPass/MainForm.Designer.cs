/*
 * Created by SharpDevelop.
 * User: KucharskiL
 * Date: 21.05.2019
 * Time: 11:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace FindPass
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button RemoveBtn;
		private System.Windows.Forms.Button AddBtn;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button RefreschBtn;
		private System.Windows.Forms.Label info;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox newpassBox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button ChangePassBtn;
		private System.Windows.Forms.Label label4;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.RemoveBtn = new System.Windows.Forms.Button();
			this.AddBtn = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.RefreschBtn = new System.Windows.Forms.Button();
			this.info = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.newpassBox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.ChangePassBtn = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// RemoveBtn
			// 
			this.RemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.RemoveBtn.Location = new System.Drawing.Point(72, 22);
			this.RemoveBtn.Name = "RemoveBtn";
			this.RemoveBtn.Size = new System.Drawing.Size(56, 23);
			this.RemoveBtn.TabIndex = 0;
			this.RemoveBtn.Text = "Remove";
			this.RemoveBtn.UseCompatibleTextRendering = true;
			this.RemoveBtn.UseVisualStyleBackColor = true;
			this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtnClick);
			this.RemoveBtn.MouseLeave += new System.EventHandler(this.RemoveBtnMouseLeave);
			this.RemoveBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RemoveBtnMouseMove);
			// 
			// AddBtn
			// 
			this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.AddBtn.Location = new System.Drawing.Point(134, 22);
			this.AddBtn.Name = "AddBtn";
			this.AddBtn.Size = new System.Drawing.Size(44, 23);
			this.AddBtn.TabIndex = 1;
			this.AddBtn.Text = "Add";
			this.AddBtn.UseVisualStyleBackColor = true;
			this.AddBtn.Click += new System.EventHandler(this.AddBtnClick);
			this.AddBtn.MouseLeave += new System.EventHandler(this.AddBtnMouseLeave);
			this.AddBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddBtnMouseMove);
			// 
			// comboBox1
			// 
			this.comboBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(12, 53);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(166, 21);
			this.comboBox1.TabIndex = 2;
			this.comboBox1.Text = "Select logon profile";
			this.comboBox1.SelectedValueChanged += new System.EventHandler(this.ComboBox1SelectedValueChanged);
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.textBox1.Location = new System.Drawing.Point(264, 53);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(145, 20);
			this.textBox1.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(264, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Password:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.textBox2.Location = new System.Drawing.Point(264, 107);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(145, 20);
			this.textBox2.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(264, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 7;
			this.label1.Text = "Login:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// RefreschBtn
			// 
			this.RefreschBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.RefreschBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RefreschBtn.BackgroundImage")));
			this.RefreschBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.RefreschBtn.Location = new System.Drawing.Point(184, 47);
			this.RefreschBtn.Name = "RefreschBtn";
			this.RefreschBtn.Size = new System.Drawing.Size(36, 33);
			this.RefreschBtn.TabIndex = 8;
			this.RefreschBtn.UseVisualStyleBackColor = false;
			this.RefreschBtn.Click += new System.EventHandler(this.RefreschBtnClick);
			// 
			// info
			// 
			this.info.Location = new System.Drawing.Point(12, 219);
			this.info.Name = "info";
			this.info.Size = new System.Drawing.Size(410, 23);
			this.info.TabIndex = 9;
			this.info.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.newpassBox);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Location = new System.Drawing.Point(13, 86);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 115);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "password generator";
			// 
			// newpassBox
			// 
			this.newpassBox.Location = new System.Drawing.Point(7, 77);
			this.newpassBox.Name = "newpassBox";
			this.newpassBox.Size = new System.Drawing.Size(144, 20);
			this.newpassBox.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(7, 47);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Create";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(36, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 1;
			this.label3.Text = "password Length";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(7, 20);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(22, 20);
			this.textBox3.TabIndex = 0;
			// 
			// ChangePassBtn
			// 
			this.ChangePassBtn.Location = new System.Drawing.Point(264, 163);
			this.ChangePassBtn.Name = "ChangePassBtn";
			this.ChangePassBtn.Size = new System.Drawing.Size(67, 23);
			this.ChangePassBtn.TabIndex = 11;
			this.ChangePassBtn.Text = "Set";
			this.ChangePassBtn.UseVisualStyleBackColor = true;
			this.ChangePassBtn.Click += new System.EventHandler(this.ChangePassBtnClick);
			this.ChangePassBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Button2MouseMove);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(264, 134);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 12;
			this.label4.Text = "Change password";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(434, 251);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.ChangePassBtn);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.info);
			this.Controls.Add(this.RefreschBtn);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.AddBtn);
			this.Controls.Add(this.RemoveBtn);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "FindPass";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
