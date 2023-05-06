using AutoMapper;
using Lab1api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab1api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        ITIApiContext _db;
        private readonly IMapper _mapper;

        public CourseController(ITIApiContext db)
        {
            _db = db;
        }

        //getAll
        [HttpGet]
        public List<Course> GetAll()
        {
           return _db.Courses.ToList();  
        }


        [HttpGet("{id:int}")]
        public ActionResult<Course> GetByID(int id)
        {
            Course crs = _db.Courses.FirstOrDefault(x => x.ID == id);
            if (crs == null)
            {
                return NotFound();
            }
            return crs;
        }

        [HttpGet("{name:alpha}")]
        public ActionResult<Course> GetByName(string name)
        {
            Course crs = _db.Courses.FirstOrDefault(n => n.Crs_Name == name);
            if (crs == null)
            {
                return NotFound();
            }
            return crs;
        }

        //Add
        [HttpPost]
        public ActionResult Add(Course crs)
        {
            
            if (crs == null)  return BadRequest(); 
            if(!ModelState .IsValid) { return BadRequest(); }
            else
            {
                _db.Courses.Add(crs);
                _db.SaveChanges();
                return CreatedAtAction("GetByID", new { id = crs.ID }, crs);
            }
        }

        //Edite
        [HttpPut]
        public ActionResult Edit(Course crs,int id)
        {
            if (crs == null) return BadRequest();
            if (crs.ID != id) { return BadRequest(); }
            _db.Entry(crs).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _db.SaveChanges();
            return NoContent();

        }

        //Delete
        [HttpDelete("{id}")]
        public ActionResult<List<Course>> Delete(int id)
        {
            Course crs = _db.Courses.Find(id);
            if (crs == null) return NotFound();
            else
            {
                _db.Courses.Remove(crs);
                _db.SaveChanges();
                return Ok(_db.Courses);
            }
        }
    }
}
