using System;

namespace ProjectFatec.WebApi.Models.Request
{
    public class RequestRequest
    {
        public virtual long ContractingUserId { get; set; }
        public virtual long JobId { get; set; }
        public virtual long ProviderId { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}