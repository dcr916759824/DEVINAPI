using OfficeOpenXml.FormulaParsing.LexicalAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Security;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Authorize]
    public class UserController : ApiController
    {
        private User[] users = new User[] { new User { Id = 1, Name = "Haleemah Redfern",
            Email = "email1@mail.com", Phone = "01111111", Role = 1 },
            new User { Id = 2, Name = "Aya Bostock", Email = "email2@mail.com",
                Phone = "01111111", Role = 1 }, new User { Id = 3, Name = "Sohail Perez",
                    Email = "email3@mail.com", Phone = "01111111", Role = 1 },
            new User { Id = 4, Name = "Merryn Peck", Email = "email4@mail.com", Phone = "15237385488", Role = 2 },
            new User { Id = 5, Name = "Cairon Reynolds", Email = "email5@mail.com", Phone = "01111111", Role = 3 } };
        // GET: api/Users[ResponseType(typeof(IEnumerable<User>))]
        [AllowAnonymous]
        public IEnumerable<User> Get() { return users; }

        // GET: api/Users/5

        public IHttpActionResult Get(int id)
        {
            var product = users.FirstOrDefault((p) => p.Id == id);
            if (product == null) { return NotFound(); }
            return Ok(product);
        }
        public string Message(int id = 1)
        {
            return "OK";
        }
        public IEnumerable<Stu> Get(string a)
        {
            return null;
        }
        // POST: api/PostAPITest
        public void Post([FromBody]string value)
        {
            //未知错误，在Jquery无法调用此模块
        }
        // PUT: api/UserControllers/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/UserControllers/5
        public void Delete(int id)
        {
        }
    }

}
