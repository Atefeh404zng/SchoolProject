using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolProject.Ui
{
	public partial class StartForm : Form
	{
		public StartForm()
		{
			InitializeComponent();
		}



		private void Manager_Panel_Bo_Click(object sender, EventArgs e)
		{
			var MPB = new ManagerForm();
			MPB.Show();
		}

		private void Teacher_Panel_Bo_Click(object sender, EventArgs e)
		{
			var TPB = new TeacherForm();
			TPB.Show();
		}
		//برای والدین
		private void Parent_Panel_Bo_Click(object sender, EventArgs e)
		{
			var PPB = new ParentForm();
			PPB.Show();
		}
	}
}
