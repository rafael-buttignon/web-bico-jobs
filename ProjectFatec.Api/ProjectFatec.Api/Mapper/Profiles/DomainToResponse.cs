using AutoMapper;
using Fatec.Domain.Entities.Job;
using Fatec.Domain.Entities.Request;
using ProjectFatec.WebApi.Models.Response.ViewModels;

namespace ProjectFatec.WebApi.Mapper.Profiles
{
    public class DomainToResponse : Profile
    {
        public DomainToResponse()
        {
            CreateMap<Job, JobViewModel>();
            CreateMap<Request, RequestViewModel>();
        }
    }
}
