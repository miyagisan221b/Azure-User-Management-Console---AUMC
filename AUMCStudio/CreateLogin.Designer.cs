namespace AUMCStudio
{
	partial class CreateLogin
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btCreate = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.lbLogin = new System.Windows.Forms.Label();
			this.tbLogin = new System.Windows.Forms.TextBox();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.lbPassword = new System.Windows.Forms.Label();
			this.tbConfirm = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btCreate
			// 
			this.btCreate.Location = new System.Drawing.Point(129, 128);
			this.btCreate.Name = "btCreate";
			this.btCreate.Size = new System.Drawing.Size(75, 23);
			this.btCreate.TabIndex = 0;
			this.btCreate.Text = "Create";
			this.btCreate.UseVisualStyleBackColor = true;
			this.btCreate.Click += new System.EventHandler(this.OnCreate);
			// 
			// button2
			// 
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button2.Location = new System.Drawing.Point(210, 128);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// lbLogin
			// 
			this.lbLogin.AutoSize = true;
			this.lbLogin.Location = new System.Drawing.Point(12, 16);
			this.lbLogin.Name = "lbLogin";
			this.lbLogin.Size = new System.Drawing.Size(36, 13);
			this.lbLogin.TabIndex = 2;
			this.lbLogin.Text = "Login:";
			// 
			// tbLogin
			// 
			this.tbLogin.Location = new System.Drawing.Point(116, 13);
			this.tbLogin.Name = "tbLogin";
			this.tbLogin.Size = new System.Drawing.Size(169, 20);
			this.tbLogin.TabIndex = 3;
			// 
			// tbPassword
			// 
			this.tbPassword.Location = new System.Drawing.Point(115, 51);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.PasswordChar = '●';
			this.tbPassword.Size = new System.Drawing.Size(170, 20);
			this.tbPassword.TabIndex = 5;
			// 
			// lbPassword
			// 
			this.lbPassword.AutoSize = true;
			this.lbPassword.Location = new System.Drawing.Point(12, 54);
			this.lbPassword.Name = "lbPassword";
			this.lbPassword.Size = new System.Drawing.Size(56, 13);
			this.lbPassword.TabIndex = 4;
			this.lbPassword.Text = "Password:";
			// 
			// tbConfirm
			// 
			this.tbConfirm.Location = new System.Drawing.Point(116, 89);
			this.tbConfirm.Name = "tbConfirm";
			this.tbConfirm.PasswordChar = '●';
			this.tbConfirm.Size = new System.Drawing.Size(169, 20);
			this.tbConfirm.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 92);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Confirm Password:";
			// 
			// CreateLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(295, 163);
			this.Controls.Add(this.tbConfirm);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.lbPassword);
			this.Controls.Add(this.tbLogin);
			this.Controls.Add(this.lbLogin);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btCreate);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "CreateLogin";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Create Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btCreate;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label lbLogin;
		private System.Windows.Forms.TextBox tbLogin;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.Label lbPassword;
		private System.Windows.Forms.TextBox tbConfirm;
		private System.Windows.Forms.Label label3;
	}
}