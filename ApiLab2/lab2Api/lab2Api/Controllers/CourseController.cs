using lab2Api.DTO;
using lab2Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace lab2Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ITIContext _db;

        public CourseController(ITIContext db)
        {
            _db = db;
        }

        
        [HttpGet]
        public ActionResult<List<Course>> GetAllCourse()
        {
            //return _db.Course.ToList();
           
            List<Course> result = _db.Course.Include(n=>n.Top).ToList();
            List<CourseTopicDTO> courseDTO = new List<CourseTopicDTO>();  
            if (result.Count() > 0)
            {             
                foreach (var crs in result)
                {
                    CourseTopicDTO crsdto = new CourseTopicDTO()
                    {
                        Id = crs.CrsId,
                        Cr_name = crs.CrsName,
                        Cr_duration = crs.CrsDuration,
                        TopicName = crs.Top.TopName,
                        Topicid=crs.TopId,
                    };
                    courseDTO.Add(crsdto);
                }
            }
            else
            {
                return NotFound();
            }
            return Ok(courseDTO);
        }


        [HttpGet("{id}")]
        public ActionResult<CourseTopicDTO> GetCourse(int id)
        {
            Course c1 = _db.Course.Include(t => t.Top).FirstOrDefault(t => t.CrsId == id);
            CourseTopicDTO crs2 = new CourseTopicDTO()
            {
                Id = c1.CrsId,
                Cr_name = c1.CrsName,
                Cr_duration = c1.CrsDuration,
                TopicName = c1.Top.TopName,
                Topicid = c1.TopId,
            };

            return Ok(crs2);
            // return _db.Course.Include(t => t.Top).FirstOrDefault(t => t.CrsId == id);
        }

        
    }
}
