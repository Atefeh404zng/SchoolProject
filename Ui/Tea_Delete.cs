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

namespace SchoolProject.Ui
{
	public partial class Tea_Delete : Form
	{
		public Tea_Delete()
		{
			InitializeComponent();
		}


		private void Tea_Delete_Load(object sender, EventArgs e)
		{
		
		}

		private void Tea_Del_Bo_Click(object sender, EventArgs e)
		{
			if(Teacher_List_Gr.SelectedRows.Count==1)
			{
				int Ch_To_Del_Tea = Convert.ToInt32(Teacher_List_Gr.CurrentRow.Cells["id"].Value);
				if (TeacherDA.Del_Tea_byId(Ch_To_Del_Tea))
				{
					MessageBox.Show("Deleted");
				}
				else { MessageBox.Show("Not Deleted"); }
			}
			else MessageBox.Show("Please Select A Row");

			this.Tea_Show_List_Click(sender, e);
		}

		private void Tea_Edit_Bo_Click(object sender, EventArgs e)
		{
			var Edit_Tea = new Tea_Update().ShowDialog();
			this.Tea_Show_List_Click(sender, e);
		}

		private void Tea_Register_bo_Click(object sender, EventArgs e)
		{
			var T_register = new Tea_Register().ShowDialog();
			this.Tea_Show_List_Click(sender, e);
		}

		private void Tea_Show_List_Click(object sender, EventArgs e)
		{
			Teacher_List_Gr.DataSource = TeacherDA.GetAllTeachers();
		}
	}
}
