using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcApplication4.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values

        /// <summary>
        /// Obtener valor
        /// </summary>
        /// <remarks>Obtener valores</remarks>
        /// <response code="400">Bad request</response>
        /// <response code="500">Internal Server Error</response>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        /// <summary>
        /// Obtener valor por id
        /// </summary>
        ///<param name="id">id</param>
        /// <remarks>Obtener valor</remarks>
        /// <response code="400">Bad request</response>
        /// <response code="500">Internal Server Error</response>
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