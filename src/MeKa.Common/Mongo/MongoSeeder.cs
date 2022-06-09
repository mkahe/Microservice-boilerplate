using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace MeKa.Common.Mongo
{
    public class MongoSeeder : IDatabaseSeeder
    {
        protected readonly IMongoDatabase Database;

        public MongoSeeder(IMongoDatabase database)
        {
            Database = database;
        } 

        public async Task SeedAsync()
        {
            var collectionsCursor = await Database.ListCollectionsAsync();
            var collections = await collectionsCursor.ToListAsync();
            if (collections.Any())
            {
                return;
            }
            await CustomSeedAsync();
        }

        /// <summary>
        /// If it has not been inherited by a child class, this will do nothing
        /// </summary>
        protected virtual async Task CustomSeedAsync()
        {
            await Task.CompletedTask;
        }
    }
}