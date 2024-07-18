using MediatR;
using Microsoft.AspNetCore.Mvc;
using NAMO.Application.Features.Patients.Queries.GetAvailableMoIds;
using NAMO.Application.Interfaces;
using NAMO.Domain.Common;
using NAMO.Domain.Entities;
using NLog;

namespace NAMO.WebApi.Controllers
{
    public class AvailableMoController : ApiControllerBase
    {
        private readonly IHttpContextService _httpContextService;
        private readonly IMediator _mediator;

        public AvailableMoController(IHttpContextService httpContextService, IMediator mediator)
        {
            _httpContextService = httpContextService;
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<object>> GetAvailableMoIds([FromBody] PatientInfoRequest request)
        {
            using (ScopeContext.PushProperty("clientIpAddress", _httpContextService.GetClientIpAddresses()))
            using (ScopeContext.PushProperty("requestEndpoint", _httpContextService.GetRequestEndpoint()))
            using (ScopeContext.PushProperty("requestMethod", _httpContextService.GetRequestMethod()))
            {
                return await _mediator.Send(new GetAvailableMoIdsQuery(request));
            }
        }
    }
}
