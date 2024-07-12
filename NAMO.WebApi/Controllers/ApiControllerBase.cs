using Microsoft.AspNetCore.Mvc;

namespace NAMO.WebApi.Controllers
{
    [ApiController]
    [Route("web/[controller]/[action]")]
    public abstract class ApiControllerBase : ControllerBase
    {

    }
}
