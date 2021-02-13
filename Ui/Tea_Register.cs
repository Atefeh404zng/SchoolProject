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

namespace SchoolProject.Ui
{
	public partial class Tea_Register : Form
	{
		public Tea_Register()
		{
			InitializeComponent();
		}


		private void Tea_Save_form_Click(object sender, EventArgs e)
		{
			Teacher Teacher_form = new Teacher
			{
				Tea_First_Name = Tae_Name_form.Text,
				Tea_Last_Name = Tea_Family_form.Text,
				Tea_Course = Tea_Course_combo.Text
			};
			bool TF = TeacherDA.AddTeacher(Teacher_form);
			if (TF)
			{ MessageBox.Show("Successful"); }
			else
			{ MessageBox.Show("Failed"); }
		}

		private void Tea_Register_Load(object sender, EventArgs e)
		{

			List<Course> Tea_Give = CourseDA.GetAllCourse();
			int dc = Tea_Give.Count();
			for (int te = 0; te < dc; te++)
			{
				Tea_Course_combo.Items.Add(Tea_Give[te].Course_name);
			}
		}
	}
}
