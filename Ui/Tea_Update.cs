using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolProject.Data_Access;
using SchoolProject.Domain;

namespace SchoolProject.Ui
{
	public partial class Tea_Update : Form
	{
		public Tea_Update()
		{
			InitializeComponent();
		}

		private void Tea_Update_Load(object sender, EventArgs e)
		{
			Teacher_List_Gr_Up.DataSource = TeacherDA.GetAllTeachers();

			List<Course> Tea_Give = CourseDA.GetAllCourse();
			int dc = Tea_Give.Count();
			for (int te = 0; te < dc; te++)
			{
				Tea_edit_course_combo.Items.Add(Tea_Give[te].Course_name);
			}
		}
		private void Tea_Up_Save_Click(object sender, EventArgs e)
		{
			if (Teacher_List_Gr_Up.SelectedRows.Count == 1)
			{
				int ch_to_edit_Tea = Convert.ToInt32(Teacher_List_Gr_Up.CurrentRow.Cells["id"].Value);
				Teacher Tea_send = new Teacher();
				Tea_send.Tea_First_Name = Tea_Up_Fname.Text;
				Tea_send.Tea_Last_Name = Tea_Up_Lname.Text;
				Tea_send.Tea_Course = Tea_edit_course_combo.Text;
				bool TEResult = TeacherDA.Edit_Tea_byid(ch_to_edit_Tea, Tea_send);
				if(TEResult)
				{
					MessageBox.Show("Edited");
				}
				else
				{
					MessageBox.Show("Not Edited");
				}
			}
			else { MessageBox.Show("Please Select A Row"); }

			this.Tea_Update_Load(sender, e);
		}

		private void Tea_Up_Edit_Click(object sender, EventArgs e)
		{
			if (Teacher_List_Gr_Up.RowCount > 0)
			{
				int CH_To_Show = Convert.ToInt32(Teacher_List_Gr_Up.CurrentRow.Cells["id"].Value);

				var T_R = TeacherDA.Tea_Show(CH_To_Show);
				Tea_Up_Fname.Text = T_R.Tea_First_Name;
				Tea_Up_Lname.Text = T_R.Tea_Last_Name;
				Tea_edit_course_combo.Text = T_R.Tea_Course;
			}
		}
	}
}
