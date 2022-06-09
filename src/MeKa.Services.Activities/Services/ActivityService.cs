using System;
using System.Threading.Tasks;
using MeKa.Common.Exceptions;
using MeKa.Services.Activities.Domain.Models;
using MeKa.Services.Activities.Domain.Repositories;

namespace MeKa.Services.Activities.Services
{
    public class ActivityService : IActivityService
    {
        private readonly IActivityRepository _activityRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ActivityService(IActivityRepository activityRepository,
            ICategoryRepository categoryRepository)
        {
            _activityRepository = activityRepository;
            _categoryRepository = categoryRepository;
        }

        public async Task AddAsync(Guid id, Guid userId, string category, 
            string name, string description, DateTime createdAt)
        {
            var activityCategory = await _categoryRepository.GetAsync(category);
            if (activityCategory == null)
            {
                throw new CustomException("category_not_found", 
                    $"Category: '{category}' was not found.");
            }
            var activity = new Activity(id, activityCategory, userId,
                name, description, createdAt);
            await _activityRepository.AddAsync(activity);
        }
    }
}