using System;
using JobEntity = Fatec.Domain.Entities.Job.Job;
using UserEntity = Fatec.Domain.Entities.User.User;
using RequestEntity = Fatec.Domain.Entities.Request.Request;
using ContractStatusEntity = Fatec.Domain.Entities.ContractStatus.ContractStatus;

namespace Fatec.Domain.Entities.Contract
{
    public class Contract : Entity
    {
        public RequestEntity Request { get; set; }
        public UserEntity ContractUser { get; set; }
        public string Description { get; set; }
        public double? Price { get; set; }
        public JobEntity Job { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TotalDays { get; set; }
        public ContractStatusEntity ContractStatus { get; set; }
        public int? Evaluation { get; set; }
    }
}
