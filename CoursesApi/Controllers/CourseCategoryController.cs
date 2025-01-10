using Courses.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Courses.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseCategoryController(ICourseCategoryService service) : ControllerBase
    {
        private readonly ICourseCategoryService categoryService = service;

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var category = await categoryService.GetByIDAsync(id);
            if(category is null)
            {
                return NotFound();
            }
            return Ok(category);
        }

        [HttpGet()]
        public async Task<IActionResult> GetAll()
        {
            var categories = await categoryService.GetCourseCategoriesAsync();
            // implement method
            return Ok(categories);
        }
    }
}
