using SchoolProject.Data_Access;
using SchoolProject.Domain;
using System;
using System.Windows.Forms;

namespace SchoolProject.Ui
{
	public partial class Stu_Register : Form
	{
		public Stu_Register()
		{
			InitializeComponent();
		}


		private void Stu_Register_Load(object sender, EventArgs e)
		{
		}

		private void Stu_Save_form_Click(object sender, EventArgs e)
		{
			Student Student_form = new Student
			{
				Stu_First_Name = Stu_Name_form.Text,
				Stu_last_Name = Stu_Family_form.Text,
				Student_No = Stu_No_form.Text,
				Mother_No = Mo_No_form.Text,
				Father_No=Fa_No_form.Text,
			};
			bool SE = StudentDA.AddStudent(Student_form);
			if (SE)
			{
				MessageBox.Show("Successful");
			}
			else  { MessageBox.Show("Failed"); }

			
		}

		private void Stu_AddCourse_Bo_Click(object sender, EventArgs e)
		{
			//اینجا باید ارور خالی بودن دیتا بیس رو  بنویسم
			var Add_course = new Student_Add_Course().ShowDialog();
		}
	}
}
