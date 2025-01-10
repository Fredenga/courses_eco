using Courses.Core.Models;

namespace Courses.Services
{
    public interface ICourseService
    {
        public Task<List<CourseModel>> GetAllCoursesAsync(int? categoryId = null);
        public Task<CourseDetailModel> GetCourseDetailAsync(int courseId);
    }
}
