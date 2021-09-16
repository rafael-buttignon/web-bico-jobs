using System.Collections.Generic;

namespace Fatec.Domain.Entities.ContractStatus
{
    public class ContractStatus : Entity
    {
        public string Description { get; set; }

        public static List<ContractStatus> GenerateSeed()
        {
            return new List<ContractStatus>
            {

            };
        }
    }
}
