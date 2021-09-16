using System;
using UserEntity = Fatec.Domain.Entities.User.User;
using RequestStatusEntity = Fatec.Domain.Entities.RequestStatus.RequestStatus;
using JobEntity = Fatec.Domain.Entities.Job.Job;
using ContractEntity = Fatec.Domain.Entities.Contract.Contract;

namespace Fatec.Domain.Entities.Request
{
    public class Request : Entity
    {
        public UserEntity ContractingUser { get; set; }
        public int AssignedTo { get; set; }
        public DateTime ApprovalDate { get; set; }
        public DateTime RejectionDate { get; set; }
        public JobEntity Job { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public RequestStatusEntity RequestStatus { get; set; }
        public long ContractId { get; set; }
        public ContractEntity Contract { get; set; }
    }
}
