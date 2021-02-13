namespace SchoolProject.Ui
{
	partial class ParentForm
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
			this.Show_ByCourse = new System.Windows.Forms.Button();
			this.Course_List_Gr = new System.Windows.Forms.DataGridView();
			this.student_list_gr = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.Course_List_Gr)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.student_list_gr)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(630, 251);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 60);
			this.label1.TabIndex = 0;
			this.label1.Text = "انتخاب دانش اموز";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Show_ByCourse
			// 
			this.Show_ByCourse.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.Show_ByCourse.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Show_ByCourse.Location = new System.Drawing.Point(594, 27);
			this.Show_ByCourse.Name = "Show_ByCourse";
			this.Show_ByCourse.Size = new System.Drawing.Size(160, 60);
			this.Show_ByCourse.TabIndex = 1;
			this.Show_ByCourse.Text = "مشاهده نمرات";
			this.Show_ByCourse.UseVisualStyleBackColor = false;
			this.Show_ByCourse.Click += new System.EventHandler(this.Show_ByCourse_Click);
			// 
			// Course_List_Gr
			// 
			this.Course_List_Gr.BackgroundColor = System.Drawing.SystemColors.Control;
			this.Course_List_Gr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Course_List_Gr.Location = new System.Drawing.Point(81, 27);
			this.Course_List_Gr.Name = "Course_List_Gr";
			this.Course_List_Gr.RowHeadersWidth = 62;
			this.Course_List_Gr.RowTemplate.Height = 28;
			this.Course_List_Gr.Size = new System.Drawing.Size(507, 258);
			this.Course_List_Gr.TabIndex = 2;
			// 
			// student_list_gr
			// 
			this.student_list_gr.BackgroundColor = System.Drawing.SystemColors.Control;
			this.student_list_gr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.student_list_gr.Location = new System.Drawing.Point(81, 314);
			this.student_list_gr.Name = "student_list_gr";
			this.student_list_gr.RowHeadersWidth = 62;
			this.student_list_gr.RowTemplate.Height = 28;
			this.student_list_gr.Size = new System.Drawing.Size(709, 258);
			this.student_list_gr.TabIndex = 3;
			this.student_list_gr.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.student_list_gr_CellContentClick);
			// 
			// ParentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(863, 597);
			this.Controls.Add(this.student_list_gr);
			this.Controls.Add(this.Course_List_Gr);
			this.Controls.Add(this.Show_ByCourse);
			this.Controls.Add(this.label1);
			this.Name = "ParentForm";
			this.Text = "مشاهده نمرات دانش اموز";
			this.Load += new System.EventHandler(this.ParentForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.Course_List_Gr)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.student_list_gr)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.Button Show_ByCourse;
		public System.Windows.Forms.DataGridView Course_List_Gr;
		public System.Windows.Forms.DataGridView student_list_gr;
	}
}