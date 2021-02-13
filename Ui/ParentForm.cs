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

	public partial class ParentForm : Form
	{
		DataBase DD = new DataBase();
		public ParentForm()
		{
			InitializeComponent();
		}
		private void Show_ByCourse_Click(object sender, EventArgs e)
		{

			int STUIDD = Convert.ToInt32(student_list_gr.CurrentRow.Cells["id"].Value);
			var GST = StudentDA.Stu_Show(STUIDD);
			var help = (from sc1 in DD.Stu_Cou_table
						join s in DD.Stu_table on sc1.StudentId equals s.Id
						join c in DD.Cou_table on sc1.CourseId equals c.Id
						where sc1.StudentId == STUIDD
						select new
						{
							//s.Stu_First_Name,
							//s.Stu_last_Name,
							c.Course_name,
							sc1.Mark,
						}).ToList();
			Course_List_Gr.DataSource = help;
		}

		private void ParentForm_Load(object sender, EventArgs e)
		{
			student_list_gr.DataSource = StudentDA.GetAllStudent();
		}

		private void student_list_gr_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}