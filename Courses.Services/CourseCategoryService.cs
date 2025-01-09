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

        public Task<List<CourseCategoryModel>> GetCourseCategoriesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
