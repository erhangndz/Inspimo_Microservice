using Inspimo_Microservice.Services.Catalog.Dtos;
using Inspimo_Microservice.Shared.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inspimo_Microservice.Services.Catalog.Services.Abstract
{
    public interface IProductService
    {
        Task<Response<List<ResultProductDto>>> GetAllAsync();
        Task<Response<ResultProductDto>> GetByIdAsync(string id);
        Task<Response<NoContent>> CreateAsync(CreateProductDto createProductDto);
        Task<Response<NoContent>> UpdateAsync(UpdateProductDto updateProductDto);
        Task<Response<NoContent>> DeleteAsync(string id);
    }
}
