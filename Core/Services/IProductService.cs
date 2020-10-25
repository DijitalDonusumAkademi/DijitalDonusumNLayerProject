using System.Threading.Tasks;
using Core.Models;

namespace Core.Services
{
    public interface IProductService:IService<Product>
    {
        // Biz iş süreçlerimizi service katmanında kodlarız***
        //bool ControlInnerBarcode(Product product)
        Task<Product> GetWithCategoryByIdAsync(int ProductId);
    }
}