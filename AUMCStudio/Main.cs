using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AUMCStudio
{
	public partial class Form1 : Form
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
		public Form1()
		{
			InitializeComponent();
			masterView1.Visible = false;
		}

        /// <summary>
        /// Called when [connect].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void OnConnect(object sender, EventArgs e)
		{
			using (ConnectForm dlg = new ConnectForm())
			{
				if (dlg.ShowDialog() == DialogResult.OK)
				{
					masterView1.Visible = true;
					tsbConnect.Enabled = false;
					tsbDisconnect.Enabled = true;
				}
			}
		}

        /// <summary>
        /// Called when [disconnect].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void OnDisconnect(object sender, EventArgs e)
		{
			masterView1.RemoveCurrentView();
			masterView1.Visible = false;
			tsbConnect.Enabled = true;
			tsbDisconnect.Enabled = false;
		}
	}
}
