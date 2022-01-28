using StudentApi.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentApi.Data
{
    interface IStudentRepository
    {
        List<Student> GetAllStudents();

        Student GetStudentById(int id);
        Student AddStudent(Student student);

        Student UpdateStudent(Student student);
        void DeleteStudent(int id);

    }
}
