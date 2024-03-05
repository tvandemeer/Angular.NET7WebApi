using CodePulse.API.Models.Domain;

namespace CodePulse.API.Repositories.Interface
{
    public interface ICategoryRepository
    {
        Task<List<Category>> GetAll();
        Task<Category> CreateAsync(Category category);
    }
}
