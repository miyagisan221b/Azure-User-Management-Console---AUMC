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
	public partial class ConnectForm : Form
	{
		public ConnectForm()
		{
			InitializeComponent();
		}

		private void OnConnect(object sender, EventArgs e)
		{
			try
			{
				//test connection
				DatabaseQueries.GetDatabases(tbServer.Text, tbUser.Text, tbPassword.Text);

				LoginInformation.Server = tbServer.Text;
				LoginInformation.User = tbUser.Text;
				LoginInformation.Password = tbPassword.Text;

				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
	}
}
