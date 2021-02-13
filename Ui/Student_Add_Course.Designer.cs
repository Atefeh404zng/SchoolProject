namespace SchoolProject.Ui
{
	partial class Student_Add_Course
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
			this.Stu_AddCourse_Combo = new System.Windows.Forms.Button();
			this.Stu_Course_Combo = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Student_List_Gr_AddCourse = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.Student_List_Gr_AddCourse)).BeginInit();
			this.SuspendLayout();
			// 
			// Stu_AddCourse_Combo
			// 
			this.Stu_AddCourse_Combo.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.Stu_AddCourse_Combo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Stu_AddCourse_Combo.Location = new System.Drawing.Point(46, 91);
			this.Stu_AddCourse_Combo.Name = "Stu_AddCourse_Combo";
			this.Stu_AddCourse_Combo.Size = new System.Drawing.Size(163, 49);
			this.Stu_AddCourse_Combo.TabIndex = 0;
			this.Stu_AddCourse_Combo.Text = "ثبت";
			this.Stu_AddCourse_Combo.UseVisualStyleBackColor = false;
			this.Stu_AddCourse_Combo.Click += new System.EventHandler(this.Stu_AddCourse_Combo_Click);
			// 
			// Stu_Course_Combo
			// 
			this.Stu_Course_Combo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.Stu_Course_Combo.FormattingEnabled = true;
			this.Stu_Course_Combo.Location = new System.Drawing.Point(388, 103);
			this.Stu_Course_Combo.Name = "Stu_Course_Combo";
			this.Stu_Course_Combo.Size = new System.Drawing.Size(150, 28);
			this.Stu_Course_Combo.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(591, 91);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 49);
			this.label1.TabIndex = 2;
			this.label1.Text = "انتخاب درس";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Student_List_Gr_AddCourse
			// 
			this.Student_List_Gr_AddCourse.BackgroundColor = System.Drawing.SystemColors.Control;
			this.Student_List_Gr_AddCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Student_List_Gr_AddCourse.Location = new System.Drawing.Point(46, 164);
			this.Student_List_Gr_AddCourse.Name = "Student_List_Gr_AddCourse";
			this.Student_List_Gr_AddCourse.RowHeadersWidth = 62;
			this.Student_List_Gr_AddCourse.RowTemplate.Height = 28;
			this.Student_List_Gr_AddCourse.Size = new System.Drawing.Size(705, 232);
			this.Student_List_Gr_AddCourse.TabIndex = 3;
			// 
			// Student_Add_Course
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(800, 427);
			this.Controls.Add(this.Student_List_Gr_AddCourse);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Stu_Course_Combo);
			this.Controls.Add(this.Stu_AddCourse_Combo);
			this.Name = "Student_Add_Course";
			this.Text = "درس های دانش اموز";
			this.Load += new System.EventHandler(this.Student_Add_Course_Load);
			((System.ComponentModel.ISupportInitialize)(this.Student_List_Gr_AddCourse)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		public System.Windows.Forms.ComboBox Stu_Course_Combo;
		public System.Windows.Forms.Label label1;
		public System.Windows.Forms.Button Stu_AddCourse_Combo;
		public System.Windows.Forms.DataGridView Student_List_Gr_AddCourse;
	}
}