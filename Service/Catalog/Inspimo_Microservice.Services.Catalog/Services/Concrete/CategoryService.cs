using AutoMapper;
using Inspimo_Microservice.Services.Catalog.Dtos;
using Inspimo_Microservice.Services.Catalog.Models;
using Inspimo_Microservice.Services.Catalog.Services.Abstract;
using Inspimo_Microservice.Services.Catalog.Settings.Abstract;
using Inspimo_Microservice.Shared.Dtos;
using MongoDB.Driver;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Inspimo_Microservice.Services.Catalog.Services.Concrete
{
    public class CategoryService : ICategoryService
    {
        private readonly IMongoCollection<Category> _categoryCollection;
        private readonly IMapper _mapper;

        public CategoryService(IMapper mapper,IDatabaseSettings databaseSettings)
        {
            _mapper = mapper;
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _categoryCollection = database.GetCollection<Category>(databaseSettings.CategoryCollectionName);
        }

        public async Task<Response<NoContent>> CreateAsync(CreateCategoryDto createCategoryDto)
        {
           var values = _mapper.Map<Category>(createCategoryDto);
            await _categoryCollection.InsertOneAsync(values);
            return Response<NoContent>.Success(200);
        }

        public async Task<Response<NoContent>> DeleteAsync(string id)
        {
           var result = await _categoryCollection.DeleteOneAsync(x=>x.CategoryID==id);
            return Response<NoContent>.Success(200);
        }

        public async Task<Response<List<ResultCategoryDto>>> GetAllAsync()
        {
            var values= await _categoryCollection.Find(value=>true).ToListAsync();
            return Response<List<ResultCategoryDto>>.Success(_mapper.Map<List<ResultCategoryDto>>(values),200);

        }

        public async Task<Response<ResultCategoryDto>> GetByIdAsync(string id)
        {
            var value = await  _categoryCollection.Find<Category>(x=>x.CategoryID==id).FirstOrDefaultAsync();
            if (value == null)
            {
                return Response<ResultCategoryDto>.Fail("Kategori Bulunamadı", 404);

            }

            return Response<ResultCategoryDto>.Success(_mapper.Map<ResultCategoryDto>(value),200);
            
        }

        public async Task<Response<NoContent>> UpdateAsync(UpdateCategoryDto updateCategoryDto)
        {
            var values = _mapper.Map<Category>(updateCategoryDto);
            var result = await _categoryCollection.FindOneAndReplaceAsync(x => x.CategoryID == updateCategoryDto.CategoryID, values);
            return Response<NoContent>.Success(200);
        }
    }
}
