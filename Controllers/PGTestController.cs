using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class PGTestController : ApiController
    {
        // GET: api/PGTest
        public IEnumerable<string> Get()
        {
            string sql = "SELECT tenant_code,code,name,* FROM auth_user_infobase;";
            DataTable db = SQLHelper.ExecuteDataTable(sql);
            int a = SQLHelper.ExecuteSQL(sql);
            string s = db.Rows[0].Table.ToString();
            return new string[] { "value1", "value2" };
        }

        // GET: api/PGTest/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/PGTest
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/PGTest/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/PGTest/5
        public void Delete(int id)
        {
        }
    }
}
