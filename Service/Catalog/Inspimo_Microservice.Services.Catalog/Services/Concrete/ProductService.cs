using Inspimo_Microservice.Services.Catalog.Dtos;
using Inspimo_Microservice.Services.Catalog.Services.Abstract;
using Inspimo_Microservice.Shared.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inspimo_Microservice.Services.Catalog.Services.Concrete
{
    public class ProductService : IProductService
    {
        public Task<Response<NoContent>> CreateAsync(CreateProductDto createProductDto)
        {
            throw new System.NotImplementedException();
        }

        public Task<Response<NoContent>> DeleteAsync(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Response<List<ResultProductDto>>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<Response<ResultProductDto>> GetByIdAsync(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Response<NoContent>> UpdateAsync(UpdateProductDto updateProductDto)
        {
            throw new System.NotImplementedException();
        }
    }
}
