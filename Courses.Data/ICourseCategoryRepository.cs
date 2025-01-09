using Courses.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Data
{
    // Async Methods always return a Task<T>
    public interface ICourseCategoryRepository
    {
        Task<CourseCategory> GetByIDAsync(int id);
        Task<List<CourseCategory>> GetCourseCategoriesAsync();
    }
}
