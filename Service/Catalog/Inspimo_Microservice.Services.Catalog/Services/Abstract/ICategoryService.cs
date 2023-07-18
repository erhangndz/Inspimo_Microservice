using Inspimo_Microservice.Services.Catalog.Dtos;
using Inspimo_Microservice.Shared.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inspimo_Microservice.Services.Catalog.Services.Abstract
{
    public interface ICategoryService
    {
        Task<Response<List<ResultCategoryDto>>> GetAllAsync();
        Task<Response<ResultCategoryDto>> GetByIdAsync(string id);
        Task<Response<NoContent>> CreateAsync(CreateCategoryDto createCategoryDto);
        Task<Response<NoContent>> UpdateAsync(UpdateCategoryDto updateCategoryDto);
        Task<Response<NoContent>> DeleteAsync(string id);
    }
}
