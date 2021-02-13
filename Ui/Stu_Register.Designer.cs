namespace SchoolProject.Ui
{
	partial class Stu_Register
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
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.Stu_Name_form = new System.Windows.Forms.TextBox();
			this.Stu_Family_form = new System.Windows.Forms.TextBox();
			this.Stu_No_form = new System.Windows.Forms.TextBox();
			this.Fa_No_form = new System.Windows.Forms.TextBox();
			this.Mo_No_form = new System.Windows.Forms.TextBox();
			this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
			this.Stu_Save_form = new System.Windows.Forms.Button();
			this.Stu_AddCourse_Bo = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(645, 47);
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
			this.label2.Location = new System.Drawing.Point(645, 203);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(128, 49);
			this.label2.TabIndex = 1;
			this.label2.Text = "نام خانوادگی";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label3.Location = new System.Drawing.Point(645, 363);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(128, 49);
			this.label3.TabIndex = 2;
			this.label3.Text = "شماره ملی";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(233, 203);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(128, 49);
			this.label4.TabIndex = 3;
			this.label4.Text = "شماره ملی پدر";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(233, 46);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(128, 49);
			this.label5.TabIndex = 4;
			this.label5.Text = "شماره ملی مادر";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Stu_Name_form
			// 
			this.Stu_Name_form.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.Stu_Name_form.Location = new System.Drawing.Point(487, 46);
			this.Stu_Name_form.Multiline = true;
			this.Stu_Name_form.Name = "Stu_Name_form";
			this.Stu_Name_form.Size = new System.Drawing.Size(121, 49);
			this.Stu_Name_form.TabIndex = 7;
			// 
			// Stu_Family_form
			// 
			this.Stu_Family_form.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.Stu_Family_form.Location = new System.Drawing.Point(487, 203);
			this.Stu_Family_form.Multiline = true;
			this.Stu_Family_form.Name = "Stu_Family_form";
			this.Stu_Family_form.Size = new System.Drawing.Size(121, 49);
			this.Stu_Family_form.TabIndex = 8;
			// 
			// Stu_No_form
			// 
			this.Stu_No_form.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.Stu_No_form.Location = new System.Drawing.Point(487, 364);
			this.Stu_No_form.Multiline = true;
			this.Stu_No_form.Name = "Stu_No_form";
			this.Stu_No_form.Size = new System.Drawing.Size(121, 49);
			this.Stu_No_form.TabIndex = 9;
			// 
			// Fa_No_form
			// 
			this.Fa_No_form.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.Fa_No_form.Location = new System.Drawing.Point(56, 203);
			this.Fa_No_form.Multiline = true;
			this.Fa_No_form.Name = "Fa_No_form";
			this.Fa_No_form.Size = new System.Drawing.Size(121, 49);
			this.Fa_No_form.TabIndex = 10;
			// 
			// Mo_No_form
			// 
			this.Mo_No_form.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.Mo_No_form.Location = new System.Drawing.Point(56, 46);
			this.Mo_No_form.Multiline = true;
			this.Mo_No_form.Name = "Mo_No_form";
			this.Mo_No_form.Size = new System.Drawing.Size(121, 49);
			this.Mo_No_form.TabIndex = 11;
			// 
			// entityCommand1
			// 
			this.entityCommand1.CommandTimeout = 0;
			this.entityCommand1.CommandTree = null;
			this.entityCommand1.Connection = null;
			this.entityCommand1.EnablePlanCaching = true;
			this.entityCommand1.Transaction = null;
			// 
			// Stu_Save_form
			// 
			this.Stu_Save_form.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.Stu_Save_form.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Stu_Save_form.Location = new System.Drawing.Point(56, 364);
			this.Stu_Save_form.Name = "Stu_Save_form";
			this.Stu_Save_form.Size = new System.Drawing.Size(153, 56);
			this.Stu_Save_form.TabIndex = 12;
			this.Stu_Save_form.Text = "ثبت اطلاعات";
			this.Stu_Save_form.UseVisualStyleBackColor = false;
			this.Stu_Save_form.Click += new System.EventHandler(this.Stu_Save_form_Click);
			// 
			// Stu_AddCourse_Bo
			// 
			this.Stu_AddCourse_Bo.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.Stu_AddCourse_Bo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Stu_AddCourse_Bo.Location = new System.Drawing.Point(247, 364);
			this.Stu_AddCourse_Bo.Name = "Stu_AddCourse_Bo";
			this.Stu_AddCourse_Bo.Size = new System.Drawing.Size(153, 56);
			this.Stu_AddCourse_Bo.TabIndex = 13;
			this.Stu_AddCourse_Bo.Text = "افزودن درس";
			this.Stu_AddCourse_Bo.UseVisualStyleBackColor = false;
			this.Stu_AddCourse_Bo.Click += new System.EventHandler(this.Stu_AddCourse_Bo_Click);
			// 
			// Stu_Register
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(800, 486);
			this.Controls.Add(this.Stu_AddCourse_Bo);
			this.Controls.Add(this.Stu_Save_form);
			this.Controls.Add(this.Mo_No_form);
			this.Controls.Add(this.Fa_No_form);
			this.Controls.Add(this.Stu_No_form);
			this.Controls.Add(this.Stu_Family_form);
			this.Controls.Add(this.Stu_Name_form);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Stu_Register";
			this.RightToLeftLayout = true;
			this.Text = "ثبت نام دانش اموز";
			this.TransparencyKey = System.Drawing.Color.DeepSkyBlue;
			this.Load += new System.EventHandler(this.Stu_Register_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
		public System.Windows.Forms.Label label1;
		public System.Windows.Forms.Label label2;
		public System.Windows.Forms.Label label3;
		public System.Windows.Forms.Label label4;
		public System.Windows.Forms.Label label5;
		public System.Windows.Forms.TextBox Stu_Name_form;
		public System.Windows.Forms.TextBox Stu_Family_form;
		public System.Windows.Forms.TextBox Stu_No_form;
		public System.Windows.Forms.TextBox Fa_No_form;
		public System.Windows.Forms.TextBox Mo_No_form;
		public System.Windows.Forms.Button Stu_Save_form;
		public System.Windows.Forms.Button Stu_AddCourse_Bo;
	}
}