using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolProject.Domain;
using SchoolProject.Data_Access;
using SchoolProject.Ui;


namespace SchoolProject.Data_Access
{
	public class StudentDA
	{
		public static DataBase Dbs = new DataBase();
		public static bool AddStudent(Student stu)
		{
			try
			{
				Dbs.Stu_table.Add(stu);
				Dbs.SaveChanges();
				return true;
			}
			catch { return false; }
		}
		public static List<Student> GetAllStudent()
		{
			return Dbs.Stu_table.ToList();
		}
		public static bool Edit_Stu_byid(int g, Student k)
		{
			try
			{
				Student Comfuse = Dbs.Stu_table.Where(i => i.Id == g).First();
				Comfuse.Stu_First_Name = k.Stu_First_Name;
				Comfuse.Stu_last_Name = k.Stu_last_Name;
				Comfuse.Student_No = k.Student_No;
				Comfuse.Father_No = k.Father_No;
				Comfuse.Mother_No = k.Mother_No;
				Dbs.SaveChanges();
				return true;
			}
			catch { return false; }
		}
		public static bool Del_Stu_byId(int S)
		{
			try
			{
				
				bool De = StudentCourseDA.Del_Stu_Cou_Byid(S);
				if (De)
				{
					var Stu_del = Dbs.Stu_table.First(DE => DE.Id == S);
					Dbs.Stu_table.Remove(Stu_del);
					Dbs.SaveChanges();
					return true;
				}
				return false;
			}
			catch { return false; }
		}

		public static Student Stu_Show(int Stu_id)
		{
			var Stu_refer = Dbs.Stu_table.Where(r => r.Id == Stu_id).First();
			return Stu_refer;
		}

		public static Student GetId(int j)
		{
			Student To_Re = Dbs.Stu_table.Where(t => t.Id == j).First();

			return To_Re;
		}
	}
}
