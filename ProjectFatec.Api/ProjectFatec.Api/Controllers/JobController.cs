using AutoMapper;
using Fatec.Domain.Entities.Job;
using Fatec.Domain.Services.Interfaces.Job;
using Microsoft.AspNetCore.Mvc;
using ProjectFatec.WebApi.Models.Request;
using System;
using System.Net;
using System.Threading.Tasks;

namespace ProjectFatec.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : Controller
    {
        private readonly IJobService _jobService;
        private readonly IMapper _mapper;

        public JobController(IMapper mapper, IJobService jobService)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _jobService = jobService ?? throw new ArgumentNullException(nameof(jobService));
        }

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> CreateJob([FromBody] JobRequest request)
        {
            var job = _mapper.Map<Job>(request);
            await _jobService.CreateJob(job);
            return Ok();
        }
    }
}
