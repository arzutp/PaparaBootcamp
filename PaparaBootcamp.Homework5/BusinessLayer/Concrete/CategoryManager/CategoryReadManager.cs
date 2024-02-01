using AutoMapper;
using BusinessLayer.Abstract.CategoryService;
using BusinessLayer.Constants;
using BusinessLayer.Response;
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

namespace BusinessLayer.Concrete.CategoryManager
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

        }

        public async Task<ResponseDto<CategoryGetByIdDto>> GetById(int id)
        {
            var categoryGetById = await _categoryReadRepository.GetByIdAsync(id);
            CategoryGetByIdDto categoryGetByIdDto = _mapper.Map<CategoryGetByIdDto>(categoryGetById);
            if (categoryGetByIdDto == null)
            {
                return ResponseDto<CategoryGetByIdDto>.Fail(Messages.CategoryInvalid);
            }
            return ResponseDto<CategoryGetByIdDto>.Success(categoryGetByIdDto);
        }
    }
}
