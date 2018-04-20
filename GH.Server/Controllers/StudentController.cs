using GH.Model.Students;
using GH.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace GH.Server.Controllers
{
    [EnableCors(origins: "http://localhost:10202", headers: "*", methods: "*")]
    public class StudentController : ApiController
    {
        public IHttpActionResult Post(Student student)
        {
            StudentService service = new StudentService();
            var add = service.Add(student);
            return this.Ok(add);

        }
    }
}
