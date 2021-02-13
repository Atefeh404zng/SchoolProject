namespace SchoolProject.Ui
{
	partial class Tea_Register
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.Tae_Name_form = new System.Windows.Forms.TextBox();
			this.Tea_Family_form = new System.Windows.Forms.TextBox();
			this.Tea_Course_combo = new System.Windows.Forms.ComboBox();
			this.Tea_Save_form = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(623, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 49);
			this.label1.TabIndex = 0;
			this.label1.Text = "نام";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(623, 165);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(128, 49);
			this.label2.TabIndex = 1;
			this.label2.Text = "نام خانوادگی ";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(623, 276);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(128, 49);
			this.label3.TabIndex = 2;
			this.label3.Text = "نام درس";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Tae_Name_form
			// 
			this.Tae_Name_form.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.Tae_Name_form.Location = new System.Drawing.Point(421, 44);
			this.Tae_Name_form.Multiline = true;
			this.Tae_Name_form.Name = "Tae_Name_form";
			this.Tae_Name_form.Size = new System.Drawing.Size(121, 49);
			this.Tae_Name_form.TabIndex = 3;
			// 
			// Tea_Family_form
			// 
			this.Tea_Family_form.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.Tea_Family_form.Location = new System.Drawing.Point(421, 165);
			this.Tea_Family_form.Multiline = true;
			this.Tea_Family_form.Name = "Tea_Family_form";
			this.Tea_Family_form.Size = new System.Drawing.Size(121, 49);
			this.Tea_Family_form.TabIndex = 4;
			// 
			// Tea_Course_combo
			// 
			this.Tea_Course_combo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.Tea_Course_combo.FormattingEnabled = true;
			this.Tea_Course_combo.Location = new System.Drawing.Point(421, 289);
			this.Tea_Course_combo.Name = "Tea_Course_combo";
			this.Tea_Course_combo.Size = new System.Drawing.Size(121, 28);
			this.Tea_Course_combo.TabIndex = 5;
			// 
			// Tea_Save_form
			// 
			this.Tea_Save_form.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.Tea_Save_form.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Tea_Save_form.Location = new System.Drawing.Point(68, 289);
			this.Tea_Save_form.Name = "Tea_Save_form";
			this.Tea_Save_form.Size = new System.Drawing.Size(150, 68);
			this.Tea_Save_form.TabIndex = 6;
			this.Tea_Save_form.Text = "ثبت اطلاعات";
			this.Tea_Save_form.UseVisualStyleBackColor = false;
			this.Tea_Save_form.Click += new System.EventHandler(this.Tea_Save_form_Click);
			// 
			// Tea_Register
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(800, 405);
			this.Controls.Add(this.Tea_Save_form);
			this.Controls.Add(this.Tea_Course_combo);
			this.Controls.Add(this.Tea_Family_form);
			this.Controls.Add(this.Tae_Name_form);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Tea_Register";
			this.Text = "ثبت نام معلّم";
			this.Load += new System.EventHandler(this.Tea_Register_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.Label label1;
		public System.Windows.Forms.Label label2;
		public System.Windows.Forms.Label label3;
		public System.Windows.Forms.TextBox Tae_Name_form;
		public System.Windows.Forms.TextBox Tea_Family_form;
		public System.Windows.Forms.ComboBox Tea_Course_combo;
		public System.Windows.Forms.Button Tea_Save_form;
	}
}