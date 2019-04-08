namespace AUMCStudio
{
	partial class UsersView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersView));
			this.pnNavigation = new System.Windows.Forms.Panel();
			this.btBack = new System.Windows.Forms.Button();
			this.pnMain = new System.Windows.Forms.Panel();
			this.lstDatabases = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.cmsDatabases = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.editUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ilDbIcons = new System.Windows.Forms.ImageList(this.components);
			this.pnNavigation.SuspendLayout();
			this.pnMain.SuspendLayout();
			this.cmsDatabases.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnNavigation
			// 
			this.pnNavigation.Controls.Add(this.btBack);
			this.pnNavigation.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnNavigation.Location = new System.Drawing.Point(0, 0);
			this.pnNavigation.Name = "pnNavigation";
			this.pnNavigation.Size = new System.Drawing.Size(442, 47);
			this.pnNavigation.TabIndex = 0;
			// 
			// btBack
			// 
			this.btBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btBack.Image = global::AUMCStudio.Properties.Resources.Back;
			this.btBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btBack.Location = new System.Drawing.Point(8, 6);
			this.btBack.Name = "btBack";
			this.btBack.Size = new System.Drawing.Size(87, 35);
			this.btBack.TabIndex = 0;
			this.btBack.Text = "Back";
			this.btBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btBack.UseVisualStyleBackColor = true;
			this.btBack.Click += new System.EventHandler(this.OnBack);
			// 
			// pnMain
			// 
			this.pnMain.Controls.Add(this.lstDatabases);
			this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnMain.Location = new System.Drawing.Point(0, 47);
			this.pnMain.Name = "pnMain";
			this.pnMain.Padding = new System.Windows.Forms.Padding(5);
			this.pnMain.Size = new System.Drawing.Size(442, 295);
			this.pnMain.TabIndex = 1;
			// 
			// lstDatabases
			// 
			this.lstDatabases.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstDatabases.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lstDatabases.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
			this.lstDatabases.ContextMenuStrip = this.cmsDatabases;
			this.lstDatabases.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lstDatabases.LargeImageList = this.ilDbIcons;
			this.lstDatabases.Location = new System.Drawing.Point(8, 8);
			this.lstDatabases.MultiSelect = false;
			this.lstDatabases.Name = "lstDatabases";
			this.lstDatabases.Size = new System.Drawing.Size(426, 279);
			this.lstDatabases.TabIndex = 0;
			this.lstDatabases.UseCompatibleStateImageBehavior = false;
			this.lstDatabases.DoubleClick += new System.EventHandler(this.OnDoubleClick);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Database";
			this.columnHeader1.Width = 115;
			// 
			// cmsDatabases
			// 
			this.cmsDatabases.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editUsersToolStripMenuItem});
			this.cmsDatabases.Name = "cmsDatabases";
			this.cmsDatabases.Size = new System.Drawing.Size(123, 26);
			this.cmsDatabases.Opening += new System.ComponentModel.CancelEventHandler(this.OnOpening);
			// 
			// editUsersToolStripMenuItem
			// 
			this.editUsersToolStripMenuItem.Name = "editUsersToolStripMenuItem";
			this.editUsersToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
			this.editUsersToolStripMenuItem.Text = "Edit Users";
			this.editUsersToolStripMenuItem.Click += new System.EventHandler(this.OnEditUsers);
			// 
			// ilDbIcons
			// 
			this.ilDbIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilDbIcons.ImageStream")));
			this.ilDbIcons.TransparentColor = System.Drawing.Color.Transparent;
			this.ilDbIcons.Images.SetKeyName(0, "database.png");
			// 
			// UsersView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pnMain);
			this.Controls.Add(this.pnNavigation);
			this.Name = "UsersView";
			this.Size = new System.Drawing.Size(442, 342);
			this.pnNavigation.ResumeLayout(false);
			this.pnMain.ResumeLayout(false);
			this.cmsDatabases.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnNavigation;
		private System.Windows.Forms.Button btBack;
		private System.Windows.Forms.Panel pnMain;
		private System.Windows.Forms.ListView lstDatabases;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ImageList ilDbIcons;
		private System.Windows.Forms.ContextMenuStrip cmsDatabases;
		private System.Windows.Forms.ToolStripMenuItem editUsersToolStripMenuItem;
	}
}
