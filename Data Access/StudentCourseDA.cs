using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolProject.Domain;

namespace SchoolProject.Data_Access
{
	class StudentCourseDA
	{
		public static DataBase DbBe = new DataBase();
		public static bool AddStudentCourse(StudentCourse rt)
		{
			try
			{
				DbBe.Stu_Cou_table.Add(rt);
				DbBe.SaveChanges();
				return true;
			}
			catch { return false; }
		}
		public static List<StudentCourse> GetallStudentCourse()
		{
			return DbBe.Stu_Cou_table.ToList();
		}
		public static List<Student> Search_ById(int iid)
		{
			int Count = DbBe.Stu_Cou_table.Count();
			int NNu = 0;
			int cnt = 0;

			List<StudentCourse> List_Of_Stu_Cou = new List<StudentCourse>(Count);
			List<StudentCourse> As_List_Temp = GetallStudentCourse();

			List_Of_Stu_Cou.AddRange(As_List_Temp);

			for (int h = 0; h < Count; h++)
			{
				if (List_Of_Stu_Cou[h].CourseId == iid)
					cnt++;
			}
			int[] List_Of_Stu = new int[cnt];

			for (int cn = 0; cn < Count; cn++)
			{
				if (List_Of_Stu_Cou[cn].CourseId == iid)
				{
					List_Of_Stu[NNu] = List_Of_Stu_Cou[cn].StudentId;
					NNu++;
				}
			}
			int temp;
			int Size = List_Of_Stu.Length;

			List<Student> Give_SDA = new List<Student>();
			for (int e = 0; e < Size; e++)
			{
				temp = List_Of_Stu[e];
				Give_SDA.Add(StudentDA.GetId(temp));
			}
			return Give_SDA;
		}
		public static bool ADM(int sid, int cidd, int Mk)
		{
			int List_Length = DbBe.Stu_Cou_table.Count();
			//این بدبخت درست میشماره
			List<StudentCourse> List_To_Add = GetallStudentCourse();


			for (int cc = 0; cc < List_Length; cc++)
			{
				if (List_To_Add[cc].StudentId == sid && List_To_Add[cc].CourseId == cidd)
				{
					int REalId = List_To_Add[cc].Id;

					try
					{
						StudentCourse To_Save_Mark = DbBe.Stu_Cou_table.Where(Li => Li.Id == REalId).First();
						To_Save_Mark.Mark = Mk;
						DbBe.SaveChanges();
						return true;
					}
					catch { return false; }
				}
			}
			return false;
		}
		public static bool Del_Stu_Cou_Byid(int Stu__id)
		{
			int List_Lgth = DbBe.Stu_Cou_table.Count();
			List<StudentCourse> List_To_Delet = GetallStudentCourse();

			for (int InDe = 0; InDe < List_Lgth; InDe++)
			{
				if (List_To_Delet[InDe].StudentId == Stu__id)
				{
					int Mainid = List_To_Delet[InDe].Id;
					try
					{
						StudentCourse To_Delet_Stu = DbBe.Stu_Cou_table.Where(Li => Li.Id == Mainid).First();
						DbBe.Stu_Cou_table.Remove(To_Delet_Stu);
						DbBe.SaveChanges();
						return true;

					}
					catch { return false; }
				}
			}
			return false;
		}
		public static int Check_Table(int stid, int coiid)
		{
			int _Lgth_ = DbBe.Stu_Cou_table.Count();

			List<StudentCourse> List_To_check = GetallStudentCourse();

			for (int hf = 0; hf < _Lgth_; hf++)
			{
				if (List_To_check[hf].StudentId == stid && List_To_check[hf].CourseId == coiid)
				{
					return 1;
				}
			}
			return 0;
		}

		//برای والدین
		public static int GetstudentById(int zx)
		{
			StudentCourse To_use = DbBe.Stu_Cou_table.Where(ve => ve.Id == zx).First();
			return To_use.StudentId;
		}
	}
}