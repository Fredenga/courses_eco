using Courses.Core.Models;

namespace Courses.Services
{
    public interface ICourseCategoryService
    {
        Task<CourseCategoryModel> GetByIDAsync(int id);
        Task<List<CourseCategoryModel>> GetCourseCategoriesAsync();
    }
}
