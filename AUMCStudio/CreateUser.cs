using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Matricis.SqlAzure.Queries;
using Matricis.SqlAzure.Entities;

namespace AUMCStudio
{
	public partial class CreateUser : Form
	{
		public CreateUser(string currentDB)
		{
			InitializeComponent();

			var logins = LoginQueries.GetLogins(LoginInformation.Server, LoginInformation.User, LoginInformation.Password);
			cbLogins.Items.AddRange(logins.ToArray());

			CurrentDatabase = currentDB;

			if (CurrentDatabase == "master")
			{
				clbRoles.Items.Add("loginmanager");
				clbRoles.Items.Add("dbmanager");
			}
			else
			{
				clbRoles.Items.Add("db_owner");
				clbRoles.Items.Add("db_securityadmin");
				clbRoles.Items.Add("db_accessadmin");
				clbRoles.Items.Add("db_backupoperator");
				clbRoles.Items.Add("db_ddladmin");
				clbRoles.Items.Add("db_datawriter");
				clbRoles.Items.Add("db_datareader");
				clbRoles.Items.Add("db_denydatawriter");
				clbRoles.Items.Add("db_denydatareader");
			}
		}

		public string CurrentDatabase 
		{ 
			get; 
			private set; 
		}

		public string UserName { get; private set; }

		private void OnCreate(object sender, EventArgs e)
		{
			if (cbLogins.SelectedIndex == -1)
			{
				MessageBox.Show("You must select a login name.", "Create User Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (String.IsNullOrWhiteSpace(tbUser.Text))
			{
				MessageBox.Show("You must specify a user name.", "Create User Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			try
			{
				DatabaseQueries.CreateUser(LoginInformation.Server, CurrentDatabase, LoginInformation.User, LoginInformation.Password, tbUser.Text, ((Login)cbLogins.SelectedItem).Name);

				foreach (var item in clbRoles.CheckedItems)
				{
					DatabaseQueries.GrantRole(LoginInformation.Server, CurrentDatabase, LoginInformation.User, LoginInformation.Password, tbUser.Text, (string)item);
				}

				UserName = tbUser.Text;
				this.DialogResult = System.Windows.Forms.DialogResult.OK;
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Create User Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
