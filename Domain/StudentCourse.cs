using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Domain
{
	public class StudentCourse
	{
		public int Id { get; set; }
		public int StudentId { get; set; }
		public virtual Student STU { get; set; }

		public int CourseId { get; set; }
		public virtual Course COU { get; set; }

		public int  Mark { get; set; }
	}
}
