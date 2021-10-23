using System;

namespace ProjectFatec.WebApi.Models.Request
{
    public class JobRequest
    {
        public virtual long ProviderId { get; set; }
        public virtual long JobCategoryId { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? BreakTime { get; set; }
        public DateTime? ReturnTime { get; set; }
        public DateTime EndTime { get; set; }
        public double PriceTime { get; set; }
    }
}


