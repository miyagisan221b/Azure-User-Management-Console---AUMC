using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AUMCStudio
{
	public partial class MasterView : UserControl
	{
		private LoginsView _loginView;
		private UsersView _userView;

		public MasterView()
		{
			InitializeComponent();

			_loginView = new LoginsView(this);
			_userView = new UsersView(this);
		}

		private UserControl CurrentView
		{
			get;
			set;
		}


		public void RemoveCurrentView()
		{
			if(CurrentView != null)
			{
				this.Controls.Remove(CurrentView);
				CurrentView = null;
				pnButtons.Visible = true;
			}
			
		}

		private void OnLogin(object sender, EventArgs e)
		{
			CurrentView = _loginView;
			this.Controls.Add(_loginView);
			_loginView.Dock = DockStyle.Fill;
			pnButtons.Visible = false;
			_loginView.RefreshView();
		}

		private void OnUsers(object sender, EventArgs e)
		{
			CurrentView = _userView;
			this.Controls.Add(_userView);
			_userView.Dock = DockStyle.Fill;
			pnButtons.Visible = false;
			_userView.RefreshView();
		}
	}
}
