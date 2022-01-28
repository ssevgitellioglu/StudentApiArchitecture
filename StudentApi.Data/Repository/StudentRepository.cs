using StudentApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentApi.Data.Repository
{
    public class StudentRepository : IStudentRepository
    {
        public Student AddStudent(Student student)
        {
            using (var studentDbContext = new StudentDbContext())
            {
                studentDbContext.Students.Add(student);
                studentDbContext.SaveChanges();
                return student;
            }
        }

        public void DeleteStudent(int id)
        {
            using (var studentDbContext = new StudentDbContext())
            {
                var deletedStudent = GetStudentById(id);
                studentDbContext.Students.Remove(deletedStudent);
                studentDbContext.SaveChanges();
            }
        }

        public List<Student> GetAllStudents()
        {
            using (var studentDbContext=new StudentDbContext())
            {
                return studentDbContext.Students.ToList();
            }
        }

        public Student GetStudentById(int id)
        {
            using (var studentDbContext = new StudentDbContext())
            {
                return studentDbContext.Students.Find(id);
            }
        }

        public Student UpdateStudent(Student student)
        {
            using (var studentDbContext = new StudentDbContext())
            {
                studentDbContext.Students.Update(student);
                return student;
            }
        }
    }
}
