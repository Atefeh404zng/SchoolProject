using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolProject.Domain;

namespace SchoolProject.Data_Access
{
	class CourseDA
	{
		public static DataBase DbsC = new DataBase();
		
		public static bool AddCourse(Course t)
		{
			try
			{
				DbsC.Cou_table.Add(t);
				DbsC.SaveChanges();
				return true;
			}
			catch { return false; }
			
		}
		public static List<Course> GetAllCourse()
		{
			return DbsC.Cou_table.ToList();
		}
		//برای والدین
		public static Course GetByIdCourse(int zx)
		{
			Course To_use = DbsC.Cou_table.First(ve => ve.Id == zx);
			return To_use;
		}

	}
}