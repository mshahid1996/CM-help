using C.M_HelpLine.data;
using C.M_HelpLine.Models;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace C.M_HelpLine.Controllers
{
    [RoutePrefix("api/Complain")]
    public class ComplainController : ApiController

    {
       
        ApplicationDbContext db = new ApplicationDbContext();

        [Route("GetComplain")]
        [HttpGet]
        public IEnumerable<UserComplain> GetUserComplain()
        {
            var res = db.ComplainTable.ToList();
            return res;
        }

        [Route("PostComplain")]
        [HttpPost]
        public IHttpActionResult addUserComplain(UserComplain emp)
        {
            var res = db.ComplainTable.Add(emp);
            db.SaveChanges();
            return Ok(emp);
        }
        [Route("DeleteComplain")]
        [HttpDelete]

        public IHttpActionResult DeleteUserComplain(int id)
        {
            var res = db.ComplainTable.Find(id);
            if (res == null)
            {
                return BadRequest("Id not Found");
            }
            db.ComplainTable.Remove(res);
            db.SaveChanges();
            return Ok();

        }
      
    }
}
