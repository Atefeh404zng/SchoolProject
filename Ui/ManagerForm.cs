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
	public partial class ManagerForm : Form
	{
		public ManagerForm()
		{
			InitializeComponent();
		}

		private void Manager2_Bo_Click(object sender, EventArgs e)
		{
			var Tea_info= new Tea_Delete();
			Tea_info.Show();
			
		}

		private void Manager1_Bo_Click(object sender, EventArgs e)
		{
			var Stu_info = new Stu_Delete();
			Stu_info.Show();
		}
	}
}
