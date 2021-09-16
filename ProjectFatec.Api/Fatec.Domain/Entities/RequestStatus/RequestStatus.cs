using System.Collections.Generic;

namespace Fatec.Domain.Entities.RequestStatus
{
    public class RequestStatus : Entity
    {
        public string Description { get; set; }

        public static List<RequestStatus> GenerateSeed()
        {
            return new List<RequestStatus>
            {

            };
        }
    }
}
