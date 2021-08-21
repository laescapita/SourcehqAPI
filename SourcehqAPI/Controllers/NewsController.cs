using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SourcehqAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SourcehqAPI.Controllers
{
    [Route("api/news")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        // GET: api/<RoboticsPageController>
        [HttpGet]
        [Route("getAllSourceNews")]
        public IEnumerable<SourceNewsModel> GetSourceNews()
        {
            //using var connection = new sqlConnection(connectionString);
            List<SourceNewsModel> news = null; //connection.QueryAll<NewsModel>().ToList();
            return news;
        }

        [HttpGet]
        [Route("getAllRobotNews")]
        public IEnumerable<RobotNewsModel> GetRobotNews()
        {
            //using var connection = new sqlConnection(connectionString);
            List<RobotNewsModel> news = null; //connection.QueryAll<NewsModel>().ToList();
            return news;
        }

        // GET api/<RoboticsPageController>/5
        [HttpGet]
        [Route("getSourceNews/{id}")]
        public SourceNewsModel GetSourceNews(int id)
        {
            //using var connection = new sqlConnection(connectionString);
            SourceNewsModel news = null; //connection.Query<OfficerModel>(o => o.OfficerID == id).FirstOrDefault();
            return news;
        }

        [HttpGet]
        [Route("getSourceNews/{id}")]
        public RobotNewsModel GetRobotNews(int id)
        {
            //using var connection = new sqlConnection(connectionString);
            RobotNewsModel news = null; //connection.Query<OfficerModel>(o => o.OfficerID == id).FirstOrDefault();
            return news;
        }

        // POST api/<RoboticsPageController>
        [HttpPost]
        [Route("postSourceNews")]
        public void PostSourceNews(SourceNewsModel news)
        {
            //using var connection = new sqlConnection(connectionString);
            //query connection to post 
        }

        [HttpPost]
        [Route("postRobotNews")]
        public void PostRobotNews(SourceNewsModel news)
        {
            //using var connection = new sqlConnection(connectionString);
            //query connection to post 
        }

        // PUT api/<RoboticsPageController>/5
        [HttpPut]
        [Route("putSourceNews")]
        public void PutSourceNews(int id, [FromBody] string value)
        {
        }

        [HttpPut]
        [Route("putRobotNews")]
        public void PutRobotNews(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RoboticsPageController>/5
        [HttpDelete]
        [Route("deleteSourceNews")]
        public void DeleteSourceNews(int id)
        {
            //using var connection = new sqlConnection(connectionString);
            //query connection to delete 
        }

        [HttpDelete]
        [Route("deleteRobotNews")]
        public void DeleteRobotNews(int id)
        {
            //using var connection = new sqlConnection(connectionString);
            //query connection to delete 
        }
    }
}
