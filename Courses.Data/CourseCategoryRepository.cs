using Courses.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Courses.Data
{
    public class CourseCategoryRepository(CoursesDbContext dbContext) : ICourseCategoryRepository
    {
        private readonly CoursesDbContext dbContext = dbContext;

        public async Task<CourseCategory> GetByIDAsync(int id)
        {
            var data = await dbContext.CourseCategories.FindAsync(id);
            return data!;
        }

        public async Task<List<CourseCategory>> GetCourseCategoriesAsync()
        {
            var data = await dbContext.CourseCategories.ToListAsync();
            return data!;
        }
    }
}
