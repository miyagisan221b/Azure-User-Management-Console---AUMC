namespace AUMCStudio
{
	partial class DatabaseUsersView
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseUsersView));
			this.lstUsers = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.cmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.editPermissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiDropUser = new System.Windows.Forms.ToolStripMenuItem();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.btDropUser = new System.Windows.Forms.Button();
			this.btCreateUser = new System.Windows.Forms.Button();
			this.cmsMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// lstUsers
			// 
			this.lstUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lstUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this.lstUsers.ContextMenuStrip = this.cmsMain;
			this.lstUsers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lstUsers.Location = new System.Drawing.Point(8, 8);
			this.lstUsers.Name = "lstUsers";
			this.lstUsers.Size = new System.Drawing.Size(513, 368);
			this.lstUsers.SmallImageList = this.imageList1;
			this.lstUsers.TabIndex = 0;
			this.lstUsers.UseCompatibleStateImageBehavior = false;
			this.lstUsers.View = System.Windows.Forms.View.Details;
			this.lstUsers.DoubleClick += new System.EventHandler(this.OnDoubleClick);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "User";
			this.columnHeader1.Width = 157;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Default Schema";
			this.columnHeader2.Width = 339;
			// 
			// cmsMain
			// 
			this.cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editPermissionToolStripMenuItem,
            this.tsmiDropUser});
			this.cmsMain.Name = "cmsMain";
			this.cmsMain.Size = new System.Drawing.Size(146, 48);
			// 
			// editPermissionToolStripMenuItem
			// 
			this.editPermissionToolStripMenuItem.Name = "editPermissionToolStripMenuItem";
			this.editPermissionToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
			this.editPermissionToolStripMenuItem.Text = "Edit Permission";
			this.editPermissionToolStripMenuItem.Click += new System.EventHandler(this.OnEditPermission);
			// 
			// tsmiDropUser
			// 
			this.tsmiDropUser.Name = "tsmiDropUser";
			this.tsmiDropUser.Size = new System.Drawing.Size(145, 22);
			this.tsmiDropUser.Text = "Drop User";
			this.tsmiDropUser.Click += new System.EventHandler(this.OnDropUser);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "User.png");
			// 
			// btDropUser
			// 
			this.btDropUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btDropUser.Image = global::AUMCStudio.Properties.Resources.removeuser;
			this.btDropUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btDropUser.Location = new System.Drawing.Point(376, 392);
			this.btDropUser.Name = "btDropUser";
			this.btDropUser.Size = new System.Drawing.Size(145, 42);
			this.btDropUser.TabIndex = 2;
			this.btDropUser.Text = "Drop User";
			this.btDropUser.UseVisualStyleBackColor = true;
			this.btDropUser.Click += new System.EventHandler(this.OnDropUser);
			// 
			// btCreateUser
			// 
			this.btCreateUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btCreateUser.Image = global::AUMCStudio.Properties.Resources.adduser;
			this.btCreateUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btCreateUser.Location = new System.Drawing.Point(8, 392);
			this.btCreateUser.Name = "btCreateUser";
			this.btCreateUser.Size = new System.Drawing.Size(145, 42);
			this.btCreateUser.TabIndex = 1;
			this.btCreateUser.Text = "Create User";
			this.btCreateUser.UseVisualStyleBackColor = true;
			this.btCreateUser.Click += new System.EventHandler(this.OnCreateUser);
			// 
			// DatabaseUsersView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btDropUser);
			this.Controls.Add(this.lstUsers);
			this.Controls.Add(this.btCreateUser);
			this.Name = "DatabaseUsersView";
			this.Padding = new System.Windows.Forms.Padding(5);
			this.Size = new System.Drawing.Size(529, 442);
			this.cmsMain.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView lstUsers;
		private System.Windows.Forms.Button btCreateUser;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ContextMenuStrip cmsMain;
		private System.Windows.Forms.ToolStripMenuItem editPermissionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmiDropUser;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Button btDropUser;
	}
}
