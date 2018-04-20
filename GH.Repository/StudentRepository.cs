using GH.Model;
using GH.Model.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GH.Repository
{
   public class StudentRepository
    {
        private BusinessDbContext db;

        public StudentRepository()
        {
            db = new BusinessDbContext();
        }
        public bool Add(Student student)
        {
            student.Id = Guid.NewGuid().ToString();
            this.db.Student.Add(student);
            int saveChanges = this.db.SaveChanges();
            return saveChanges > 0;
        }

        public IQueryable<Student> Get()
        {
            return this.db.Student.AsQueryable();
        }
    }
}
