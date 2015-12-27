using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using DomainNotificationHelper;
using DomainNotificationHelper.Events;

namespace AllenControl.Api.Controllers
{

    public class BaseController : ApiController
    {
        private readonly IHandler<DomainNotification> _notifications;
        private HttpResponseMessage _responseMessage;

        public BaseController()
        {
            _notifications = DomainEvent.Container.GetService<IHandler<DomainNotification>>();
            _responseMessage = new HttpResponseMessage();
        }

        public Task<HttpResponseMessage> CreateResponse(HttpStatusCode statusCode, object obj)
        {
            _responseMessage = _notifications.HasNotifications()
                ? Request.CreateResponse(HttpStatusCode.BadRequest, _notifications.Notify())
                : Request.CreateResponse(statusCode, obj);

            return Task.FromResult(_responseMessage);
        }
    }
}