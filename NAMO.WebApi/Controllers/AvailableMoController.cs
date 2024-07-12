using MediatR;
using Microsoft.AspNetCore.Mvc;
using NAMO.Application.Features.Patients.Queries.GetAvailableMoIds;
using NAMO.Domain.Entities;

namespace NAMO.WebApi.Controllers
{
    public class AvailableMoController : ApiControllerBase
    {
        private readonly IMediator _mediator;

        public AvailableMoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<object>> GetAvailableMoIds([FromBody] PatientInfoRequest request)
        {
            return await _mediator.Send(new GetAvailableMoIdsQuery(request));
        }


    }
}
