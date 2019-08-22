using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;

namespace PhoneAPI_bt01
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<Phone> Get()
        {
            //return new string[] { "Hello", "World" };
            var scheme = new DBFirstDemoEntities();
            var phones = scheme.Phones;

            foreach(var item in phones)
            {
                yield return item;
            }
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
