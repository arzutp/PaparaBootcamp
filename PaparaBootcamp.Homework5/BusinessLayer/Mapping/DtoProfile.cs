using AutoMapper;
using EntityLayer.Entities;
using EntityLayer.DTOs.CategoryDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Mapping
{
    public class DtoProfile : Profile
    {
        public DtoProfile() {
            CreateMap<Category, CategoryGetAllDto>().ReverseMap();
        }
    }
}
