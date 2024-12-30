using DotnetWorkshop.Core.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotnetWorkshop.API.Controllers
{
    [Route("api/[controller]")]
    //localhost:5000/api/Team
    [ApiController]
    public class CustomBaseController : ControllerBase
    {
        [NonAction]
        public IActionResult CreateActionResult<T>(GlobalResponseDto<T> response)
        {
            if(response.StatusCode == 204)
            {
                return new ObjectResult(null)
                {
                    StatusCode = response.StatusCode
                };
            }

            return new ObjectResult(response)
            {
                StatusCode = response.StatusCode
            };
        }
    }
}
