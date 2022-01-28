using StudentApi.Entities;
using System;
using System.Collections.Generic;

namespace StıdentApi.Business
{
    public interface IStudentService
    {
        List<Student> GetAllStudents();
        Student GetStudentsById(int id);
        Student AddStudent(Student student);
        Student UpdateStudent(Student student);
        void DeleteStudent(int id);

    }
}
