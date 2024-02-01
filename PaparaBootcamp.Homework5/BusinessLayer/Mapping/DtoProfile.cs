using AutoMapper;
using EntityLayer.Entities;
using EntityLayer.DTOs.CategoryDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.DTOs.ProductDTOs;
using EntityLayer.DTOs.UserDTOs;
using EntityLayer.DTOs.ProductFeatureDTOs;
using EntityLayer.DTOs.ProductDefinitionDTOs;

namespace BusinessLayer.Mapping
{
    public class DtoProfile : Profile
    {
        public DtoProfile() {
            CreateMap<Category, CategoryGetAllDto>();
            CreateMap<Category, CategoryGetByIdDto>();
            CreateMap<Category, CategoryAddDto>().ReverseMap();
            CreateMap<Category, CategoryUpdateDto>().ReverseMap();

            CreateMap<Product, ProductGetAllDto>();
            CreateMap<Product, ProductGetByIdDto>();
            CreateMap<Product, ProductAddDto>().ReverseMap();
            CreateMap<Product, ProductUpdateDto>().ReverseMap();

            CreateMap<User, UserGetAllDto>();
            CreateMap<User, UserGetByIdDto>();
            CreateMap<User, UserAddDto>().ReverseMap();
            CreateMap<User, UserUpdateDto>().ReverseMap();

            CreateMap<ProductFeature, ProductFeatureGetAllDto>();
            CreateMap<ProductFeature, ProductFeatureGetByIdDto>();
            CreateMap<ProductFeature, ProductFeatureAddDto>().ReverseMap();
            CreateMap<ProductFeature, ProductFeatureUpdateDto>().ReverseMap();

            CreateMap<ProductDefinition, ProductDefinitionGetAllDto>();
            CreateMap<ProductDefinition, ProductDefinitionGetByIdDto>();
            CreateMap<ProductDefinition, ProductDefinitionAddDto>().ReverseMap();
            CreateMap<ProductDefinition, ProductDefinitionUpdateDto>().ReverseMap();
        }
    }
}
