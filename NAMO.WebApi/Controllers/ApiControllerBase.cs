using Microsoft.AspNetCore.Mvc;

namespace NAMO.WebApi.Controllers;

[ApiController]
[Route("web/[controller]/[action]/{id?}")]
public abstract class ApiControllerBase : ControllerBase
{

}
