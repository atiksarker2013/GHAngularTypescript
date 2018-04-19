﻿using GH.Model.Students;
using GH.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GH.Server.Controllers
{
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
