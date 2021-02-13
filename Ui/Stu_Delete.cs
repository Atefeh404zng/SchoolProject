using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SchoolProject.Data_Access;

namespace SchoolProject.Ui
{
	public partial class Stu_Delete : Form
	{
		public Stu_Delete()
		{
			InitializeComponent();
		}

		private void Delete_Student_Load(object sender, EventArgs e)
		{

		}
		private void button1_Click(object sender, EventArgs e)
		{
			if (Student_List_Gr.SelectedRows.Count == 1)
			{
				int ch_to_del_stu = Convert.ToInt32(Student_List_Gr.CurrentRow.Cells["id"].Value);
				if (StudentDA.Del_Stu_byId(ch_to_del_stu))
				{
					MessageBox.Show("Deleted");
				}
				else { MessageBox.Show("Not Deleted"); }
			}
			else MessageBox.Show("Please Select A Row");


			this.Stu_Show_List_Click(sender, e);


		}

		private void Stu_Edit_Bo_Click(object sender, EventArgs e)
		{

			var Edit_Stu = new Stu_Update().ShowDialog();
			this.Stu_Show_List_Click(sender, e);

		}

		private void Stu_Show_List_Click(object sender, EventArgs e)
		{
			Student_List_Gr.DataSource = StudentDA.GetAllStudent();
		}

		private void Stu_Register_bo_Click(object sender, EventArgs e)
		{
			var S_register = new Stu_Register().ShowDialog();
			this.Stu_Show_List_Click(sender, e);
		}
	}
}
