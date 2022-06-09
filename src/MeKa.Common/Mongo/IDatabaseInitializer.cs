using System.Threading.Tasks;

namespace MeKa.Common.Mongo
{
    public interface IDatabaseInitializer
    {
        Task InitializeAsync();
    }
}