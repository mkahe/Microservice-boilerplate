using System.Threading.Tasks;

namespace MeKa.Common.Mongo
{
    public interface IDatabaseSeeder
    {
        Task SeedAsync();
    }
}