using PaparaHomework.Redis.Models.DTOs;
using PaparaHomework.Redis.Shared;

namespace PaparaHomework.Redis.Models.Products
{
    public interface IProductService
    {
        ResponseDto<List<ProductDto>> GetAll();
    }
}
