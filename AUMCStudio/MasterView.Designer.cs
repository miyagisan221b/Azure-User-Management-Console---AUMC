namespace AUMCStudio
{
	partial class MasterView
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
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.pnButtons = new System.Windows.Forms.Panel();
			this.pnButtons.SuspendLayout();
			this.SuspendLayout();
			// 
			// button2
			// 
			this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button2.Image = global::AUMCStudio.Properties.Resources.usersdb;
			this.button2.Location = new System.Drawing.Point(231, 117);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(107, 102);
			this.button2.TabIndex = 1;
			this.button2.Text = "Users";
			this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.OnUsers);
			// 
			// button1
			// 
			this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button1.Image = global::AUMCStudio.Properties.Resources.keys;
			this.button1.Location = new System.Drawing.Point(92, 117);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(107, 102);
			this.button1.TabIndex = 0;
			this.button1.Text = "Logins";
			this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.OnLogin);
			// 
			// pnButtons
			// 
			this.pnButtons.Controls.Add(this.button1);
			this.pnButtons.Controls.Add(this.button2);
			this.pnButtons.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnButtons.Location = new System.Drawing.Point(0, 0);
			this.pnButtons.Name = "pnButtons";
			this.pnButtons.Size = new System.Drawing.Size(430, 336);
			this.pnButtons.TabIndex = 2;
			// 
			// MasterView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pnButtons);
			this.Name = "MasterView";
			this.Size = new System.Drawing.Size(430, 336);
			this.pnButtons.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel pnButtons;
	}
}
