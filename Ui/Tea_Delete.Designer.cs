namespace SchoolProject.Ui
{
	partial class Tea_Delete
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
			this.Tea_Del_Bo = new System.Windows.Forms.Button();
			this.Teacher_List_Gr = new System.Windows.Forms.DataGridView();
			this.Tea_Edit_Bo = new System.Windows.Forms.Button();
			this.Tea_Register_bo = new System.Windows.Forms.Button();
			this.Tea_Show_List = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.Teacher_List_Gr)).BeginInit();
			this.SuspendLayout();
			// 
			// Tea_Del_Bo
			// 
			this.Tea_Del_Bo.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.Tea_Del_Bo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Tea_Del_Bo.Location = new System.Drawing.Point(406, 51);
			this.Tea_Del_Bo.Name = "Tea_Del_Bo";
			this.Tea_Del_Bo.Size = new System.Drawing.Size(112, 59);
			this.Tea_Del_Bo.TabIndex = 2;
			this.Tea_Del_Bo.Text = "حذف";
			this.Tea_Del_Bo.UseVisualStyleBackColor = false;
			this.Tea_Del_Bo.Click += new System.EventHandler(this.Tea_Del_Bo_Click);
			// 
			// Teacher_List_Gr
			// 
			this.Teacher_List_Gr.BackgroundColor = System.Drawing.SystemColors.Control;
			this.Teacher_List_Gr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Teacher_List_Gr.GridColor = System.Drawing.SystemColors.Control;
			this.Teacher_List_Gr.Location = new System.Drawing.Point(48, 166);
			this.Teacher_List_Gr.Name = "Teacher_List_Gr";
			this.Teacher_List_Gr.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Teacher_List_Gr.RowHeadersWidth = 62;
			this.Teacher_List_Gr.RowTemplate.Height = 28;
			this.Teacher_List_Gr.Size = new System.Drawing.Size(708, 239);
			this.Teacher_List_Gr.TabIndex = 3;
			// 
			// Tea_Edit_Bo
			// 
			this.Tea_Edit_Bo.AutoSize = true;
			this.Tea_Edit_Bo.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.Tea_Edit_Bo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Tea_Edit_Bo.Location = new System.Drawing.Point(48, 51);
			this.Tea_Edit_Bo.Name = "Tea_Edit_Bo";
			this.Tea_Edit_Bo.Size = new System.Drawing.Size(112, 59);
			this.Tea_Edit_Bo.TabIndex = 4;
			this.Tea_Edit_Bo.Text = "ویرایش";
			this.Tea_Edit_Bo.UseVisualStyleBackColor = false;
			this.Tea_Edit_Bo.Click += new System.EventHandler(this.Tea_Edit_Bo_Click);
			// 
			// Tea_Register_bo
			// 
			this.Tea_Register_bo.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.Tea_Register_bo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Tea_Register_bo.Location = new System.Drawing.Point(230, 51);
			this.Tea_Register_bo.Name = "Tea_Register_bo";
			this.Tea_Register_bo.Size = new System.Drawing.Size(112, 59);
			this.Tea_Register_bo.TabIndex = 5;
			this.Tea_Register_bo.Text = "ثبت نام";
			this.Tea_Register_bo.UseVisualStyleBackColor = false;
			this.Tea_Register_bo.Click += new System.EventHandler(this.Tea_Register_bo_Click);
			// 
			// Tea_Show_List
			// 
			this.Tea_Show_List.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.Tea_Show_List.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Tea_Show_List.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Tea_Show_List.Location = new System.Drawing.Point(570, 51);
			this.Tea_Show_List.Name = "Tea_Show_List";
			this.Tea_Show_List.Size = new System.Drawing.Size(186, 59);
			this.Tea_Show_List.TabIndex = 6;
			this.Tea_Show_List.Text = "مشاهده معلمان";
			this.Tea_Show_List.UseVisualStyleBackColor = false;
			this.Tea_Show_List.Click += new System.EventHandler(this.Tea_Show_List_Click);
			// 
			// Tea_Delete
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Tea_Show_List);
			this.Controls.Add(this.Tea_Register_bo);
			this.Controls.Add(this.Tea_Edit_Bo);
			this.Controls.Add(this.Teacher_List_Gr);
			this.Controls.Add(this.Tea_Del_Bo);
			this.Name = "Tea_Delete";
			this.Text = "ورود معلّم";
			this.Load += new System.EventHandler(this.Tea_Delete_Load);
			((System.ComponentModel.ISupportInitialize)(this.Teacher_List_Gr)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.DataGridView Teacher_List_Gr;
		public System.Windows.Forms.Button Tea_Del_Bo;
		public System.Windows.Forms.Button Tea_Edit_Bo;
		public System.Windows.Forms.Button Tea_Register_bo;
		public System.Windows.Forms.Button Tea_Show_List;
	}
}