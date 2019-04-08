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
	public partial class EditPermission : Form
	{
		public EditPermission(string currentDB, string username)
		{
			InitializeComponent();

			CurrentDatabase = currentDB;
			UserName = username;

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

		public string UserName { get; set; }

		private void OnEdit(object sender, EventArgs e)
		{
			try
			{
				for (int i = 0; i < clbRoles.Items.Count; i++) 
				{
					if (clbRoles.GetItemChecked(i))
					{
						DatabaseQueries.GrantRole(LoginInformation.Server, CurrentDatabase, LoginInformation.User, LoginInformation.Password, UserName, (string)clbRoles.Items[i]);
					}
					else
					{
						DatabaseQueries.DropRole(LoginInformation.Server, CurrentDatabase, LoginInformation.User, LoginInformation.Password, UserName, (string)clbRoles.Items[i]);
					}
				}

				this.DialogResult = System.Windows.Forms.DialogResult.OK;
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Create User Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void EditPermission_Load(object sender, EventArgs e)
		{
			try
			{
				var roles = DatabaseQueries.GetUseRoles(LoginInformation.Server, CurrentDatabase, LoginInformation.User, LoginInformation.Password, UserName);
				foreach (var role in roles)
				{
					for (int i = 0; i < clbRoles.Items.Count; i++) 
					{
						if((string)clbRoles.Items[i] == role.Name)
						{
							clbRoles.SetItemChecked(i, true);
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				btEdit.Enabled = false;
			}
		}
	}
}
