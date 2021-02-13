using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Domain
{
	public class Course
	{
		public int Id { get; set; }
		public string Course_name { get; set; }
		public virtual List<StudentCourse> Student_Course { get; set; }
	}
}
