using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Matricis.SqlAzure.Queries;

namespace AUMCStudio
{
	public partial class CreateLogin : Form
	{
		public CreateLogin()
		{
			InitializeComponent();
		}

		public string LoginName { get; private set; }

		private void OnCreate(object sender, EventArgs e)
		{
			if (String.IsNullOrWhiteSpace(tbLogin.Text))
			{
				MessageBox.Show("You must specify a login name.", "Create Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (String.IsNullOrWhiteSpace(tbPassword.Text))
			{
				MessageBox.Show("You must specify a password.", "Create Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (tbPassword.Text != tbConfirm.Text)
			{
				MessageBox.Show("The password don't match.", "Create Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			try
			{
				LoginQueries.CreateLogin(LoginInformation.Server, LoginInformation.User, LoginInformation.Password, tbLogin.Text, tbPassword.Text);

				LoginName = tbLogin.Text;
				this.DialogResult = System.Windows.Forms.DialogResult.OK;
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Create Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
