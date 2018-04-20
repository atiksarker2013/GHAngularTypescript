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
            return repository.Add(student);
        }

        public List<Student> Search(StudentRequestModel request)
        {
            IQueryable<Student> students = this.repository.Get();

            if (!string.IsNullOrEmpty(request.Name))
            {
                students = students.Where(x => x.Name.ToLower().Contains(request.Name.ToLower()));
            }

            if (!string.IsNullOrEmpty(request.Phone))
            {
                students = students.Where(x => x.Phone.ToLower().Contains(request.Name.ToLower()));
            }

            students = students.OrderBy(x=>x.Modified);
            if (request.OrderBy.ToLower() =="name")
            {
                students = request.IsAssending ? students.OrderBy(x => x.Name) : students.OrderByDescending(x => x.Name);
            }

            if (request.OrderBy.ToLower() == "phone")
            {
                students = request.IsAssending ? students.OrderBy(x => x.Phone) : students.OrderByDescending(x => x.Phone);
            }

            students = students.Skip((request.Page-1)*10).Take(request.PerPageCount);
            List<Student> list = students.ToList();
            return list;
        }
    }
}
