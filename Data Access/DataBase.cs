using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SchoolProject.Domain;

namespace SchoolProject.Data_Access
{
	public class DataBase : DbContext
	{
		public DbSet<Student> Stu_table { set; get; }
		public DbSet<Teacher> Tea_table { set; get; }
		public DbSet<Course> Cou_table { get; set ; }
		public DbSet<StudentCourse> Stu_Cou_table { get; set; }
	}
}
