using Courses.Core.Models;
using Courses.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Courses.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController(ICourseService courseService) : ControllerBase
    {
        private readonly ICourseService courseService = courseService;

        [HttpGet]
        public async Task<ActionResult<List<CourseModel>>> GetAllCoursesAsync()
        {
            var courses = await courseService.GetAllCoursesAsync();
            return Ok(courses);
        }

        [HttpGet("category/{categoryId:int}")]
        public async Task<ActionResult<List<CourseModel>>> GetAllCoursesByCategoryIdAsync([FromRoute] int categoryId)
        {
            var courses = await courseService.GetAllCoursesAsync(categoryId);
            return Ok(courses);
        }

        [HttpGet("detail/{courseId:int}")]
        public async Task<ActionResult<CourseDetailModel>> GetCourseDetailAsync(int courseId)
        {
            var courseDetail = await courseService.GetCourseDetailAsync(courseId);
            if (courseDetail is null) { 
                return NotFound();
            }
            return Ok(courseDetail);
        }
    }
}
