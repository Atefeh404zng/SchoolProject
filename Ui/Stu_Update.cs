using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolProject.Domain;
using SchoolProject.Data_Access;
using SchoolProject.Ui;

namespace SchoolProject.Ui
{
	public partial class Stu_Update : Form
	{
		public Stu_Update()
		{
			InitializeComponent();
		}

		private void Stu_Up_Save_Click(object sender, EventArgs e)
		{

			if (Student_List_Gr_Up.SelectedRows.Count == 1)
			{
				int ch_to_edit_stu = Convert.ToInt32(Student_List_Gr_Up.CurrentRow.Cells["id"].Value);

				Student Send_To_DA = new Student();
				Send_To_DA.Stu_First_Name = Stu_Up_FName.Text;
				Send_To_DA.Stu_last_Name = Stu_Up_LName.Text;
				Send_To_DA.Student_No = Stu_Up_No.Text;
				Send_To_DA.Father_No = Stu_Up_FNo.Text;
				Send_To_DA.Mother_No = Stu_Up_MNo.Text;

				bool Result_Up = StudentDA.Edit_Stu_byid(ch_to_edit_stu, Send_To_DA);
				if (Result_Up)
				{
					MessageBox.Show("Edited");
				}
				else
				{
					MessageBox.Show("Not Edited");
				}
			}
			else { MessageBox.Show("Please Select A Row"); }

			this.Stu_Update_Load(sender, e);

		}

		private void Stu_Update_Load(object sender, EventArgs e)
		{
			Student_List_Gr_Up.DataSource = StudentDA.GetAllStudent();
		}

		private void Stu_Up_Edit_Click(object sender, EventArgs e)
		{ 

			if (Student_List_Gr_Up.RowCount > 0)
			{
				int ch_to_show = Convert.ToInt32(Student_List_Gr_Up.CurrentRow.Cells["id"].Value);

				var S_R = StudentDA.Stu_Show(ch_to_show);
				Stu_Up_FName.Text = S_R.Stu_First_Name;
				Stu_Up_LName.Text = S_R.Stu_last_Name;
				Stu_Up_No.Text = S_R.Student_No;
				Stu_Up_MNo.Text = S_R.Mother_No;
				Stu_Up_FNo.Text = S_R.Father_No;
			}
		}
	}
}

