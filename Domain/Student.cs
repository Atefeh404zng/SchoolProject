using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SchoolProject.Domain
{
	public class Student
	{
		public int Id{ get; set; }
		public string Stu_First_Name { get; set; }
		public string Stu_last_Name { get; set; }
		public string Student_No { get; set; }
		public string Father_No { get; set; }
		public string Mother_No{ get; set; }

		public virtual List<StudentCourse> Student_Course { get; set; }
		
	}
}
