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
	public partial class TeacherForm : Form
	{
		public TeacherForm()
		{
			InitializeComponent();
		}

		private void TeacherForm_Load(object sender, EventArgs e)
		{
			List<Course> Course_Re = CourseDA.GetAllCourse();
			int za = Course_Re.Count();
			for (int t = 0; t < za; t++)
			{
				Course_Select_Co.Items.Add(Course_Re[t].Course_name);
			}
		}

		private void Show_Stu_ByCourse_Click(object sender, EventArgs e)
		{

			int cid = Course_Select_Co.SelectedIndex + 1;
			Stu_List_ByCourse_Gr.DataSource = StudentCourseDA.Search_ById(cid);
		}

		private void Add_Mark_From_Bo_Click(object sender, EventArgs e)
		{
			int adMrk = Course_Select_Co.SelectedIndex + 1;
			if (Stu_List_ByCourse_Gr.RowCount > 0)
			{
				int Ch_To_Add_Mark = Convert.ToInt32(Stu_List_ByCourse_Gr.CurrentRow.Cells["id"].Value);

				if (Add_Mark_txt.Text == string.Empty)
				{ MessageBox.Show("Please Write A Number"); }
				else
				{
					string MARK = Add_Mark_txt.Text;
					int ConVErt = Convert.ToInt32(MARK);
					if (MARK == null)
					{
						MessageBox.Show("Add a Number");
					}
					bool nemidunam = StudentCourseDA.ADM(Ch_To_Add_Mark, adMrk, ConVErt);
					if (nemidunam)
					{
						MessageBox.Show("Mark Added");
					}
					else
					{
						MessageBox.Show("Mark Not Added");
					}
				}
			}
			else
			{
				MessageBox.Show("Please Select A Row");
			}
		}
	}
}
