using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
   
    public class PostAPITestController : ApiController
    {
        private User[] users = new User[] { new User { Id = 1, Name = "Haleemah Redfern",
            Email = "email1@mail.com", Phone = "01111111", Role = 1 },
            new User { Id = 2, Name = "Aya Bostock", Email = "email2@mail.com",
                Phone = "01111111", Role = 1 }, new User { Id = 3, Name = "Sohail Perez",
                    Email = "email3@mail.com", Phone = "01111111", Role = 1 },
            new User { Id = 4, Name = "Merryn Peck", Email = "email4@mail.com", Phone = "15237385488", Role = 2 },
            new User { Id = 5, Name = "Cairon Reynolds", Email = "email5@mail.com", Phone = "01111111", Role = 3 } };
        // GET: api/PostAPITest
        public IEnumerable<User> Get()
        {
            return users;
        }

        // GET: api/PostAPITest/5
        public IHttpActionResult Get(int id)
        {
            var product = users.FirstOrDefault((p) => p.Id == id);
            if (product == null) { return NotFound(); }
            return Ok(product);
        }

        // POST: api/PostAPITest
        [Authorize]
        public string  Post([FromBody]User value)
        {
            string message = "";
            if (!string.IsNullOrEmpty ( value.Name))
            {
                 message = value.Name+"添加成功";
                //Post 逻辑事件  插入数据操作 或者逻辑操作
                //......
            }
            else 
             message = "NO，传递名字格式不正确";
            return message;
        }

        // PUT: api/PostAPITest/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/PostAPITest/5
        public void Delete(int id)
        {
        }
    }
}
