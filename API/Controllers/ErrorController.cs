using API.Errors;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("error/{code}")]
    public class ErrorController : BaseController
    {
        public IActionResult Error(int Code)
        {
            return new ObjectResult(new ApiResponse(Code));
        }
    }
}