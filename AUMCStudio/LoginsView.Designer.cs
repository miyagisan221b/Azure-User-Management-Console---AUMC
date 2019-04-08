namespace AUMCStudio
{
	partial class LoginsView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginsView));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btBack = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btDropLogin = new System.Windows.Forms.Button();
			this.btCreateLogin = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.cmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.cmsMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btBack);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(389, 47);
			this.panel1.TabIndex = 1;
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
			// panel2
			// 
			this.panel2.Controls.Add(this.btDropLogin);
			this.panel2.Controls.Add(this.btCreateLogin);
			this.panel2.Controls.Add(this.listView1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 47);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new System.Windows.Forms.Padding(5);
			this.panel2.Size = new System.Drawing.Size(389, 270);
			this.panel2.TabIndex = 2;
			// 
			// btDropLogin
			// 
			this.btDropLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btDropLogin.Image = global::AUMCStudio.Properties.Resources.removekey;
			this.btDropLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btDropLogin.Location = new System.Drawing.Point(267, 220);
			this.btDropLogin.Name = "btDropLogin";
			this.btDropLogin.Size = new System.Drawing.Size(114, 42);
			this.btDropLogin.TabIndex = 2;
			this.btDropLogin.Text = "Drop Login";
			this.btDropLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btDropLogin.UseVisualStyleBackColor = true;
			this.btDropLogin.Click += new System.EventHandler(this.OnDelete);
			// 
			// btCreateLogin
			// 
			this.btCreateLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btCreateLogin.Image = global::AUMCStudio.Properties.Resources.addkey;
			this.btCreateLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btCreateLogin.Location = new System.Drawing.Point(8, 220);
			this.btCreateLogin.Name = "btCreateLogin";
			this.btCreateLogin.Size = new System.Drawing.Size(145, 42);
			this.btCreateLogin.TabIndex = 1;
			this.btCreateLogin.Text = "Create New Login";
			this.btCreateLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btCreateLogin.UseVisualStyleBackColor = true;
			this.btCreateLogin.Click += new System.EventHandler(this.OnCreateLogin);
			// 
			// listView1
			// 
			this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
			this.listView1.ContextMenuStrip = this.cmsMain;
			this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(8, 8);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(373, 197);
			this.listView1.SmallImageList = this.imageList1;
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Login";
			this.columnHeader1.Width = 363;
			// 
			// cmsMain
			// 
			this.cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDelete});
			this.cmsMain.Name = "contextMenuStrip1";
			this.cmsMain.Size = new System.Drawing.Size(126, 26);
			this.cmsMain.Opening += new System.ComponentModel.CancelEventHandler(this.OnOpening);
			// 
			// tsmiDelete
			// 
			this.tsmiDelete.Name = "tsmiDelete";
			this.tsmiDelete.Size = new System.Drawing.Size(125, 22);
			this.tsmiDelete.Text = "Drop Login";
			this.tsmiDelete.Click += new System.EventHandler(this.OnDelete);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "key.png");
			// 
			// LoginsView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "LoginsView";
			this.Size = new System.Drawing.Size(389, 317);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.cmsMain.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btBack;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btCreateLogin;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ContextMenuStrip cmsMain;
		private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Button btDropLogin;
	}
}
