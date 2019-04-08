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
	public partial class UsersView : UserControl
	{
		private DatabaseUsersView _dbUserView;

		public UsersView(MasterView master)
		{
			InitializeComponent();

			MasterView = master;

			_dbUserView = new DatabaseUsersView();
			_dbUserView.Visible = false;
			this.Controls.Add(_dbUserView);
			_dbUserView.Dock = DockStyle.Fill;
			_dbUserView.BringToFront();			
		}

		private MasterView MasterView { get; set; }

		private void OnBack(object sender, EventArgs e)
		{
			if (_dbUserView.Visible)
			{
				_dbUserView.Visible = false;
				pnMain.Visible = true;
			}
			else
			{
				MasterView.RemoveCurrentView();
			}
		}

		public void RefreshView()
		{
			lstDatabases.Items.Clear();

			try
			{
				var databases = DatabaseQueries.GetDatabases(LoginInformation.Server, LoginInformation.User, LoginInformation.Password);

				foreach (var item in databases)
				{
					lstDatabases.Items.Add(item.Name, 0);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void OnOpening(object sender, CancelEventArgs e)
		{
			if (lstDatabases.SelectedItems.Count == 0)
			{
				e.Cancel = true;
			}
		}

		private void OnEditUsers(object sender, EventArgs e)
		{
			if (lstDatabases.SelectedItems.Count > 0)
			{			
				_dbUserView.RefreshView(lstDatabases.SelectedItems[0].Text);
				_dbUserView.Visible = true;
				pnMain.Visible = false;
			}
		}

		private void OnDoubleClick(object sender, EventArgs e)
		{
			OnEditUsers(sender, e);
		}
	}
}
