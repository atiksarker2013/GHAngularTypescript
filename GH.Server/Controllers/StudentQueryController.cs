using GH.Model.Students;
using GH.RequestModel;
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
    public class StudentQueryController : ApiController
    {

        public IHttpActionResult Post(StudentRequestModel request)
        {
            StudentService service = new StudentService();
            List<Student> students = service.Search(request);
            return this.Ok(students);
        }
    }
}
