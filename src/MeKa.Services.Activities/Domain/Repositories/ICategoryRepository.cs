using System.Collections.Generic;
using System.Threading.Tasks;
using MeKa.Services.Activities.Domain.Models;

namespace MeKa.Services.Activities.Domain.Repositories
{
    public interface ICategoryRepository
    {
        Task<Category> GetAsync(string name);
        Task<IEnumerable<Category>> BrowseAsync();
        Task AddAsync(Category category);
    }
}