using AutoMapper;
using BusinessLayer.Abstract.CategoryService;
using DataAccessLayer.Abstract.CategoryRepository;
using DataAccessLayer.Concrete.EntityFramework.CategoryRepositories;
using DataAccessLayer.Contexts;
using EntityLayer.DTOs.CategoryDTOs;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryReadManager : ICategoryReadService
    {
        private readonly IMapper _mapper;
        private readonly ICategoryReadRepository _categoryReadRepository;

        public CategoryReadManager(IMapper mapper, ICategoryReadRepository categoryReadRepository)
        {
            _mapper = mapper;
            _categoryReadRepository = categoryReadRepository;
        }

        

        public List<CategoryGetAllDto> GetAll()
        {
            var categories = _categoryReadRepository.GetAll();
            var categoryGetAllDtos = _mapper.Map<List<CategoryGetAllDto>>(categories);
            return categoryGetAllDtos;
            //List<CategoryGetAllDto> categoryDtos = new List<CategoryGetAllDto>();
           
            //foreach (Category category in categories)
            //{
            //    categoryDtos.Add(new CategoryGetAllDto
            //    {
            //        Id = category.Id,
            //        Name = category.Name,
            //        Description = category.Description,
            //    });
            //}
            //return categoryDtos;
        }
    }
}
