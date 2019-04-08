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
	public partial class LoginsView : UserControl
	{
		public LoginsView(MasterView master)
		{
			InitializeComponent();

			MasterView = master;
		}

		private MasterView MasterView { get; set; }	

		private void OnBack(object sender, EventArgs e)
		{
			MasterView.RemoveCurrentView();
		}

		public void RefreshView()
		{
			listView1.Items.Clear();

			try
			{
				var logins = LoginQueries.GetLogins(LoginInformation.Server, LoginInformation.User, LoginInformation.Password);

				foreach (var item in logins)
				{
					listView1.Items.Add(item.Name, 0);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void OnRename(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count > 0)
			{
				try
				{
					LoginQueries.CreateLogin(LoginInformation.Server, LoginInformation.User, LoginInformation.Password, "megatest", "newmgt");
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void OnDelete(object sender, EventArgs e)
		{
			
			if (listView1.SelectedItems.Count > 0)
			{
				if (MessageBox.Show("Are you sure you want to drop this login?", "Drop Login", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					try
					{
						LoginQueries.DeleteLogin(LoginInformation.Server, LoginInformation.User, LoginInformation.Password, listView1.SelectedItems[0].Text);
						listView1.Items.Remove(listView1.SelectedItems[0]);
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void OnCreateLogin(object sender, EventArgs e)
		{
			using (CreateLogin dlg = new CreateLogin())
			{
				if (dlg.ShowDialog() == DialogResult.OK)
				{
					listView1.Items.Add(dlg.LoginName, 0);
				}
			}
		}

		private void OnOpening(object sender, CancelEventArgs e)
		{
			if (listView1.SelectedItems.Count == 0)
			{
				e.Cancel = true;
			}
		}
	}
}
