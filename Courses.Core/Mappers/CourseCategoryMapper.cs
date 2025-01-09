

using Courses.Core.Entities;
using Courses.Core.Models;

namespace Courses.Core.Mappers
{
    public static class CourseCategoryMapper
    {
        public static (CourseCategoryModel, List<CourseCategoryModel>) ToCourseCategoryModel(CourseCategory courseCategory, List<CourseCategory> courseCategories)
        {
        
        if (courseCategory != null)
        {
            var entry = new CourseCategoryModel
            {
                CategoryId = courseCategory.CategoryId,
                CategoryName = courseCategory.CategoryName,
                Description = courseCategory.Description
            };
            return (entry, null)!;
        }

        
        if (courseCategories != null && courseCategories.Count != 0)
        {
                var entries = courseCategories.Select(c => new CourseCategoryModel {
                    CategoryId = c.CategoryId,
                    CategoryName = c.CategoryName,
                    Description = c.Description
                }).ToList();
            return (null, entries)!;
        }

        
        return (null, null)!;
    }
    }
}
