using LeHuynhMinh_5951071059.Models;
using Swashbuckle.Swagger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LeHuynhMinh_5951071059.Controllers
{
    public class StudentController : ApiController
    {
        // GET: api/Student
        public IEnumerable<StudentInfo> Get()
        {
            var stInfList = new List<StudentInfo>();
            for (int i = 0; i < 10; i++)
            {
                var stInfo = new StudentInfo
                {
                    stName = "Lê Huỳnh Minh",
                    stId = "5951071059",
                    stClass = "CQ.59.CNTT",
                    stNo = i,
                    stBirthYear = 2000,
                    RandomNumber = i * 2 / 3 + 4 - 5
                };
                stInfList.Add(stInfo);
            }
            return stInfList;
        }

        // GET: api/Weather/5
        public StudentInfo Get(int id)
        {
            return new StudentInfo
            {
                stName = "Lê Huỳnh Minh",
                stId = "5951071059",
                stClass = "CQ.59.CNTT",
                stNo = id,
                stBirthYear = 2000,
                RandomNumber = id * 2 / 3 + 4 - 5
            };
        }
    }
}
