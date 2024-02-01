using AutoMapper;
using BusinessLayer.Abstract.CategoryService;
using BusinessLayer.Constants;
using BusinessLayer.Response;
using DataAccessLayer.Abstract.CategoryRepository;
using DataAccessLayer.Concrete.EntityFramework.CategoryRepositories;
using EntityLayer.DTOs.CategoryDTOs;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete.CategoryManager
{
    public class CategoryWriteManager : ICategoryWriteService
    {
        private readonly IMapper _mapper;
        private readonly ICategoryWriteRepository _categoryWriteRepository;

        public CategoryWriteManager(ICategoryWriteRepository categoryWriteRepository, IMapper mapper)
        {
            _categoryWriteRepository = categoryWriteRepository;
            _mapper = mapper;
        }

        public async Task<ResponseDto<CategoryAddDto>> AddCategory(CategoryAddDto request)
        {
            var categoryAddDto = _mapper.Map<Category>(request);          
            if(categoryAddDto == null) {
                return ResponseDto<CategoryAddDto>.Fail(Messages.AddFailMessage);
            }
            await _categoryWriteRepository.AddAsync(categoryAddDto);
            return ResponseDto<CategoryAddDto>.Success(request);
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(CategoryUpdateDto categoryUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
