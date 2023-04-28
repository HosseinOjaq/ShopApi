using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebFramework.Api;
using WebFramework.Filters;

namespace MyApi.Controllers.v1
{
    [ApiVersion("1")]
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiResultFilter]
    [ApiController]
    public class CategoriesController : BaseController
    {

    }
}