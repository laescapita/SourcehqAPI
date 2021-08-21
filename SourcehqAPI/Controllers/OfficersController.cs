using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SourcehqAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SourcehqAPI.Controllers
{
    [Route("api/officers")]
    [ApiController]
    public class OfficersController : ControllerBase
    {
        // GET: api/<SourcePageController>
        [HttpGet]
        [Route("getAllOfficers")]
        public IEnumerable<OfficerModel> Get()
        {
            //using var connection = new sqlConnection(connectionString);
            List<OfficerModel> officer = null; //connection.QueryAll<OfficerModel>().ToList();
            return officer;
        }

        // GET api/<SourcePageController>/5
        [HttpGet]
        [Route("getOfficer/{id}")]
        public OfficerModel Get(int id)
        {
            //using var connection = new sqlConnection(connectionString);
            OfficerModel officer = null; //connection.Query<OfficerModel>(o => o.OfficerID == id).FirstOrDefault();
            return officer;
        }

        // POST api/<SourcePageController>
        [HttpPost]
        [Route("postOfficer")]
        public void Post(OfficerModel officer)
        {
            //using var connection = new sqlConnection(connectionString);
            //query connection to post 
        }

        // PUT api/<SourcePageController>/5
        [HttpPut]
        [Route("putOfficer")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SourcePageController>/5
        [HttpDelete]
        [Route("deleteOfficer")]
        public void Delete(int id)
        {
            //using var connection = new sqlConnection(connectionString);
            //query connection to delete 
        }
    }
}
