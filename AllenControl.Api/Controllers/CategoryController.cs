using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using AllenControl.Core.Stock.Services;

namespace AllenControl.Api.Controllers
{
    [RoutePrefix("api/v1/category")]
    public class CategoryController : BaseController
    {
        private readonly ICategoryAppService _service;

        public CategoryController(ICategoryAppService service)
        {
            _service = service;
        }

        [HttpGet, Route("")]
        public Task<HttpResponseMessage> Get()
        {
            return CreateResponse(HttpStatusCode.OK, _service.Get());
        }

        //[HttpGet, Route("{id:int:min(1)}")]
        //public Task<HttpResponseMessage> Get(int id)
        //{
        //    return CreateResponse(HttpStatusCode.OK, _service.GetById(id));
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="body">title: Título da categoria</param>
        /// <returns></returns>
        [HttpPost, Route("")]
        public Task<HttpResponseMessage> Post([FromBody] dynamic body)
        {
            return CreateResponse(HttpStatusCode.OK, _service.Register((string)body.title));
        }

        //[HttpPost, Route("{id:int:min(1)}")]
        //public Task<HttpResponseMessage> Edit([FromBody] dynamic body)
        //{
        //    return CreateResponse(HttpStatusCode.OK, _service.Edit(null));
        //}

        [HttpPut, Route("{id:guid:min(1)}/ativar")]
        public Task<HttpResponseMessage> Enable(string id)
        {
            return CreateResponse(HttpStatusCode.OK, _service.Enable(id));
        }

        [HttpPut, Route("{id:guid:min(1)}/inativar")]
        public Task<HttpResponseMessage> Disable(string id)
        {
            return CreateResponse(HttpStatusCode.OK, _service.Disable(id));
        }
    }
}
