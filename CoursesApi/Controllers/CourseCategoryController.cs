using Courses.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Courses.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseCategoryController(ICourseCategoryService service) : ControllerBase
    {
        private readonly ICourseCategoryService service = service;
    }
}
