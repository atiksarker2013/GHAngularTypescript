using GH.Model.Students;
using GH.Repository;
using GH.RequestModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GH.Service
{
   public class StudentService
    {
        private StudentRepository repository;

        public StudentService()
        {
            repository = new StudentRepository();
        }
        public bool Add(Student student)
        {
            repository = new StudentRepository();
            return repository.Add(student);
        }

        //public List<Student> Search(StudentRequestModel request)
        //{
        //    this.repository.
        //}
    }
}
