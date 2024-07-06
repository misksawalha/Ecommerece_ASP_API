using Ecommerce.Core.Entities;
using Ecommerce.Core.IRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IGenericRepository<Categories> genericRepository;

        public CategoryController(IGenericRepository<Categories>genericRepository)
        {
            this.genericRepository = genericRepository;
        }

    }
}
