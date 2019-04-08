using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Matricis.SqlAzure.Queries;

namespace AUMCStudio
{
	public partial class DatabaseUsersView : UserControl
	{
		public DatabaseUsersView()
		{
			InitializeComponent();
		}

		public string CurrentDatabase { get; private set; }

		public void RefreshView(string currentDB)
		{
			CurrentDatabase = currentDB;

			lstUsers.Items.Clear();

			try
			{
				var users = DatabaseQueries.GetUsers(LoginInformation.Server, CurrentDatabase, LoginInformation.User, LoginInformation.Password);
				foreach (var item in users)
				{
					lstUsers.Items.Add(item.Name, 0);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void OnCreateUser(object sender, EventArgs e)
		{
			try
			{
				using (CreateUser dlg = new CreateUser(CurrentDatabase))
				{
					if (dlg.ShowDialog() == DialogResult.OK)
					{
						lstUsers.Items.Add(dlg.UserName, 0);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void OnDropUser(object sender, EventArgs e)
		{
			if (lstUsers.SelectedItems.Count > 0)
			{
				try
				{
					DatabaseQueries.DropUser(LoginInformation.Server, CurrentDatabase, LoginInformation.User, LoginInformation.Password, lstUsers.SelectedItems[0].Text);
					lstUsers.Items.Remove(lstUsers.SelectedItems[0]);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void OnDoubleClick(object sender, EventArgs e)
		{
			OnEditPermission(sender, e);
		}

		private void OnEditPermission(object sender, EventArgs e)
		{
			if (lstUsers.SelectedItems.Count > 0)
			{
				using (EditPermission dlg = new EditPermission(CurrentDatabase, lstUsers.SelectedItems[0].Text))
				{
					dlg.ShowDialog();
				}
			}
			
		}
	}
}
