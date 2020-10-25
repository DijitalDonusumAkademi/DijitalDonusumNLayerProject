using System.Threading.Tasks;
using Core.Models;

namespace Core.Repositories
{
    public interface ICategoryRepository:IRepository<Category>
    {
        // Category'ye Özel Custom İşlemler İçin 
        Task<Category> GetWithProductsByIdAsync(int categoryId);
    }
}