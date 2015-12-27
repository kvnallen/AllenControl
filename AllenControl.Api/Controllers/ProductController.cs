using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using AllenControl.Core.Stock.Entities;
using AllenControl.Core.Stock.Services;

namespace AllenControl.Api.Controllers
{
    [RoutePrefix("api/v1/product")]
    public class ProductController : BaseController
    {
        private readonly IProductAppService _service;

        public ProductController(IProductAppService service)
        {
            _service = service;
        }

        [HttpGet, Route]
        public Task<HttpResponseMessage> Get()
        {
            return CreateResponse(HttpStatusCode.OK, _service.Get());
        }

        [HttpPost, Route]
        public Task<HttpResponseMessage> Post([FromBody] Product product)
        {
            return CreateResponse(HttpStatusCode.OK, _service.Register(product));
        }
    }
}