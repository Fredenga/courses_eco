using Courses.Core.Models;
using Courses.Data;

namespace Courses.Services
{
    public class CourseService(ICourseRepository courseRepository) : ICourseService
    {
        private readonly ICourseRepository courseRepository = courseRepository;
        public async Task<List<CourseModel>> GetAllCoursesAsync(int? categoryId = null)
        {
            return await courseRepository.GetAllCoursesAsync(categoryId);
        }

        public async Task<CourseDetailModel> GetCourseDetailAsync(int courseId)
        {
            return await courseRepository.GetCourseDetailAsync(courseId);
        }
    }
}
