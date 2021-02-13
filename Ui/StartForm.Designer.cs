namespace SchoolProject.Ui
{
	partial class StartForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
			this.Manager_Panel_Bo = new System.Windows.Forms.Button();
			this.Teacher_Panel_Bo = new System.Windows.Forms.Button();
			this.Parent_Panel_Bo = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Manager_Panel_Bo
			// 
			this.Manager_Panel_Bo.BackColor = System.Drawing.SystemColors.InactiveCaption;
			resources.ApplyResources(this.Manager_Panel_Bo, "Manager_Panel_Bo");
			this.Manager_Panel_Bo.Name = "Manager_Panel_Bo";
			this.Manager_Panel_Bo.UseVisualStyleBackColor = false;
			this.Manager_Panel_Bo.Click += new System.EventHandler(this.Manager_Panel_Bo_Click);
			// 
			// Teacher_Panel_Bo
			// 
			this.Teacher_Panel_Bo.BackColor = System.Drawing.SystemColors.InactiveCaption;
			resources.ApplyResources(this.Teacher_Panel_Bo, "Teacher_Panel_Bo");
			this.Teacher_Panel_Bo.Name = "Teacher_Panel_Bo";
			this.Teacher_Panel_Bo.UseVisualStyleBackColor = false;
			this.Teacher_Panel_Bo.Click += new System.EventHandler(this.Teacher_Panel_Bo_Click);
			// 
			// Parent_Panel_Bo
			// 
			this.Parent_Panel_Bo.BackColor = System.Drawing.SystemColors.InactiveCaption;
			resources.ApplyResources(this.Parent_Panel_Bo, "Parent_Panel_Bo");
			this.Parent_Panel_Bo.Name = "Parent_Panel_Bo";
			this.Parent_Panel_Bo.UseVisualStyleBackColor = false;
			this.Parent_Panel_Bo.Click += new System.EventHandler(this.Parent_Panel_Bo_Click);
			// 
			// StartForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.Controls.Add(this.Parent_Panel_Bo);
			this.Controls.Add(this.Teacher_Panel_Bo);
			this.Controls.Add(this.Manager_Panel_Bo);
			this.Name = "StartForm";
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button Manager_Panel_Bo;
		public System.Windows.Forms.Button Teacher_Panel_Bo;
		public System.Windows.Forms.Button Parent_Panel_Bo;
	}
}