using AutoMapper;
using Fatec.Domain.Entities.User;
using Fatec.Domain.Services.Interfaces.User;
using Microsoft.AspNetCore.Mvc;
using ProjectFatec.WebApi.Models.Request;
using ProjectFatec.WebApi.Models.Response.ViewModels;
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
        [ProducesResponseType(typeof(UserViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [Route("{id}")]
        public async Task<IActionResult> GetUserById([FromRoute] long id) 
        {
            var user = _mapper.Map<UserViewModel>(await _userService.GetUserById(id));

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

            var response = await _userService.CreateUser(user);

            if (!response)
                return BadRequest();

            return Ok();
        }

        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [Route("{id}")]
        public async Task<IActionResult> UpdateUser([FromRoute] long id, UserUpdateRequest request)
        {
            var user = _mapper.Map<User>(request);

            var response = await _userService.UpdateUser(id, user);

            if (!response)
                return BadRequest();

            return Ok();
        }
    }
}
