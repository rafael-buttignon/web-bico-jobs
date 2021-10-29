using AutoMapper;
using Fatec.Domain.Entities.Address;
using Fatec.Domain.Entities.User;
using Fatec.Domain.Exceptions;
using Fatec.Domain.Services.Interfaces.Address;
using Microsoft.AspNetCore.Mvc;
using ProjectFatec.WebApi.Models.Request;
using System;
using System.Net;
using System.Threading.Tasks;

namespace ProjectFatec.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : Controller
    {
        private readonly IAddressService _addressService;
        private readonly IMapper _mapper;

        public AddressController(IMapper mapper, IAddressService addressService)
        {
            _addressService = addressService ?? throw new ArgumentNullException(nameof(addressService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [Route("{id}")]
        public async Task<IActionResult> UpdateAddress([FromRoute] long id, AddressRequest request)
        {
            var address = _mapper.Map<Address>(request);
            var response = await _addressService.UpdateAddress(id, address);
            if (!response)
                return BadRequest();

            return Ok();
        }
    }
}