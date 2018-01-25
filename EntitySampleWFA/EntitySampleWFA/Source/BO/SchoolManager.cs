using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;

namespace EntitySampleWFA.Source.BO
{
    internal class SchoolManager
    {
        public List<StudentN> AllStudents()
        {
            try
            {
                List<StudentN> students = null;
                try
                {
                    using (SchoolContext sch = new SchoolContext())
                    {
                        students = (from t in sch.Students
                                    select new StudentN
                                        {
                                            Id = t.Id,
                                            Name = t.Name,
                                            DateOfBirth = t.DateOfBirth,
                                            Weight = t.Weight,
                                            Height = t.Height,
                                            StandardId = t.StandardId,
                                            TeacherId = t.TeacherId
                                        }).ToList<StudentN>();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                return students;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<TeacherN> AllTeachers()
        {
            List<TeacherN> teachers = null;
            try
            {
                using (SchoolContext sch = new SchoolContext())
                {
                    teachers = (from t in sch.Teachers select new TeacherN { Id = t.Id, Name = t.Name }).ToList<TeacherN>();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return teachers;
        }

        public List<StandardN> AllStandarts()
        {
            List<StandardN> result = null;
            try
            {
                using (SchoolContext sch = new SchoolContext())
                {
                    result = (from s in sch.Standards select new StandardN { Id = s.Id, Name = s.Name }).ToList<StandardN>();
                }
            }
            catch (Exception)
            {
            }
            return result;
        }

        public Standard GetStandardById(int id)
        {
            Standard result = null;
            try
            {
                using (SchoolContext schCntxt = new SchoolContext())
                {
                    result = (from s in schCntxt.Standards where s.Id == id select s).FirstOrDefault<Standard>();
                    //   result = schCntxt.Standards.Find(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        public void AddStandard(Standard standard)
        {
            try
            {
                using (SchoolContext schCntxt = new SchoolContext())
                {
                    schCntxt.Standards.Add(standard);
                    schCntxt.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateStandard(Standard standard)
        {
            try
            {
                using (SchoolContext schCntxt = new SchoolContext())
                {
                    schCntxt.Entry(standard).State = System.Data.Entity.EntityState.Modified;
                    schCntxt.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool IsStandardInNotUse(int standardId)
        {
            bool result = false;
            try
            {
                using (SchoolContext sch = new SchoolContext())
                {
                    DbRawSqlQuery<Student> sts = sch.Database.SqlQuery<Student>("Select * From [SchoolSchem].[Students] Where StandardId=@StandardId;", new SqlParameter("@StandardId", standardId));
                    int i = sts.ToList<Student>().Count;
                    result = i == 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        public void DeleteStandard(int id)
        {
            try
            {
                Standard standard = GetStandardById(id);
                using (SchoolContext schCntxt = new SchoolContext())
                {
                    schCntxt.Entry(standard).State = System.Data.Entity.EntityState.Deleted;
                    schCntxt.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Teacher GetTeacherById(int id)
        {
            Teacher result = null;
            try
            {
                using (SchoolContext schCntxt = new SchoolContext())
                {
                    result = (from s in schCntxt.Teachers where s.Id == id select s).FirstOrDefault();
                    //   result = schCntxt.Standards.Find(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        public void AddTeacher(Teacher teacher)
        {
            try
            {
                using (SchoolContext schCntxt = new SchoolContext())
                {
                    schCntxt.Teachers.Add(teacher);
                    schCntxt.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateTeacher(Teacher teacher)
        {
            try
            {
                using (SchoolContext schCntxt = new SchoolContext())
                {
                    schCntxt.Entry(teacher).State = System.Data.Entity.EntityState.Modified;
                    schCntxt.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteTeacher(int id)
        {
            try
            {
                Teacher teacher = GetTeacherById(id);
                using (SchoolContext schCntxt = new SchoolContext())
                {
                    schCntxt.Entry(teacher).State = System.Data.Entity.EntityState.Deleted;
                    schCntxt.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool IsTeacherNotInUse(int id)
        {
            bool result = false;
            try
            {
                using (SchoolContext sch = new SchoolContext())
                {
                    DbRawSqlQuery<Teacher> sts = sch.Database.SqlQuery<Teacher>("Select * From [SchoolSchem].[Students] Where TeacherId=@TeacherId;", new SqlParameter("@TeacherId", id));
                    int i = sts.ToList<Teacher>().Count;
                    result = i == 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        public Student GetStudentById(int id)
        {
            Student result = null;
            try
            {
                using (SchoolContext schCntxt = new SchoolContext())
                {
                    result = (from s in schCntxt.Students where s.Id == id select s).FirstOrDefault();
                    //   result = schCntxt.Standards.Find(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        public void AddStudent(Student student)
        {
            try
            {
                using (SchoolContext schCntxt = new SchoolContext())
                {
                    schCntxt.Students.Add(student);
                    schCntxt.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateStudent(Student student)
        {
            try
            {
                using (SchoolContext schCntxt = new SchoolContext())
                {
                    schCntxt.Entry(student).State = System.Data.Entity.EntityState.Modified;
                    schCntxt.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteStudent(int id)
        {
            try
            {
                Student student = GetStudentById(id);
                using (SchoolContext schCntxt = new SchoolContext())
                {
                    schCntxt.Entry(student).State = System.Data.Entity.EntityState.Deleted;
                    schCntxt.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}