using StudentApi.Data.Repository;
using StudentApi.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StıdentApi.Business.Service
{
    public class ServiceManager : IStudentService
    {
        private StudentRepository _studentRepository;
        public ServiceManager(StudentRepository studentRepository)
        {
            _studentRepository =studentRepository;
        }
        public Student AddStudent(Student student)
        {
            return _studentRepository.AddStudent(student);
        }

        public void DeleteStudent(int id)
        {
             _studentRepository.DeleteStudent(id);
        }

        public List<Student> GetAllStudents()
        {
            return _studentRepository.GetAllStudents();
        }

        public Student GetStudentsById(int id)
        {
            if (id > 0)
            {
                return _studentRepository.GetStudentById(id);
            }
            throw new Exception("Id can not be less than 1");
           
        }

        public Student UpdateStudent(Student student)
        {
            return _studentRepository.UpdateStudent(student);
        }
    }
}
