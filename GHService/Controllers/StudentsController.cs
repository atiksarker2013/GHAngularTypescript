using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;

namespace GHService.Controllers
{
    [EnableCors(origins: "http://localhost:10202", headers: "*", methods: "*")]
    public class StudentsController : ApiController
    {
        private GHDBEntities db = new GHDBEntities();

        // GET: api/Students
        public IQueryable<Student> GetStudents()
        {
            return db.Student;
        }

        // POST: api/Students
        [ResponseType(typeof(Student))]
        public async Task<IHttpActionResult> PostStudent(Student student)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            student.Id = Guid.NewGuid().ToString();
            db.Student.Add(student);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                //if (StudentExists(student.Id))
                //{
                //    return Conflict();
                //}
                //else
                //{
                //    throw;
                //}
            }

            return CreatedAtRoute("DefaultApi", new { id = student.Id }, student);
        }
    }
}
