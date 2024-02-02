using AutoMapper;
using PaparaHomework.Redis.Models.DTOs;
using PaparaHomework.Redis.Models.Products;

namespace PaparaHomework.Redis.Mapper
{
    public class DtoProfile : Profile
    {
        public DtoProfile() {
            CreateMap<Product, ProductDto>();
        }
        
    }
}
