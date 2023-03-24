using firstAPIApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace firstAPIApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        [HttpGet]
        public IActionResult get()
        {
            if (CourseList.courseList.Count == 0)
            {
                return NotFound();
            }

            return Ok(CourseList.courseList);
        }

        [HttpDelete("{id:int}")] 
        public IActionResult deleteCourse(int id)
        {
            var course = CourseList.courseList.FirstOrDefault(c => c.id == id);

            if (course == null)
            {
                return NotFound();
            }

            try
            {
                CourseList.courseList.Remove(course);
                return Ok(CourseList.courseList);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPut("{id:int}")]
        public IActionResult put(int id, Course course)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var existingCourse = CourseList.courseList.FirstOrDefault(c => c.id == id);
                    if (existingCourse == null)
                    {
                        return NotFound();
                    }

                    existingCourse.name = course.name;
                    existingCourse.Duration = course.Duration;
                    existingCourse.Description = course.Description;
                    return StatusCode(200, "Data Updated");
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
                
            }

            return BadRequest(ModelState);
        }

        [HttpPost]
        public IActionResult post(Course course)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    CourseList.courseList.Add(course);
                    //to return created we must send url to the object created and the obj itself
                    //to make a url that detect any domain (after deployment) we use this function
                    string url = Url.Link("GetID", new { id = course.id });
                    return Created(url, course);
                    
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }


            return BadRequest(ModelState);
        }
        [HttpGet("{id:int}",Name ="GetID")]//if we put "/" before id so it consider this url after base url and will not incude api/controller
        //sholud put route to diff. btw all get methods 
        public IActionResult getById(int id)
        {
            var course = CourseList.courseList.FirstOrDefault(c => c.id == id);

            if (course == null)
            {
                return NotFound();
            }

            return Ok(course);
        }
        [HttpGet("{name:alpha}")]//should put constrain(alpha or int) to diff between getbyid and getbyname 
        public IActionResult courseByName(string name)
        {
            var course = CourseList.courseList.FirstOrDefault(c => c.name.ToLower() == name.ToLower());

            if (course == null)
            {
                return NotFound();
            }

            return Ok(course);
        }
    }
}
