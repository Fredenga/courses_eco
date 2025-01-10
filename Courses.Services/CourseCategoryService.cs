using Courses.Core.Mappers;
using Courses.Core.Models;
using Courses.Data;

namespace Courses.Services
{
    public class CourseCategoryService(ICourseCategoryRepository categoryRepository) : ICourseCategoryService
    {
        private readonly ICourseCategoryRepository categoryRepository = categoryRepository;
        public async Task<CourseCategoryModel> GetByIDAsync(int id)
        {
           var data = await categoryRepository.GetByIDAsync(id);
           var (model, _) = CourseCategoryMapper.ToCourseCategoryModel(data, null!);
            return model!;
        }

        public async Task<List<CourseCategoryModel>> GetCourseCategoriesAsync()
        {
            var data = await categoryRepository.GetCourseCategoriesAsync();
            var (_, models) = CourseCategoryMapper.ToCourseCategoryModel(null!, data);
            return models;
        }
    }
}
