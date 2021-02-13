namespace SchoolProject.Ui
{
	partial class Stu_Delete
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
			this.Student_List_Gr = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.Stu_Edit_Bo = new System.Windows.Forms.Button();
			this.Stu_Show_List = new System.Windows.Forms.Button();
			this.Stu_Register_bo = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.Student_List_Gr)).BeginInit();
			this.SuspendLayout();
			// 
			// Student_List_Gr
			// 
			this.Student_List_Gr.BackgroundColor = System.Drawing.SystemColors.Control;
			this.Student_List_Gr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Student_List_Gr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Student_List_Gr.Cursor = System.Windows.Forms.Cursors.Default;
			this.Student_List_Gr.GridColor = System.Drawing.SystemColors.Control;
			this.Student_List_Gr.Location = new System.Drawing.Point(40, 179);
			this.Student_List_Gr.Name = "Student_List_Gr";
			this.Student_List_Gr.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Student_List_Gr.RowHeadersWidth = 62;
			this.Student_List_Gr.RowTemplate.Height = 28;
			this.Student_List_Gr.Size = new System.Drawing.Size(718, 281);
			this.Student_List_Gr.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.button1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(405, 63);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(112, 59);
			this.button1.TabIndex = 1;
			this.button1.Text = "حذف";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Stu_Edit_Bo
			// 
			this.Stu_Edit_Bo.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.Stu_Edit_Bo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Stu_Edit_Bo.Location = new System.Drawing.Point(40, 63);
			this.Stu_Edit_Bo.Name = "Stu_Edit_Bo";
			this.Stu_Edit_Bo.Size = new System.Drawing.Size(112, 59);
			this.Stu_Edit_Bo.TabIndex = 2;
			this.Stu_Edit_Bo.Text = "ویرایش";
			this.Stu_Edit_Bo.UseVisualStyleBackColor = false;
			this.Stu_Edit_Bo.Click += new System.EventHandler(this.Stu_Edit_Bo_Click);
			// 
			// Stu_Show_List
			// 
			this.Stu_Show_List.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.Stu_Show_List.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Stu_Show_List.Location = new System.Drawing.Point(569, 63);
			this.Stu_Show_List.Name = "Stu_Show_List";
			this.Stu_Show_List.Size = new System.Drawing.Size(189, 59);
			this.Stu_Show_List.TabIndex = 3;
			this.Stu_Show_List.Text = "مشاهده دانش آموزان";
			this.Stu_Show_List.UseVisualStyleBackColor = false;
			this.Stu_Show_List.Click += new System.EventHandler(this.Stu_Show_List_Click);
			// 
			// Stu_Register_bo
			// 
			this.Stu_Register_bo.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.Stu_Register_bo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Stu_Register_bo.Location = new System.Drawing.Point(228, 63);
			this.Stu_Register_bo.Name = "Stu_Register_bo";
			this.Stu_Register_bo.Size = new System.Drawing.Size(112, 59);
			this.Stu_Register_bo.TabIndex = 4;
			this.Stu_Register_bo.Text = "ثبت نام ";
			this.Stu_Register_bo.UseVisualStyleBackColor = false;
			this.Stu_Register_bo.Click += new System.EventHandler(this.Stu_Register_bo_Click);
			// 
			// Stu_Delete
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(800, 496);
			this.Controls.Add(this.Stu_Register_bo);
			this.Controls.Add(this.Stu_Show_List);
			this.Controls.Add(this.Stu_Edit_Bo);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Student_List_Gr);
			this.Name = "Stu_Delete";
			this.Text = "نمایش اطلاعات دانش آموز";
			this.Load += new System.EventHandler(this.Delete_Student_Load);
			((System.ComponentModel.ISupportInitialize)(this.Student_List_Gr)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		public System.Windows.Forms.Button button1;
		public System.Windows.Forms.DataGridView Student_List_Gr;
		public System.Windows.Forms.Button Stu_Show_List;
		public System.Windows.Forms.Button Stu_Register_bo;
		public System.Windows.Forms.Button Stu_Edit_Bo;
	}
}