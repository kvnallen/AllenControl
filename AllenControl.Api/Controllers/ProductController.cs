using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using AllenControl.Core.Stock.Entities;
using AllenControl.Core.Stock.Repositories;
using AllenControl.Core.Stock.Services;

namespace AllenControl.Api.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IProductAppService _service;

        public ProductController(IProductAppService service)
        {
            _service = service;
        }

        [HttpGet]
        public Task<HttpResponseMessage> Get()
        {

            
            var message = Request.CreateResponse(HttpStatusCode.OK, _service.Get());


            return Task.FromResult(message);
        }
    }
}
