using CleanArchitecture.Application.Common.Interfaces.IAuthentication;
using CleanArchitecture.Domain.Entities.IdentityEntities;
using CleanArchitecture.WebCommon.ApiResult;
using CleanArchitecture.WebCommon.Filters;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.API.Controllers
{

    [ApiResultFilter]
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class TokenController : ControllerBase
    {
        private readonly IJWTService _jwtService;
 
        public TokenController(IJWTService jwtService)
        {           
            _jwtService = jwtService;
        }

        [HttpGet(Name = "GenerateToken")]   
        public ApiResult<string> GenerateToken()
        {
            var user = new User { UserName = "ali",PhoneNumber = "09134641220"};
            return Ok(_jwtService.GenerateToken(user));
        }        
    }
}