using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolProject.Domain;

namespace SchoolProject.Data_Access
{
	public class TeacherDA
	{
		static DataBase DbsT = new DataBase();
		public static List<Teacher> GetAllTeachers()
		{
			return DbsT.Tea_table.ToList();
		}
		public static bool Del_Tea_byId(int R) 
		{
			try
			{
				var Tea_del = DbsT.Tea_table.First(DE => DE.Id == R);
				DbsT.Tea_table.Remove(Tea_del);
				DbsT.SaveChanges();
				return true;
			}
			catch { return false; }
		}
		public static bool AddTeacher(Teacher Tea)
		{
			try
			{
				DbsT.Tea_table.Add(Tea);
				DbsT.SaveChanges();
				return true;
			}
			catch { return false; }
		}
		public static bool Edit_Tea_byid(int h,Teacher m)
		{
			try
			{
				Teacher T_E = DbsT.Tea_table.Where(f => f.Id == h).First();
				T_E.Tea_First_Name = m.Tea_First_Name;
				T_E.Tea_Last_Name = m.Tea_Last_Name;
				T_E.Tea_Course = m.Tea_Course;
				DbsT.SaveChanges();
				return true;
			}
			catch { return false; }
		}
		public static Teacher Tea_Show(int Tea_Id)
		{
			var Tea_refer = DbsT.Tea_table.First(y => y.Id == Tea_Id);
			return Tea_refer;
		}
	}
}