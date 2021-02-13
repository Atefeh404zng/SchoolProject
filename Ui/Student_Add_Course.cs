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
	public partial class Student_Add_Course : Form
	{
		public Student_Add_Course()
		{
			InitializeComponent();
		}
		private void Stu_AddCourse_Combo_Click(object sender, EventArgs e)
		{
			if (Student_List_Gr_AddCourse.RowCount > 0)
			{
				StudentCourse SAC = new StudentCourse();
				int SID = Convert.ToInt32(Student_List_Gr_AddCourse.CurrentRow.Cells["id"].Value);
				int CID = Stu_Course_Combo.SelectedIndex + 1;
				SAC.CourseId = CID;
				SAC.StudentId = Convert.ToInt32(Student_List_Gr_AddCourse.CurrentRow.Cells["id"].Value);

				if (StudentCourseDA.Check_Table(SID, CID) != 1)
				{
					bool SC = StudentCourseDA.AddStudentCourse(SAC);

					if (SC)
					{
						MessageBox.Show("Course Added");
					}
					else { MessageBox.Show("Course Not Added"); }
				}
				else { MessageBox.Show("This student have this course"); }
			}
		}
		private void Student_Add_Course_Load(object sender, EventArgs e)
		{
			Student_List_Gr_AddCourse.DataSource = StudentDA.GetAllStudent();
			List<Course> Stu_Give = CourseDA.GetAllCourse();
			int dc = Stu_Give.Count();
			for (int q = 0; q < dc; q++)
			{
				Stu_Course_Combo.Items.Add(Stu_Give[q].Course_name);
			}

		}
	}
}

