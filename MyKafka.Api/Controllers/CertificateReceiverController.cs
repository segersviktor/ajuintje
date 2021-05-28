using MediatR;
using Microsoft.AspNetCore.Mvc;
using MyKafka.Application.Logic.CertificateReceivers.Queries;
using System.Threading.Tasks;

namespace MyKafka.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CertificateReceiverController : ControllerBase
    {

        private readonly IMediator _mediator;

        public CertificateReceiverController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllCertificateReceivers")]
        public async Task<ActionResult<GetAllCertificateReceiverListDto>> GetAllCertificateReceivers()
        {
            var result = await _mediator.Send(new GetAllCertificateReceiversQuery());
            return Ok(result);
        }
    }
}