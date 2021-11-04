using JobEntity = Fatec.Domain.Entities.Job.Job;

namespace ProjectFatec.WebApi.Models.Response.ViewModels
{
    public class RequestViewModel
    {
        public virtual long Id { get; set; }
        public virtual long ContractingUserId { get; set; }
        public string Description { get; set; }
        public JobEntity Job { get; set; }
        public virtual long RequestStatusId { get; set; }
    }
}
