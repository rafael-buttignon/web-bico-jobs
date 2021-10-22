using AutoMapper;
using Fatec.Domain.Entities.User;
using Fatec.Domain.Exceptions;
using Fatec.Domain.Services.Interfaces.User;
using Microsoft.AspNetCore.Mvc;
using ProjectFatec.WebApi.Models.Request;
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
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper) 
        {
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
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

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> CreateUser(UserRequest request)
        {
            var user = _mapper.Map<User>(request);
            await _userService.CreateUser(user);
            return Ok();       
        }
    }
}
