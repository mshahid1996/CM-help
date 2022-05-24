using C.M_HelpLine.data;
using C.M_HelpLine.Models;
using DocumentFormat.OpenXml.Math;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace C.M_HelpLine.Controllers
{
    public class RegistrationController : ApiController
    {
        [RoutePrefix("api/Registration")]
        public class ValuesController : ApiController
        {

            ApplicationDbContext db = new ApplicationDbContext();
            // GET api/values
            [Route("GetUsers")]
            [HttpGet]
            public IEnumerable<User> GetUser()
            {
                var res = db.RegistTable.ToList();
                return res;
            }

            // GET api/values/5
            [Route("GetUser")]
            [HttpGet]
            public IHttpActionResult GetUser(int Id)
            {
                var res = db.RegistTable.Find(Id);
                if (res == null)
                {
                    return BadRequest("Id is not found");
                }
                return Ok(res);
            }

            // POST api/values
            [Route("PostUser")]
            [HttpPost]
            public IHttpActionResult addUsers(User emp)
            {
                var res = db.RegistTable.Add(emp);
                db.SaveChanges();
                return Ok(emp);
            }

            // PUT api/values/5
            [Route("PutUser")]
            [HttpPut]
            public IHttpActionResult UpdateUser(User Emp)
            {
                var existingEmployee = db.RegistTable.Where(gt => gt.id == Emp.id).FirstOrDefault<User>();
                if (existingEmployee != null)
                {
                    existingEmployee.Name = Emp.Name;
                    existingEmployee.Address = Emp.Address;
                    existingEmployee.Number = Emp.Number;
                    existingEmployee.Adhar = Emp.Adhar;
                    existingEmployee.Email = Emp.Email;
                    db.SaveChanges();
                }
                return Ok();
            }

            // DELETE api/values/5
            [Route("DeleteUser")]
            [HttpDelete]

            public IHttpActionResult DeleteUser(int id)
            {
                var res = db.RegistTable.Find(id);
                if (res == null)
                {
                    return BadRequest("Id not Found");
                }
                db.RegistTable.Remove(res);
                db.SaveChanges();
                return Ok();

            }

            // POST api/values
            [Route("PostOfficer")]
            [HttpPost]
            public IHttpActionResult Officer(Officer ad)
            {
                var existLogin = db.Officers.Where(a => a.Email == ad.Email && a.password == ad.password).FirstOrDefault();
                if (existLogin == null)
                {
                    BadRequest("Invalid");
                }
                else
                {
                    BadRequest("Success");
                }
                return Ok(existLogin);
            }

            // POST api/values
            [Route("PostUserLogin")]
            [HttpPost]
            public IHttpActionResult UserLogin(UserLogin ad)
            {
                var existLogin = db.RegistTable.Where(a => a.Email == ad.Email && a.Password == ad.Password).FirstOrDefault();
                if (existLogin == null)
                {
                    BadRequest("Invalid");
                }
                else
                {
                    BadRequest("Success");
                }
                return Ok(existLogin);
            }

        }
    }
}

