﻿using AutoMapper;
using PaparaBootcamp.Homework2.Models.Users.DTOs;
using PaparaBootcamp.Homework2.Models.Users.Entity;

namespace PaparaBootcamp.Homework2.Mapping
{
    public class DtoProfile : Profile
    {
        public DtoProfile() { 
            CreateMap<User, UserGetAllDto>();
            CreateMap<User, UserGetByIdDto>();
            CreateMap<User, UserGetByAgeDto>();
            CreateMap<User, UserGetByNameDto>().ReverseMap();
        }
    }
}
