using Fatec.Domain.Exceptions;
using Fatec.Domain.Services.Interfaces.User;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;

namespace ProjectFatec.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService) 
        {
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
        }

        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [Route("{userId}")]
        public async Task<IActionResult> GetUserById([FromRoute] long userId) 
       {
            var user = await _userService.GetUserById(userId);

            if (user == null) 
                return BadRequest();

            return Ok(user);
        }
    }
}
