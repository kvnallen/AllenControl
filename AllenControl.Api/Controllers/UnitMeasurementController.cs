using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using AllenControl.Core.Stock.Services;

namespace AllenControl.Api.Controllers
{
    [RoutePrefix("api/v1/unitmeasurement")]
    public class UnitMeasurementController : BaseController
    {
        private readonly IUnitOfMeasurementAppService _service;

        public UnitMeasurementController(IUnitOfMeasurementAppService service)
        {
            _service = service;
        }


        [HttpGet, Route("")]
        public Task<HttpResponseMessage> Get()
        {
            return CreateResponse(HttpStatusCode.Created, _service.Get());
        }

        [HttpPost, Route("")]
        public Task<HttpResponseMessage> Post([FromBody] string name)
        {
            return CreateResponse(HttpStatusCode.Created, _service.Register(name));
        }
    }
}
