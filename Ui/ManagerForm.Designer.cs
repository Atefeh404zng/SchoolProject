namespace SchoolProject.Ui
{
	partial class ManagerForm
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
			this.Manager1_Bo = new System.Windows.Forms.Button();
			this.Manager2_Bo = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Manager1_Bo
			// 
			this.Manager1_Bo.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.Manager1_Bo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Manager1_Bo.Location = new System.Drawing.Point(317, 87);
			this.Manager1_Bo.Name = "Manager1_Bo";
			this.Manager1_Bo.Size = new System.Drawing.Size(190, 110);
			this.Manager1_Bo.TabIndex = 2;
			this.Manager1_Bo.Text = "ثبت نام دانش اموز";
			this.Manager1_Bo.UseVisualStyleBackColor = false;
			this.Manager1_Bo.Click += new System.EventHandler(this.Manager1_Bo_Click);
			// 
			// Manager2_Bo
			// 
			this.Manager2_Bo.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.Manager2_Bo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Manager2_Bo.Location = new System.Drawing.Point(88, 87);
			this.Manager2_Bo.Name = "Manager2_Bo";
			this.Manager2_Bo.Size = new System.Drawing.Size(190, 110);
			this.Manager2_Bo.TabIndex = 3;
			this.Manager2_Bo.Text = "ثبت نام معلم";
			this.Manager2_Bo.UseVisualStyleBackColor = false;
			this.Manager2_Bo.Click += new System.EventHandler(this.Manager2_Bo_Click);
			// 
			// ManagerForm
			// 
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(564, 309);
			this.Controls.Add(this.Manager2_Bo);
			this.Controls.Add(this.Manager1_Bo);
			this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Name = "ManagerForm";
			this.Text = "پنل کاربری مدیر";
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button Manager1_Bo;
		public System.Windows.Forms.Button Manager2_Bo;
	}
}