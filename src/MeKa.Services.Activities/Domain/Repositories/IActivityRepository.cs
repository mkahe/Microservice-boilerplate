using System;
using System.Threading.Tasks;
using MeKa.Services.Activities.Domain.Models;

namespace MeKa.Services.Activities.Domain.Repositories
{
    public interface IActivityRepository
    {
        Task<Activity> GetAsync(Guid id);
        Task AddAsync(Activity activity);
        Task DeleteAsync(Guid id);
    }
}