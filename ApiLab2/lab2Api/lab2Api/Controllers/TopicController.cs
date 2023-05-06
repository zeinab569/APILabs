using lab2Api.DTO;
using lab2Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace lab2Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopicController : ControllerBase
    {
        private readonly ITIContext _db;

        public TopicController(ITIContext db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult<List<Topic>> GetAll()
        {
            //return _db.Topic.ToList();
            List<Topic> result = _db.Topic.Include(n=>n.Course).ToList();
            List<TopicCoursesDTO> topicdto = new List<TopicCoursesDTO>();
            if(result.Count > 0)
            {
                foreach (var topic in result)
                {
                    TopicCoursesDTO Tdto = new TopicCoursesDTO()
                    {
                        ID = topic.TopId,
                        TopicName = topic.TopName,
                        crs_names = topic.Course.Select(n => n.CrsName).ToList(),
                    };
                    topicdto.Add(Tdto);
                }
            }
            else
            {
                return NotFound();
            }
            return Ok(topicdto);
        }

        //[HttpGet("{id}")]
        //public ActionResult<Topic> GetTheTopic(int id)
        //{
        //    return _db.Topic.Find(id);
        //}

        [HttpGet("{id}")]
        public ActionResult<TopicCoursesDTO> GetTheTopic(int id)
        {
            Topic t1= _db.Topic.Include(t=>t.Course).FirstOrDefault(t=>t.TopId== id);
            TopicCoursesDTO topicCoursesDTO = new TopicCoursesDTO()
            {
                ID=t1.TopId,
                TopicName=t1.TopName,
                crs_names=t1.Course.Select(n=>n.CrsName).ToList(),  
            };
            //foreach (var item in t1.Course)
            //{
            //    topicCoursesDTO.crs_names.Add(item.CrsName);
            //}
            return Ok(topicCoursesDTO);
        }
    }
}
