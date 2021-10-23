using System;
using UserEntity = Fatec.Domain.Entities.User.User;
using JobCategoryEntity = Fatec.Domain.Entities.JobCategory.JobCategory;
using RequestEntity = Fatec.Domain.Entities.Request.Request;
using ContractEntity = Fatec.Domain.Entities.Contract.Contract;
using System.Collections.Generic;

namespace Fatec.Domain.Entities.Job
{
    public class Job : Entity
    {
        public UserEntity Provider { get; set; }
        public virtual long ProviderId { get; set; }
        public JobCategoryEntity JobCategory { get; set; }
        public virtual long JobCategoryId { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? BreakTime { get; set; }
        public DateTime? ReturnTime { get; set; }
        public DateTime EndTime { get; set; }
        public double PriceTime { get; set; }
        public ICollection<RequestEntity> Requests { get; set; }
        public ICollection<ContractEntity> Contracts { get; set; }
    }
}
