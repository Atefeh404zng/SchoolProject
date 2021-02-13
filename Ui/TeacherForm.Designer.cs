namespace SchoolProject.Ui
{
	partial class TeacherForm
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
			this.label2 = new System.Windows.Forms.Label();
			this.Stu_List_ByCourse_Gr = new System.Windows.Forms.DataGridView();
			this.Course_Select_Co = new System.Windows.Forms.ComboBox();
			this.Show_Stu_ByCourse = new System.Windows.Forms.Button();
			this.Add_Mark_Bo = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.Add_Mark_txt = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.Stu_List_ByCourse_Gr)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(659, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(172, 59);
			this.label2.TabIndex = 1;
			this.label2.Text = "انتخاب درس";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Stu_List_ByCourse_Gr
			// 
			this.Stu_List_ByCourse_Gr.BackgroundColor = System.Drawing.SystemColors.Control;
			this.Stu_List_ByCourse_Gr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Stu_List_ByCourse_Gr.Location = new System.Drawing.Point(58, 259);
			this.Stu_List_ByCourse_Gr.Name = "Stu_List_ByCourse_Gr";
			this.Stu_List_ByCourse_Gr.RowHeadersWidth = 62;
			this.Stu_List_ByCourse_Gr.RowTemplate.Height = 28;
			this.Stu_List_ByCourse_Gr.Size = new System.Drawing.Size(773, 206);
			this.Stu_List_ByCourse_Gr.TabIndex = 2;
			// 
			// Course_Select_Co
			// 
			this.Course_Select_Co.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.Course_Select_Co.FormattingEnabled = true;
			this.Course_Select_Co.Location = new System.Drawing.Point(411, 80);
			this.Course_Select_Co.Name = "Course_Select_Co";
			this.Course_Select_Co.Size = new System.Drawing.Size(172, 27);
			this.Course_Select_Co.TabIndex = 3;
			// 
			// Show_Stu_ByCourse
			// 
			this.Show_Stu_ByCourse.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.Show_Stu_ByCourse.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.Show_Stu_ByCourse.Location = new System.Drawing.Point(58, 63);
			this.Show_Stu_ByCourse.Name = "Show_Stu_ByCourse";
			this.Show_Stu_ByCourse.Size = new System.Drawing.Size(210, 59);
			this.Show_Stu_ByCourse.TabIndex = 4;
			this.Show_Stu_ByCourse.Text = "مشاهده لیست دانش اموزان";
			this.Show_Stu_ByCourse.UseVisualStyleBackColor = false;
			this.Show_Stu_ByCourse.Click += new System.EventHandler(this.Show_Stu_ByCourse_Click);
			// 
			// Add_Mark_Bo
			// 
			this.Add_Mark_Bo.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.Add_Mark_Bo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Add_Mark_Bo.Location = new System.Drawing.Point(58, 169);
			this.Add_Mark_Bo.Name = "Add_Mark_Bo";
			this.Add_Mark_Bo.Size = new System.Drawing.Size(210, 59);
			this.Add_Mark_Bo.TabIndex = 5;
			this.Add_Mark_Bo.Text = "اضافه کردن نمرات";
			this.Add_Mark_Bo.UseVisualStyleBackColor = false;
			this.Add_Mark_Bo.Click += new System.EventHandler(this.Add_Mark_From_Bo_Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(659, 169);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(172, 59);
			this.label1.TabIndex = 6;
			this.label1.Text = "افزودن نمره";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Add_Mark_txt
			// 
			this.Add_Mark_txt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.Add_Mark_txt.Location = new System.Drawing.Point(411, 169);
			this.Add_Mark_txt.Multiline = true;
			this.Add_Mark_txt.Name = "Add_Mark_txt";
			this.Add_Mark_txt.Size = new System.Drawing.Size(172, 59);
			this.Add_Mark_txt.TabIndex = 7;
			// 
			// TeacherForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(889, 486);
			this.Controls.Add(this.Add_Mark_txt);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Add_Mark_Bo);
			this.Controls.Add(this.Show_Stu_ByCourse);
			this.Controls.Add(this.Course_Select_Co);
			this.Controls.Add(this.Stu_List_ByCourse_Gr);
			this.Controls.Add(this.label2);
			this.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "TeacherForm";
			this.Load += new System.EventHandler(this.TeacherForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.Stu_List_ByCourse_Gr)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.Label label2;
		public System.Windows.Forms.DataGridView Stu_List_ByCourse_Gr;
		public System.Windows.Forms.ComboBox Course_Select_Co;
		public System.Windows.Forms.Button Show_Stu_ByCourse;
		public System.Windows.Forms.Button Add_Mark_Bo;
		public System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox Add_Mark_txt;
	}
}