using AutoMapper;
using Inspimo_Microservice.Services.Catalog.Dtos;
using Inspimo_Microservice.Services.Catalog.Models;
using Inspimo_Microservice.Services.Catalog.Services.Abstract;
using Inspimo_Microservice.Shared.Dtos;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inspimo_Microservice.Services.Catalog.Services.Concrete
{
    public class CategoryService : ICategoryService
    {
        private readonly IMongoCollection<Category> _categoryCollection;
        private readonly IMapper _mapper;

        public Task<Response<NoContent>> CreateAsync(CreateCategoryDto createCategoryDto)
        {
            throw new System.NotImplementedException();
        }

        public Task<Response<NoContent>> DeleteAsync(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Response<List<ResultCategoryDto>>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<Response<ResultCategoryDto>> GetByIdAsync(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Response<NoContent>> UpdateAsync(UpdateCategoryDto updateCategoryDto)
        {
            throw new System.NotImplementedException();
        }
    }
}
